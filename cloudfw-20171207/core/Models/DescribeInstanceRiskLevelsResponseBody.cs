// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInstanceRiskLevelsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the instances.</para>
        /// </summary>
        [NameInMap("InstanceRisks")]
        [Validation(Required=false)]
        public List<DescribeInstanceRiskLevelsResponseBodyInstanceRisks> InstanceRisks { get; set; }
        public class DescribeInstanceRiskLevelsResponseBodyInstanceRisks : TeaModel {
            /// <summary>
            /// <para>The risk levels of the Elastic Compute Service (ECS) instance.</para>
            /// </summary>
            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<DescribeInstanceRiskLevelsResponseBodyInstanceRisksDetails> Details { get; set; }
            public class DescribeInstanceRiskLevelsResponseBodyInstanceRisksDetails : TeaModel {
                /// <summary>
                /// <para>The IP addresses of servers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>203.107.XX.XX</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>The risk levels. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>medium</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>medium</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>The type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ResourceNotProtected</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The instance ID of your Cloud Firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vipcloudfw-cn-7mz2fj8nm0u</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The risk levels. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>medium</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>medium</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AABB1B7-C81F-5158-9EF9-B2DD5D3DA014</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
