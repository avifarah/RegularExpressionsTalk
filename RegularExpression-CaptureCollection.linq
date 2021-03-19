<Query Kind="Statements">
  <Output>DataGrids</Output>
</Query>

var text = "The silver fox jumped over the lazy dog ";
var pat = @"(?<sentence>((?<word>\w+)\s)+)";
var re = new Regex(pat);
var m = re.Match(text);
var lastWord = m.Groups["word"].Value;
Console.WriteLine($"Last word: {lastWord}");
Console.WriteLine($"Sentence:  {m.Groups["sentence"].Value}");
var cs = m.Groups["word"].Captures;
// Assumption cs.Count > 0
foreach (Capture c in cs)
	Console.WriteLine(c.Value);
