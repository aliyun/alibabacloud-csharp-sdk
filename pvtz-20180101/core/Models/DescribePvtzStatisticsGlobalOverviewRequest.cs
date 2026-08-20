// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribePvtzStatisticsGlobalOverviewRequest : TeaModel {
        /// <summary>
        /// <para>The network parameters.</para>
        /// </summary>
        [NameInMap("NetworkParams")]
        [Validation(Required=false)]
        public List<DescribePvtzStatisticsGlobalOverviewRequestNetworkParams> NetworkParams { get; set; }
        public class DescribePvtzStatisticsGlobalOverviewRequestNetworkParams : TeaModel {
            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hongkong</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1y5y4wk5810n50cx765</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the VPC belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5924158341670144</para>
            /// </summary>
            [NameInMap("VpcOwner")]
            [Validation(Required=false)]
            public string VpcOwner { get; set; }

            /// <summary>
            /// <para>The type of the VPC. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>STANDARD</b>: standard VPC</para>
            /// </description></item>
            /// <item><description><para><b>EDS</b>: Elastic Desktop Service (EDS) VPC</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>STANDARD</para>
            /// </summary>
            [NameInMap("VpcType")]
            [Validation(Required=false)]
            public string VpcType { get; set; }

        }

        /// <summary>
        /// <para>The statistical period. Valid values: <c>DAY</c>, <c>WEEK</c>, and <c>MONTH</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DAY, WEEK, MONTH</para>
        /// </summary>
        [NameInMap("OverviewPeriod")]
        [Validation(Required=false)]
        public string OverviewPeriod { get; set; }

        /// <summary>
        /// <para>The region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ServerRegion")]
        [Validation(Required=false)]
        public string ServerRegion { get; set; }

    }

}
