// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class CreateCloudNotePhrasesRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can create and query application IDs in the console. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac7N****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The hotword parameter.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Phrase")]
        [Validation(Required=false)]
        public CreateCloudNotePhrasesRequestPhrase Phrase { get; set; }
        public class CreateCloudNotePhrasesRequestPhrase : TeaModel {
            /// <summary>
            /// <para>The description. The description must be encoded in UTF-8 and be 1 to 200 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Fruit description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the hotword table. The name must be encoded in UTF-8 and be 1 to 30 characters in length.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Fruits</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Each hotword table can contain up to 300 hotwords, and each hotword can be up to 10 Chinese characters in length.</para>
            /// <para>Hotwords must be encoded in UTF-8 and cannot contain punctuation marks or special characters. Otherwise, the hotwords do not take effect.</para>
            /// <para>The weight of a hotword must be an integer in the range of [-6, 5].</para>
            /// <para>Numbers in the text must be replaced with the corresponding Chinese characters based on their pronunciation. For example, &quot;59.9元&quot; must be replaced with &quot;五十九点九元&quot;.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("WordWeights")]
            [Validation(Required=false)]
            public List<CreateCloudNotePhrasesRequestPhraseWordWeights> WordWeights { get; set; }
            public class CreateCloudNotePhrasesRequestPhraseWordWeights : TeaModel {
                /// <summary>
                /// <para>The weight must be an integer in the range of [-6, 5].</para>
                /// <list type="bullet">
                /// <item><description>A value greater than 0 increases the probability of the word being recognized, and a value less than 0 decreases the probability.</description></item>
                /// <item><description>A value of -6 indicates that the word should not be recognized if possible.</description></item>
                /// <item><description>A value of 2 is a common value.
                /// If the effect is not obvious, you can increase the weight. However, a large weight may cause negative effects and lead to inaccurate recognition of other words.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

                /// <summary>
                /// <para>The hotword.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Apple</para>
                /// </summary>
                [NameInMap("Word")]
                [Validation(Required=false)]
                public string Word { get; set; }

            }

        }

    }

}
