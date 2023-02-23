@page
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}

<div class="text-center">
    <h1 class="display-4">Hello World!</h1>
    <p>오늘은 [@DateTime.Now.DayOfWeek]입니다.</p>
   <p>현재 시간은[ @DateTime.Now]입니다.</p>
</div>
