// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListInterventionDictionaryEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>516A02B7-2167-8D92-12D0-B639A2A0F3C5</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about intervention entries.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/173606.html">InterventionDictionaryEntry</a>.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListInterventionDictionaryEntriesResponseBodyResult> Result { get; set; }
        public class ListInterventionDictionaryEntriesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The command. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>add</description></item>
            /// <item><description>delete</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>add</para>
            /// </summary>
            [NameInMap("cmd")]
            [Validation(Required=false)]
            public string Cmd { get; set; }

            /// <summary>
            /// <para>The timestamp when the intervention entry was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1536690285</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public long? Created { get; set; }

            /// <summary>
            /// <para>The content of an intervention entry for category prediction. The field value consists of key-value pairs. The key in a key-value pair indicates the ID of the category. The value in a key-value pair indicates the relevance to the category. A value of 0 indicates irrelevant. A value of 1 indicates slightly relevant. A value of 2 indicates relevant. Example: {&quot;2&quot;:1, &quot;100&quot;:0}</para>
            /// 
            /// <b>Example:</b>
            /// <para>{                 &quot;100&quot;: &quot;0&quot;,                 &quot;200&quot;: &quot;2&quot;             }</para>
            /// </summary>
            [NameInMap("relevance")]
            [Validation(Required=false)]
            public Dictionary<string, object> Relevance { get; set; }

            /// <summary>
            /// <para>The status of the intervention entry. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>ACTIVE: The intervention entry takes effect.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The content of the intervention entry for term weight analysis.</para>
            /// </summary>
            [NameInMap("tokens")]
            [Validation(Required=false)]
            public List<ListInterventionDictionaryEntriesResponseBodyResultTokens> Tokens { get; set; }
            public class ListInterventionDictionaryEntriesResponseBodyResultTokens : TeaModel {
                /// <summary>
                /// <para>The sequence number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                /// <summary>
                /// <para>The internal name of the identified entity type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>brand</description></item>
                /// <item><description>category</description></item>
                /// <item><description>material</description></item>
                /// <item><description>element</description></item>
                /// <item><description>style</description></item>
                /// <item><description>color</description></item>
                /// <item><description>function</description></item>
                /// <item><description>scenario</description></item>
                /// <item><description>people</description></item>
                /// <item><description>season</description></item>
                /// <item><description>model</description></item>
                /// <item><description>region</description></item>
                /// <item><description>name</description></item>
                /// <item><description>adjective</description></item>
                /// <item><description>category-modifier</description></item>
                /// <item><description>size</description></item>
                /// <item><description>quality</description></item>
                /// <item><description>suit</description></item>
                /// <item><description>new-release</description></item>
                /// <item><description>series</description></item>
                /// <item><description>marketing</description></item>
                /// <item><description>entertainment</description></item>
                /// <item><description>organization</description></item>
                /// <item><description>movie</description></item>
                /// <item><description>game</description></item>
                /// <item><description>number</description></item>
                /// <item><description>unit</description></item>
                /// <item><description>common</description></item>
                /// <item><description>new-word</description></item>
                /// <item><description>proper-noun</description></item>
                /// <item><description>symbol</description></item>
                /// <item><description>prefix</description></item>
                /// <item><description>suffix</description></item>
                /// <item><description>gift</description></item>
                /// <item><description>negative</description></item>
                /// <item><description>agent</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>category</para>
                /// </summary>
                [NameInMap("tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The description of the internal name of the identified entity type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>category</para>
                /// </summary>
                [NameInMap("tagLabel")]
                [Validation(Required=false)]
                public string TagLabel { get; set; }

                /// <summary>
                /// <para>The entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>category</para>
                /// </summary>
                [NameInMap("token")]
                [Validation(Required=false)]
                public string Token { get; set; }

            }

            /// <summary>
            /// <para>The timestamp when the intervention entry was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1537348987</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public long? Updated { get; set; }

            /// <summary>
            /// <para>The intervention entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>\u8fc7\u513f</para>
            /// </summary>
            [NameInMap("word")]
            [Validation(Required=false)]
            public string Word { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
