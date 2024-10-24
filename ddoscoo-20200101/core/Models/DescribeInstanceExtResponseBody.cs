// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeInstanceExtResponseBody : TeaModel {
        /// <summary>
        /// <para>The extended information about the Anti-DDoS Proxy instance.</para>
        /// </summary>
        [NameInMap("InstanceExtSpecs")]
        [Validation(Required=false)]
        public List<DescribeInstanceExtResponseBodyInstanceExtSpecs> InstanceExtSpecs { get; set; }
        public class DescribeInstanceExtResponseBodyInstanceExtSpecs : TeaModel {
            /// <summary>
            /// <para>The function plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Standard</description></item>
            /// <item><description><b>1</b>: Enhanced</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FunctionVersion")]
            [Validation(Required=false)]
            public long? FunctionVersion { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddoscoo-cn-i7m25564****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The clean bandwidth. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("NormalBandwidth")]
            [Validation(Required=false)]
            public long? NormalBandwidth { get; set; }

            /// <summary>
            /// <para>The type of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the Insurance mitigation plan</description></item>
            /// <item><description><b>1</b>: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the Unlimited mitigation plan</description></item>
            /// <item><description><b>2</b>: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the Chinese Mainland Acceleration (CMA) mitigation plan</description></item>
            /// <item><description><b>3</b>: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the Secure Chinese Mainland Acceleration (Sec-CMA) mitigation plan</description></item>
            /// <item><description><b>9</b>: Anti-DDoS Proxy (Chinese Mainland) instance of the Profession mitigation plan</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ProductPlan")]
            [Validation(Required=false)]
            public long? ProductPlan { get; set; }

            /// <summary>
            /// <para>The Internet service provider (ISP) line of the Anti-DDoS Proxy (Chinese Mainland) instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>coop-line-001</para>
            /// </summary>
            [NameInMap("ServicePartner")]
            [Validation(Required=false)]
            public string ServicePartner { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of queried instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
