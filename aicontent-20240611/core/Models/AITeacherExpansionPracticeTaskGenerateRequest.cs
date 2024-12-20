// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class AITeacherExpansionPracticeTaskGenerateRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("grade")]
        [Validation(Required=false)]
        public string Grade { get; set; }

        [NameInMap("keySentences")]
        [Validation(Required=false)]
        public List<string> KeySentences { get; set; }

        [NameInMap("keyWords")]
        [Validation(Required=false)]
        public List<string> KeyWords { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Understanding unique professions such as dog walkers, hotel test sleepers, and food tasters, including their job responsibilities and the benefits or challenges associated with each role.</para>
        /// </summary>
        [NameInMap("learningObject")]
        [Validation(Required=false)]
        public string LearningObject { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dog walker Dog walking, as a profession, originated in the US. Some may think that it\&quot;s a perfect job, because dog walkers won\&quot;t be imprisoned in an office. But it\&quot;s actually manual labour. At their busiest, dog walkers may have more than ten dogs to take care of in a day. Hotel test sleeper A hotel test sleeper, as the name suggests, has to write expert reviews about the facilities, locations, prices, dining and other services of hotels, in order to provide evaluations and guides for travelers. Hotel test sleepers don\&quot;t need to punch in for work and they get about ten thousand yuan as income every month. What a comfortable job! Food taster In ancient times, a food taster was a person who tasted foods (or drinks) to be served to someone else, to confirm that it was safe to eat. But now, those working as food tasters just get to taste various new foods and drinks aimed at specific regions across the world. They then give their opinions on these products to the companies and suggest improvements.</para>
        /// </summary>
        [NameInMap("textContent")]
        [Validation(Required=false)]
        public string TextContent { get; set; }

        [NameInMap("textbook")]
        [Validation(Required=false)]
        public string Textbook { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>talk about your dream job.</para>
        /// </summary>
        [NameInMap("topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6440xxxxxxxxxx5fafc98c421</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
