// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeGatewayResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the private gateway was created. The time is displayed in UTC.</para>
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
        /// <para>The instance type used by the private gateway.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>8c16g</description></item>
        /// <item><description>4c8g</description></item>
        /// <item><description>2c4g</description></item>
        /// <item><description>16c32g</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c6.4xlarge</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The public endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-1uhcqmsc7x22******-1801786532******.cn-hangzhou.pai-eas.aliyuncs.com</para>
        /// </summary>
        [NameInMap("InternetDomain")]
        [Validation(Required=false)]
        public string InternetDomain { get; set; }

        /// <summary>
        /// <para>Indicates whether Internet access is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("InternetEnabled")]
        [Validation(Required=false)]
        public bool? InternetEnabled { get; set; }

        /// <summary>
        /// <para>Indicates whether Internet access is enabled.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Creating: Internet access is being enabled.</description></item>
        /// <item><description>Failed: Internet access failed to be enabled or deleted.</description></item>
        /// <item><description>Running: Internet access is running.</description></item>
        /// <item><description>Deleted: Internet access is deleted.</description></item>
        /// <item><description>Deleting: Internet access is being deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("InternetStatus")]
        [Validation(Required=false)]
        public string InternetStatus { get; set; }

        /// <summary>
        /// <para>The internal endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-1uhcqmsc7x22******-1801786532******-vpc.cn-hangzhou.pai-eas.aliyuncs.com</para>
        /// </summary>
        [NameInMap("IntranetDomain")]
        [Validation(Required=false)]
        public string IntranetDomain { get; set; }

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
        /// <para>The number of nodes in the private gateway.</para>
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
        /// <para>The status of the private gateway.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Creating</description></item>
        /// <item><description>Stopped</description></item>
        /// <item><description>Failed</description></item>
        /// <item><description>Running</description></item>
        /// <item><description>Deleted</description></item>
        /// <item><description>Deleting</description></item>
        /// <item><description>Waiting</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrivateGatewayRunning</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The time when the private gateway was updated. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-02-24T11:52:17Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
