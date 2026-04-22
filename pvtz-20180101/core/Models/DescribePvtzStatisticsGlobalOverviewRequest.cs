// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribePvtzStatisticsGlobalOverviewRequest : TeaModel {
        [NameInMap("NetworkParams")]
        [Validation(Required=false)]
        public List<DescribePvtzStatisticsGlobalOverviewRequestNetworkParams> NetworkParams { get; set; }
        public class DescribePvtzStatisticsGlobalOverviewRequestNetworkParams : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hongkong</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>VPC ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1y5y4wk5810n50cx765</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5924158341670144</para>
            /// </summary>
            [NameInMap("VpcOwner")]
            [Validation(Required=false)]
            public string VpcOwner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>STANDARD</para>
            /// </summary>
            [NameInMap("VpcType")]
            [Validation(Required=false)]
            public string VpcType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DAY, WEEK, MONTH</para>
        /// </summary>
        [NameInMap("OverviewPeriod")]
        [Validation(Required=false)]
        public string OverviewPeriod { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ServerRegion")]
        [Validation(Required=false)]
        public string ServerRegion { get; set; }

    }

}
