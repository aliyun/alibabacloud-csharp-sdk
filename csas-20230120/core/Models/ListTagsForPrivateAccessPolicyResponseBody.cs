// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListTagsForPrivateAccessPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>List of internal network access policies.</para>
        /// </summary>
        [NameInMap("Polices")]
        [Validation(Required=false)]
        public List<ListTagsForPrivateAccessPolicyResponseBodyPolices> Polices { get; set; }
        public class ListTagsForPrivateAccessPolicyResponseBodyPolices : TeaModel {
            /// <summary>
            /// <para>ID of the internal network access policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pa-policy-1b0d0e8b4bcf****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>Tags for the internal network access policy.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTagsForPrivateAccessPolicyResponseBodyPolicesTags> Tags { get; set; }
            public class ListTagsForPrivateAccessPolicyResponseBodyPolicesTags : TeaModel {
                /// <summary>
                /// <para>Time when the tag was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-02-21 14:10:16</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Description of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>这是一条被内网访问策略引用的标签</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Name of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>ID of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag-d3f64e8bdd4a****</para>
                /// </summary>
                [NameInMap("TagId")]
                [Validation(Required=false)]
                public string TagId { get; set; }

                /// <summary>
                /// <para>Type of the tag. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Default</b>: Default tag.</para>
                /// </description></item>
                /// <item><description><para><b>Custom</b>: Custom tag.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Default</para>
                /// </summary>
                [NameInMap("TagType")]
                [Validation(Required=false)]
                public string TagType { get; set; }

            }

        }

        /// <summary>
        /// <para>ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9EE61139-A6A8-5E13-80AF-83435C21B26B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
