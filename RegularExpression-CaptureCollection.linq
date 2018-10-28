<Query Kind="Statements">
  <Output>DataGrids</Output>
</Query>

var text = "The silver fox jumped over the lazy dog ";
var pat = @"(?<sentence>((?<word>\w+)\s)+)";
var re = new Regex(pat);
var m = re.Match(text);

// Sentence
if (!m.Groups["sentence"].Success)
{
	Console.WriteLine("Sentence as a group was not found");
	return;
}
Console.WriteLine($"Sentense: {m.Groups["sentence"].Value}");

// Word
if (!m.Groups["word"].Success)
{
	Console.WriteLine("Word as a group was not found");
	return;
}
Console.WriteLine($"Last word: {m.Groups["word"].Value}");

// All the words
var cs = m.Groups["word"].Captures;
foreach (Capture c in cs)
{
	Console.WriteLine($"Capture: {c.Value}");
}
