#pragma checksum "C:\Users\Baturay Yasar\Visual Studio Code\blazorserver01\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f83c0d6ee9e063b607e2ecdcfc4fece11bbda648"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazorserver01.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Baturay Yasar\Visual Studio Code\blazorserver01\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Baturay Yasar\Visual Studio Code\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Baturay Yasar\Visual Studio Code\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Baturay Yasar\Visual Studio Code\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Baturay Yasar\Visual Studio Code\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Baturay Yasar\Visual Studio Code\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Baturay Yasar\Visual Studio Code\blazorserver01\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Baturay Yasar\Visual Studio Code\blazorserver01\_Imports.razor"
using blazorserver01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Baturay Yasar\Visual Studio Code\blazorserver01\_Imports.razor"
using blazorserver01.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Baturay Yasar\Visual Studio Code\blazorserver01\Pages\Counter.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Baturay Yasar\Visual Studio Code\blazorserver01\Pages\Counter.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Baturay Yasar\Visual Studio Code\blazorserver01\Pages\Counter.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Baturay Yasar\Visual Studio Code\blazorserver01\Pages\Counter.razor"
using tutorialParallelism.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\Baturay Yasar\Visual Studio Code\blazorserver01\Pages\Counter.razor"
       
    private static int currentCount = 0;
    List<MovingBall> balls = new List<MovingBall>();
    static Timer mytimer = new Timer();
    public void init_balls (){
        Random random = new Random(230);
        MovingBall p;
        for (int i = 0; i < 50; i++){
            int x = random.Next(10,190);
            int y = random.Next(10,190);
            p = new MovingBall(x,y);
            p.color = "#ABE280";
            p.setLimitX(10,190);
            p.setLimitY(10,190);
            x = random.Next(0,4);
            y = random.Next(0,4);
            p.setVelocity(x,y);
            balls.Add(p);
        }
    }
    public int sense = 1;
    public void StartAnimation ()
    {
        init_balls();
            mytimer.Interval = 50;
            mytimer.Elapsed += Animation;
        mytimer.Start();
        currentCount++;
    }
    public void StopAnimation (){
        mytimer.Stop();
     }
     public void Animation(object sender,EventArgs e) 
     {
         currentCount++;
         foreach(var ball in balls) ball.next();
             InvokeAsync(StateHasChanged);
     }
    public int x = 50, y = 50;
    private void IncrementCount()
    {   
        if(currentCount==0)
        {
            mytimer.Interval= 1000;
            mytimer.Elapsed += IncrementCountAgain;
            mytimer.Start();
        }
        currentCount++;
    }

    private void IncrementCountAgain(Object sender,EventArgs e)
    {
            currentCount++;
            Console.WriteLine("Again " + currentCount.ToString());
                if(currentCount>10)
                {
                    mytimer.Dispose();
                }
            InvokeAsync(StateHasChanged);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
