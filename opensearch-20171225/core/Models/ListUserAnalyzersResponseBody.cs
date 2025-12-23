// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListUserAnalyzersResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A6EB64B-B4C8-CF02-810F-E660812972FF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The custom analyzer.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/178934.html">UserAnalyzer</a>.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListUserAnalyzersResponseBodyResult> Result { get; set; }
        public class ListUserAnalyzersResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether the application is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("available")]
            [Validation(Required=false)]
            public bool? Available { get; set; }

            /// <summary>
            /// <para>The basic analyzer. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>chn_standard: <a href="https://help.aliyun.com/document_detail/179424.html">a common analyzer in Chinese</a></description></item>
            /// <item><description>chn_scene_name: an analyzer for person names in Chinese</description></item>
            /// <item><description>chn_ecommerce: <a href="https://help.aliyun.com/document_detail/179424.html">an analyzer for E-commerce in Chinese</a></description></item>
            /// <item><description>chn_it_content: <a href="https://help.aliyun.com/document_detail/179424.html">an analyzer for IT content in Chinese</a></description></item>
            /// <item><description>en_min: a small-granularity analyzer in English</description></item>
            /// <item><description>th_standard: a common analyzer in Thai</description></item>
            /// <item><description>th_ecommerce: an analyzer for E-commerce in Thai</description></item>
            /// <item><description>vn_standard: a common analyzer in Vietnamese</description></item>
            /// <item><description>chn_community_it: an analyzer for IT community content in Chinese</description></item>
            /// <item><description>chn_ecommerce_general: a common analyzer for the E-commerce industry in Chinese</description></item>
            /// <item><description>chn_esports_general: a common analyzer for the gaming industry in Chinese</description></item>
            /// <item><description>chn_edu_question: an analyzer for question search of the education industry in Chinese</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>chn_standard</para>
            /// </summary>
            [NameInMap("business")]
            [Validation(Required=false)]
            public string Business { get; set; }

            /// <summary>
            /// <para>The timestamp when the application was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1588054131</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            /// <summary>
            /// <para>The dictionaries that are used by the custom analyzer.</para>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/178933.html">UserDict</a>.</para>
            /// </summary>
            [NameInMap("dicts")]
            [Validation(Required=false)]
            public List<ListUserAnalyzersResponseBodyResultDicts> Dicts { get; set; }
            public class ListUserAnalyzersResponseBodyResultDicts : TeaModel {
                /// <summary>
                /// <para>Indicates whether the application is available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("available")]
                [Validation(Required=false)]
                public bool? Available { get; set; }

                /// <summary>
                /// <para>The timestamp when the application was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1588054131</para>
                /// </summary>
                [NameInMap("created")]
                [Validation(Required=false)]
                public int? Created { get; set; }

                /// <summary>
                /// <para>The number of intervention entries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("entriesCount")]
                [Validation(Required=false)]
                public int? EntriesCount { get; set; }

                /// <summary>
                /// <para>The maximum number of intervention entries that can be created in the dictionary.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("entriesLimit")]
                [Validation(Required=false)]
                public int? EntriesLimit { get; set; }

                /// <summary>
                /// <para>The ID of the dictionary.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The type. Valid value:</para>
                /// <list type="bullet">
                /// <item><description>segment</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>segment</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The timestamp when the application was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1588054131</para>
                /// </summary>
                [NameInMap("updated")]
                [Validation(Required=false)]
                public int? Updated { get; set; }

            }

            /// <summary>
            /// <para>The ID of the custom analyzer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the custom analyzer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kevin_test2</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The timestamp when the application was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1588054131</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

        }

        /// <summary>
        /// <para>The total number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
