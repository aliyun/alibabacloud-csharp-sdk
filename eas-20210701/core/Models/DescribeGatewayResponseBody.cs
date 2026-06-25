// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeGatewayResponseBody : TeaModel {
        /// <summary>
        /// <para>The billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The time when the private gateway was created. The time is in Coordinated Universal Time (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-05-19T14:19:42Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The ID of the self-managed cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c935eadf284c14c2da57a2a13ad6******</para>
        /// </summary>
        [NameInMap("ExternalClusterId")]
        [Validation(Required=false)]
        public string ExternalClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the private gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-1uhcqmsc7x22******</para>
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The alias of the private gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mygateway1</para>
        /// </summary>
        [NameInMap("GatewayName")]
        [Validation(Required=false)]
        public string GatewayName { get; set; }

        /// <summary>
        /// <para>The instance type of the private gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2c4g</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The public endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-1uhcqmsc7x22******-1801786532******.cn-wulanchabu.pai-eas.aliyuncs.com</para>
        /// </summary>
        [NameInMap("InternetDomain")]
        [Validation(Required=false)]
        public string InternetDomain { get; set; }

        /// <summary>
        /// <para>Indicates whether public network access is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("InternetEnabled")]
        [Validation(Required=false)]
        public bool? InternetEnabled { get; set; }

        /// <summary>
        /// <para>The status of public network access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("InternetStatus")]
        [Validation(Required=false)]
        public string InternetStatus { get; set; }

        /// <summary>
        /// <para>The private endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-1uhcqmsc7x22******-1801786532******-vpc.cn-wulanchabu.pai-eas.aliyuncs.com</para>
        /// </summary>
        [NameInMap("IntranetDomain")]
        [Validation(Required=false)]
        public string IntranetDomain { get; set; }

        [NameInMap("IntranetEnabled")]
        [Validation(Required=false)]
        public bool? IntranetEnabled { get; set; }

        /// <summary>
        /// <para>Indicates whether the gateway is the default private gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<DescribeGatewayResponseBodyLabels> Labels { get; set; }
        public class DescribeGatewayResponseBodyLabels : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("LabelKey")]
            [Validation(Required=false)]
            public string LabelKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>value1</para>
            /// </summary>
            [NameInMap("LabelValue")]
            [Validation(Required=false)]
            public string LabelValue { get; set; }

        }

        /// <summary>
        /// <para>The number of private gateway nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether HTTP to HTTPS redirection is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SSLRedirectionEnabled")]
        [Validation(Required=false)]
        public bool? SSLRedirectionEnabled { get; set; }

        /// <summary>
        /// <para>The status of the private gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The time when the private gateway was last updated. The time is in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-02-24T11:52:17Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
