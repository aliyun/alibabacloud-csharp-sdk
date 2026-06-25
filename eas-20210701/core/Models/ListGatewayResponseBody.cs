// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListGatewayResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of private gateways.</para>
        /// </summary>
        [NameInMap("Gateways")]
        [Validation(Required=false)]
        public List<ListGatewayResponseBodyGateways> Gateways { get; set; }
        public class ListGatewayResponseBodyGateways : TeaModel {
            /// <summary>
            /// <para>The billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>PrePaid: Subscription.</para>
            /// </description></item>
            /// <item><description><para>PostPaid: Pay-as-you-go.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The time when the private gateway was created. The time is in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-05-19T14:19:42Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

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
            /// <para>The instance type used by the private gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2c4g</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The public network endpoint.</para>
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
            /// <para>The internal network endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-1uhcqmsc7x22******-1801786532******-vpc.cn-wulanchabu.pai-eas.aliyuncs.com</para>
            /// </summary>
            [NameInMap("IntranetDomain")]
            [Validation(Required=false)]
            public string IntranetDomain { get; set; }

            /// <summary>
            /// <para>Indicates whether internal network access is enabled.</para>
            /// </summary>
            [NameInMap("IntranetEnabled")]
            [Validation(Required=false)]
            public bool? IntranetEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether it is the default private gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The list of gateway tags.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<ListGatewayResponseBodyGatewaysLabels> Labels { get; set; }
            public class ListGatewayResponseBodyGatewaysLabels : TeaModel {
                /// <summary>
                /// <para>The key of the gateway tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("LabelKey")]
                [Validation(Required=false)]
                public string LabelKey { get; set; }

                /// <summary>
                /// <para>The value of the gateway tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("LabelValue")]
                [Validation(Required=false)]
                public string LabelValue { get; set; }

            }

            /// <summary>
            /// <para>The number of nodes for the private gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Replicas")]
            [Validation(Required=false)]
            public int? Replicas { get; set; }

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

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>The total number of gateways.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
