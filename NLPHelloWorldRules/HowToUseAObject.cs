using AboditNLP;
using AboditNLP.Attributes;
using AboditNLP.Article;
using AboditNLP.Determiner;
using AboditNLP.Noun;
using AboditNLP.Pronoun;
using AboditNLP.Verb;
using AboditNLP.Preposition;
using AboditNLP.Question;
using AboditNLP.Punctuation;
using Abodit.Temporal;
using AboditNLP.Adjective;

namespace NLPHelloWorldRules
{
    public partial class SampleRules : INLPRule
    {
        /// <summary>
        /// This sample rule recognizes any house object name alone
        /// </summary>
        /// <remarks>
        /// very crude test
        /// </remarks>
        public NLPActionResult RecogniseHouseBaseObject(HouseLexeme houseLex)
        {
            st.Say($"RecogniseHouseBaseObject: Object Name: {houseLex.Value.Name}");
            return NLPActionResult.None;
        }
    }
}