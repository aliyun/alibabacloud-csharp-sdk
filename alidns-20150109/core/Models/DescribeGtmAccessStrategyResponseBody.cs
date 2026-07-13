// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmAccessStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>The switchover policy for the address pool groups:</para>
        /// <list type="bullet">
        /// <item><description><para><b>AUTO</b>: Automatic switchover</para>
        /// </description></item>
        /// <item><description><para><b>DEFAULT</b>: Primary address pool group</para>
        /// </description></item>
        /// <item><description><para><b>FAILOVER</b>: Secondary address pool group</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AUTO</para>
        /// </summary>
        [NameInMap("AccessMode")]
        [Validation(Required=false)]
        public string AccessMode { get; set; }

        /// <summary>
        /// <para>The access status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>DEFAULT</b>: Normal. Access requests are routed to the primary address pool group.</para>
        /// </description></item>
        /// <item><description><para><b>FAILOVER</b>: Abnormal. Access requests are routed to the secondary address pool group.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT</para>
        /// </summary>
        [NameInMap("AccessStatus")]
        [Validation(Required=false)]
        public string AccessStatus { get; set; }

        /// <summary>
        /// <para>The health check status of the primary address pool group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>OPEN</b>: Enabled</para>
        /// </description></item>
        /// <item><description><para><b>CLOSE</b>: Disabled</para>
        /// </description></item>
        /// <item><description><para><b>UNCONFIGURED</b>: Not configured</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OPEN</para>
        /// </summary>
        [NameInMap("DefaultAddrPoolMonitorStatus")]
        [Validation(Required=false)]
        public string DefaultAddrPoolMonitorStatus { get; set; }

        /// <summary>
        /// <para>The name of the primary address pool group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>地址池1</para>
        /// </summary>
        [NameInMap("DefaultAddrPoolName")]
        [Validation(Required=false)]
        public string DefaultAddrPoolName { get; set; }

        /// <summary>
        /// <para>The availability status of the primary address pool group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>AVAILABLE</b>: The address pool group is available.</para>
        /// </description></item>
        /// <item><description><para><b>NOT_AVAILABLE</b>: The address pool group is unavailable.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AVAILABLE</para>
        /// </summary>
        [NameInMap("DefaultAddrPoolStatus")]
        [Validation(Required=false)]
        public string DefaultAddrPoolStatus { get; set; }

        /// <summary>
        /// <para>The ID of the primary address pool group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hra0i1</para>
        /// </summary>
        [NameInMap("DefultAddrPoolId")]
        [Validation(Required=false)]
        public string DefultAddrPoolId { get; set; }

        /// <summary>
        /// <para>The ID of the secondary address pool group. If no secondary address pool group is configured, <b>EMPTY</b> is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hra0i2</para>
        /// </summary>
        [NameInMap("FailoverAddrPoolId")]
        [Validation(Required=false)]
        public string FailoverAddrPoolId { get; set; }

        /// <summary>
        /// <para>The health check status of the secondary address pool group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>OPEN</b>: Enabled</para>
        /// </description></item>
        /// <item><description><para><b>CLOSE</b>: Disabled</para>
        /// </description></item>
        /// <item><description><para><b>UNCONFIGURED</b>: Not configured</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OPEN</para>
        /// </summary>
        [NameInMap("FailoverAddrPoolMonitorStatus")]
        [Validation(Required=false)]
        public string FailoverAddrPoolMonitorStatus { get; set; }

        /// <summary>
        /// <para>The name of the secondary address pool group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>地址池2</para>
        /// </summary>
        [NameInMap("FailoverAddrPoolName")]
        [Validation(Required=false)]
        public string FailoverAddrPoolName { get; set; }

        /// <summary>
        /// <para>The availability status of the secondary address pool group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>AVAILABLE</b>: The address pool group is available.</para>
        /// </description></item>
        /// <item><description><para><b>NOT_AVAILABLE</b>: The address pool group is unavailable.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AVAILABLE</para>
        /// </summary>
        [NameInMap("FailoverAddrPoolStatus")]
        [Validation(Required=false)]
        public string FailoverAddrPoolStatus { get; set; }

        /// <summary>
        /// <para>The ID of the associated Global Traffic Manager (GTM) instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-cn-wwo3a3hbz**</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Lines")]
        [Validation(Required=false)]
        public DescribeGtmAccessStrategyResponseBodyLines Lines { get; set; }
        public class DescribeGtmAccessStrategyResponseBodyLines : TeaModel {
            [NameInMap("Line")]
            [Validation(Required=false)]
            public List<DescribeGtmAccessStrategyResponseBodyLinesLine> Line { get; set; }
            public class DescribeGtmAccessStrategyResponseBodyLinesLine : TeaModel {
                [NameInMap("GroupCode")]
                [Validation(Required=false)]
                public string GroupCode { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("LineCode")]
                [Validation(Required=false)]
                public string LineCode { get; set; }

                [NameInMap("LineName")]
                [Validation(Required=false)]
                public string LineName { get; set; }

            }

        }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BA1608CA-834C-4E63-8682-8AF0B11ED72D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hra0hs</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public string StrategyId { get; set; }

        /// <summary>
        /// <para>The policy mode. SELF_DEFINED indicates a custom policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELF_DEFINED</para>
        /// </summary>
        [NameInMap("StrategyMode")]
        [Validation(Required=false)]
        public string StrategyMode { get; set; }

        /// <summary>
        /// <para>The name of the access policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>全局</para>
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

    }

}
