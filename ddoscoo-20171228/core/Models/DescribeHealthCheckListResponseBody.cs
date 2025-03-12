// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeHealthCheckListResponseBody : TeaModel {
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public List<DescribeHealthCheckListResponseBodyListeners> Listeners { get; set; }
        public class DescribeHealthCheckListResponseBodyListeners : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>233</para>
            /// </summary>
            [NameInMap("FrontendPort")]
            [Validation(Required=false)]
            public int? FrontendPort { get; set; }

            [NameInMap("HealthCheck")]
            [Validation(Required=false)]
            public DescribeHealthCheckListResponseBodyListenersHealthCheck HealthCheck { get; set; }
            public class DescribeHealthCheckListResponseBodyListenersHealthCheck : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("Down")]
                [Validation(Required=false)]
                public int? Down { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>233</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>tcp</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Up")]
                [Validation(Required=false)]
                public int? Up { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/a/b/c</para>
                /// </summary>
                [NameInMap("Uri")]
                [Validation(Required=false)]
                public string Uri { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ddoscoo-cn-XXXXX</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
