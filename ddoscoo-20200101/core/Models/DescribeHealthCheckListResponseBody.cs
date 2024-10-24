// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeHealthCheckListResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of information about the health check configuration.</para>
        /// </summary>
        [NameInMap("HealthCheckList")]
        [Validation(Required=false)]
        public List<DescribeHealthCheckListResponseBodyHealthCheckList> HealthCheckList { get; set; }
        public class DescribeHealthCheckListResponseBodyHealthCheckList : TeaModel {
            /// <summary>
            /// <para>The forwarding port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("FrontendPort")]
            [Validation(Required=false)]
            public int? FrontendPort { get; set; }

            /// <summary>
            /// <para>The health check configuration.</para>
            /// </summary>
            [NameInMap("HealthCheck")]
            [Validation(Required=false)]
            public DescribeHealthCheckListResponseBodyHealthCheckListHealthCheck HealthCheck { get; set; }
            public class DescribeHealthCheckListResponseBodyHealthCheckListHealthCheck : TeaModel {
                /// <summary>
                /// <para>The domain name.</para>
                /// <remarks>
                /// <para> This parameter is returned only when the Layer 7 health check configuration is queried.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The number of consecutive failed health checks that must occur before a port is declared unhealthy. Valid values: <b>1</b> to <b>10</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Down")]
                [Validation(Required=false)]
                public int? Down { get; set; }

                /// <summary>
                /// <para>The interval at which checks are performed. Valid values: <b>1</b> to <b>30</b>. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// <para>The port that was checked.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The response timeout period. Valid values: <b>1</b> to <b>30</b>. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <para>The type of the protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>tcp</b>: The Layer 4 health check configuration was queried.</description></item>
                /// <item><description><b>http</b>: The Layer 7 health check configuration was queried.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>tcp</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The number of consecutive successful health checks that must occur before a port is declared healthy. Valid values: <b>1</b> to <b>10</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Up")]
                [Validation(Required=false)]
                public int? Up { get; set; }

                /// <summary>
                /// <para>The check path.</para>
                /// <remarks>
                /// <para> This parameter is returned only when the Layer 7 health check configuration is queried.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>/abc</para>
                /// </summary>
                [NameInMap("Uri")]
                [Validation(Required=false)]
                public string Uri { get; set; }

            }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddoscoo-cn-mp91j1ao****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The forwarding protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>tcp</b></description></item>
            /// <item><description><b>udp</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83B4AF42-E8EE-4DC9-BD73-87B7733A36F9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
