// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIRegistry20260317.Models
{
    public class ListNamespacesResponseBody : TeaModel {
        /// <summary>
        /// <para>The namespace query result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListNamespacesResponseBodyData Data { get; set; }
        public class ListNamespacesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The returned data entries.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<ListNamespacesResponseBodyDataItems> Items { get; set; }
            public class ListNamespacesResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The time when the namespace was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-11T09:32:03+08:00</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// <para>The description of the namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Default project, auto-created by EMR.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("IpWhitelist")]
                [Validation(Required=false)]
                public string IpWhitelist { get; set; }

                /// <summary>
                /// <para>The namespace name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>magic:magic-cn-1us4sed5d01</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The namespace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>76d4b6e4-31bf-475a-8710-6217ec049c1f</para>
                /// </summary>
                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                /// <summary>
                /// <para>The number of prompts in the namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PromptCount")]
                [Validation(Required=false)]
                public int? PromptCount { get; set; }

                [NameInMap("PublicAccessEnabled")]
                [Validation(Required=false)]
                public bool? PublicAccessEnabled { get; set; }

                [NameInMap("PublicDomain")]
                [Validation(Required=false)]
                public string PublicDomain { get; set; }

                /// <summary>
                /// <para>The number of skills in the namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SkillCount")]
                [Validation(Required=false)]
                public int? SkillCount { get; set; }

                /// <summary>
                /// <para>The source of the namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>magic:magic-cn-fpi4secsq01</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The source index of the namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SourceIndex")]
                [Validation(Required=false)]
                public int? SourceIndex { get; set; }

                /// <summary>
                /// <para>The tags of the namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qa,test</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The page size. Default value: 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9E87E66-9EF0-5C10-A5E6-924020A0C9B7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
