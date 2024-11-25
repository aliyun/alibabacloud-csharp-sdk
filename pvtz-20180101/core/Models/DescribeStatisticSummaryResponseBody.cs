// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeStatisticSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A73F3BD0-B1A8-42A9-A9B6-689BBABC4891</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2254</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The top three VPCs with the largest number of DNS requests.</para>
        /// </summary>
        [NameInMap("VpcRequestTops")]
        [Validation(Required=false)]
        public DescribeStatisticSummaryResponseBodyVpcRequestTops VpcRequestTops { get; set; }
        public class DescribeStatisticSummaryResponseBodyVpcRequestTops : TeaModel {
            [NameInMap("VpcRequestTop")]
            [Validation(Required=false)]
            public List<DescribeStatisticSummaryResponseBodyVpcRequestTopsVpcRequestTop> VpcRequestTop { get; set; }
            public class DescribeStatisticSummaryResponseBodyVpcRequestTopsVpcRequestTop : TeaModel {
                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The name of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>华北 2</para>
                /// </summary>
                [NameInMap("RegionName")]
                [Validation(Required=false)]
                public string RegionName { get; set; }

                /// <summary>
                /// <para>The number of DNS requests on the previous day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2254</para>
                /// </summary>
                [NameInMap("RequestCount")]
                [Validation(Required=false)]
                public long? RequestCount { get; set; }

                /// <summary>
                /// <para>The tunnel ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tun-7h33lkqfuhgnyy****</para>
                /// </summary>
                [NameInMap("TunnelId")]
                [Validation(Required=false)]
                public string TunnelId { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-f8zvrvr1payllgz38****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The VPC type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>STANDARD: standard VPC</description></item>
                /// <item><description>EDS: Elastic Desktop Service (EDS) workspace VPC</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>STANDARD</para>
                /// </summary>
                [NameInMap("VpcType")]
                [Validation(Required=false)]
                public string VpcType { get; set; }

            }

        }

        /// <summary>
        /// <para>The top three zones with the largest number of DNS requests.</para>
        /// </summary>
        [NameInMap("ZoneRequestTops")]
        [Validation(Required=false)]
        public DescribeStatisticSummaryResponseBodyZoneRequestTops ZoneRequestTops { get; set; }
        public class DescribeStatisticSummaryResponseBodyZoneRequestTops : TeaModel {
            [NameInMap("ZoneRequestTop")]
            [Validation(Required=false)]
            public List<DescribeStatisticSummaryResponseBodyZoneRequestTopsZoneRequestTop> ZoneRequestTop { get; set; }
            public class DescribeStatisticSummaryResponseBodyZoneRequestTopsZoneRequestTop : TeaModel {
                /// <summary>
                /// <para>The business type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AUTH_ZONE: authoritative zone</description></item>
                /// <item><description>RESOLVER_RULE: forwarding rule</description></item>
                /// <item><description>INBOUND: inbound endpoint</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AUTH_ZONE</para>
                /// </summary>
                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// <para>The number of DNS requests on the previous day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2251</para>
                /// </summary>
                [NameInMap("RequestCount")]
                [Validation(Required=false)]
                public long? RequestCount { get; set; }

                /// <summary>
                /// <para>The zone name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.com</para>
                /// </summary>
                [NameInMap("ZoneName")]
                [Validation(Required=false)]
                public string ZoneName { get; set; }

            }

        }

    }

}
