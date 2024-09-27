// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmAccessStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>The access policy.</para>
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
        /// <item><description><b>DEFAULT</b>: Indicates normal when the default address pool is accessed.</description></item>
        /// <item><description><b>FAILOVER</b>: Indicates an exception when a failover address pool is accessed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT</para>
        /// </summary>
        [NameInMap("AccessStatus")]
        [Validation(Required=false)]
        public string AccessStatus { get; set; }

        /// <summary>
        /// <para>Indicates whether health check is enabled for the default address pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OPEN</para>
        /// </summary>
        [NameInMap("DefaultAddrPoolMonitorStatus")]
        [Validation(Required=false)]
        public string DefaultAddrPoolMonitorStatus { get; set; }

        /// <summary>
        /// <para>The name of the default address pool.</para>
        /// </summary>
        [NameInMap("DefaultAddrPoolName")]
        [Validation(Required=false)]
        public string DefaultAddrPoolName { get; set; }

        /// <summary>
        /// <para>The availability status of the default address pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AVAILABLE</para>
        /// </summary>
        [NameInMap("DefaultAddrPoolStatus")]
        [Validation(Required=false)]
        public string DefaultAddrPoolStatus { get; set; }

        /// <summary>
        /// <para>The ID of the default address pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hra0i1</para>
        /// </summary>
        [NameInMap("DefultAddrPoolId")]
        [Validation(Required=false)]
        public string DefultAddrPoolId { get; set; }

        /// <summary>
        /// <para>The ID of the failover address pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hra0i2</para>
        /// </summary>
        [NameInMap("FailoverAddrPoolId")]
        [Validation(Required=false)]
        public string FailoverAddrPoolId { get; set; }

        /// <summary>
        /// <para>Indicates whether health check is enabled for the failover address pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OPEN</para>
        /// </summary>
        [NameInMap("FailoverAddrPoolMonitorStatus")]
        [Validation(Required=false)]
        public string FailoverAddrPoolMonitorStatus { get; set; }

        /// <summary>
        /// <para>The name of the failover address pool.</para>
        /// </summary>
        [NameInMap("FailoverAddrPoolName")]
        [Validation(Required=false)]
        public string FailoverAddrPoolName { get; set; }

        /// <summary>
        /// <para>The availability status of the failover address pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AVAILABLE</para>
        /// </summary>
        [NameInMap("FailoverAddrPoolStatus")]
        [Validation(Required=false)]
        public string FailoverAddrPoolStatus { get; set; }

        /// <summary>
        /// <para>The ID of the GTM instance whose access policy details you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The returned lines of access regions.</para>
        /// </summary>
        [NameInMap("Lines")]
        [Validation(Required=false)]
        public DescribeGtmAccessStrategyResponseBodyLines Lines { get; set; }
        public class DescribeGtmAccessStrategyResponseBodyLines : TeaModel {
            [NameInMap("Line")]
            [Validation(Required=false)]
            public List<DescribeGtmAccessStrategyResponseBodyLinesLine> Line { get; set; }
            public class DescribeGtmAccessStrategyResponseBodyLinesLine : TeaModel {
                /// <summary>
                /// <para>The code of the access region group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEFAULT</para>
                /// </summary>
                [NameInMap("GroupCode")]
                [Validation(Required=false)]
                public string GroupCode { get; set; }

                /// <summary>
                /// <para>The name of the access region group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Global</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The code for the line of the access region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("LineCode")]
                [Validation(Required=false)]
                public string LineCode { get; set; }

                /// <summary>
                /// <para>The name for the line of the access region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Global</para>
                /// </summary>
                [NameInMap("LineName")]
                [Validation(Required=false)]
                public string LineName { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BA1608CA-834C-4E63-8682-8AF0B11ED72D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the access policy queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hra0hs</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public string StrategyId { get; set; }

        /// <summary>
        /// <para>The mode of traffic scheduling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELF_DEFINED</para>
        /// </summary>
        [NameInMap("StrategyMode")]
        [Validation(Required=false)]
        public string StrategyMode { get; set; }

        /// <summary>
        /// <para>The name of the access policy queried.</para>
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

    }

}
