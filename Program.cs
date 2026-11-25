
using job_sequencing;
using System.Linq;

job j1 = new("j1", 35, 3);
job j2 = new("j2", 30, 4);
job j3 = new("j3", 25, 4);
job j4 = new("j4", 20, 2);
job j5 = new("j5", 15, 3);
job j6 = new("j6", 12, 1);
job j7 = new("j7", 5, 2);


List<job> job_sequencing = [j1, j2, j3, j4, j5, j6, j7];
var job_sorted_by_profit = job_sequencing.OrderByDescending(j => j.profit);


var work_sequence = new Dictionary<int,string>();
int profit = 0;
foreach (var job in job_sorted_by_profit)
{

        for(int i = job.deadline; i > 0; i--)
        {
            if (!work_sequence.ContainsKey(i))
            {
                profit += job.profit;
                work_sequence.Add(i,job.name);
                break;
            }
        }
    

}
var ordered_work = work_sequence.OrderBy(w => w.Key);

Console.WriteLine($"Total Profit: {profit}");
Console.Write(string.Join(", ", ordered_work.Select(w => w.Value)));



