// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeVscsResponseBody : TeaModel {
        /// <summary>
        /// <para>The query token. The value is the NextToken value returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-**-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>VSC</para>
        /// </summary>
        [NameInMap("Vscs")]
        [Validation(Required=false)]
        public List<DescribeVscsResponseBodyVscs> Vscs { get; set; }
        public class DescribeVscsResponseBodyVscs : TeaModel {
            /// <summary>
            /// <para>The description of the port list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ali***-post-cn-j4g45iqze00f</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-uf69***21l8zuoizdq</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The resource group ID. When you use this parameter to filter resources, the resource count cannot exceed 1,000.</para>
            /// <remarks>
            /// <para>Filtering by the default resource group is not supported.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek2zex4ehdyjvq</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The status of the VSC. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>In_use: In use.</description></item>
            /// <item><description>Attaching: Attaching.</description></item>
            /// <item><description>Detaching: Detaching.</description></item>
            /// <item><description>AttachFailed: Attachment failed.</description></item>
            /// <item><description>DetachFailed: Detachment failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>In_use</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tag keys of the snapshots in the snapshot consistency group. The default values of Key and Value provide the snapshot source information.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeVscsResponseBodyVscsTags> Tags { get; set; }
            public class DescribeVscsResponseBodyVscsTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the key pair.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The VSC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsc-hp34ue**g0wmycb27bwal</para>
            /// </summary>
            [NameInMap("VscId")]
            [Validation(Required=false)]
            public string VscId { get; set; }

            /// <summary>
            /// <para>The custom name of the VSC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-vsc</para>
            /// </summary>
            [NameInMap("VscName")]
            [Validation(Required=false)]
            public string VscName { get; set; }

            /// <summary>
            /// <para>The type of the VSC. Valid values: Primary and Secondary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Primary</para>
            /// </summary>
            [NameInMap("VscType")]
            [Validation(Required=false)]
            public string VscType { get; set; }

        }

    }

}
