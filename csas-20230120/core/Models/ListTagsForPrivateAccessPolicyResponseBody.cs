// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListTagsForPrivateAccessPolicyResponseBody : TeaModel {
        [NameInMap("Polices")]
        [Validation(Required=false)]
        public List<ListTagsForPrivateAccessPolicyResponseBodyPolices> Polices { get; set; }
        public class ListTagsForPrivateAccessPolicyResponseBodyPolices : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>pa-policy-1b0d0e8b4bcf****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTagsForPrivateAccessPolicyResponseBodyPolicesTags> Tags { get; set; }
            public class ListTagsForPrivateAccessPolicyResponseBodyPolicesTags : TeaModel {
                /// <summary>
                /// <para>内网访问标签创建时间。</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-02-21 14:10:16</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>tag_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>tag-d3f64e8bdd4a****</para>
                /// </summary>
                [NameInMap("TagId")]
                [Validation(Required=false)]
                public string TagId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Default</para>
                /// </summary>
                [NameInMap("TagType")]
                [Validation(Required=false)]
                public string TagType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9EE61139-A6A8-5E13-80AF-83435C21B26B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
