// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeIpLocationServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the asset.</para>
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public DescribeIpLocationServiceResponseBodyInstance Instance { get; set; }
        public class DescribeIpLocationServiceResponseBodyInstance : TeaModel {
            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1cb6x80tfgocid****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>launch-advisor-2021****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The type of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ecs</b>: an ECS instance.</description></item>
            /// <item><description><b>slb</b>: an SLB instance.</description></item>
            /// <item><description><b>eip</b>: an EIP.</description></item>
            /// <item><description><b>ipv6</b>: an IPv6 gateway.</description></item>
            /// <item><description><b>swas</b>: a simple application server.</description></item>
            /// <item><description><b>waf</b>: a Web Application Firewall (WAF) instance of the Exclusive edition.</description></item>
            /// <item><description><b>ga_basic</b>: a Global Accelerator (GA) instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The IP address of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>121.199.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The region to which the public IP address of the asset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C728D7E9-9A39-52E0-966B-5C33118BDBB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
