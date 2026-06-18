// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateSupabaseProjectRequest : TeaModel {
        /// <summary>
        /// <para>The password of the initial account.</para>
        /// <para>Password rules:</para>
        /// <list type="bullet">
        /// <item><description>The password must be 8 to 32 characters in length.</description></item>
        /// <item><description>The password must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</description></item>
        /// <item><description>Supported special characters include !@#$%^&amp;*()_+-=.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestPassword123!</para>
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto start/stop. If this parameter is not specified, the default value is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoScale")]
        [Validation(Required=false)]
        public bool? AutoScale { get; set; }

        /// <summary>
        /// <para>The idempotency token. This token ensures that duplicate requests do not trigger the same operation more than once.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The performance level (PL) of the cloud disk. If this parameter is not specified, the default value PL0 is used.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL0</description></item>
        /// <item><description>PL1</description></item>
        /// <item><description>PL2</description></item>
        /// <item><description>PL3.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PL0</para>
        /// </summary>
        [NameInMap("DiskPerformanceLevel")]
        [Validation(Required=false)]
        public string DiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The DPI engine version. If this parameter is not specified, the default value PG15 is used.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PG15: PostgreSQL 15.</description></item>
        /// <item><description>PG17: PostgreSQL 17.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PG15</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The billing method. If this parameter is not specified, the default value Free is used.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Free: free tier.</description></item>
        /// <item><description>Postpaid: pay-as-you-go.</description></item>
        /// <item><description>Prepaid: subscription.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Free</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration. This parameter takes effect only when PayType is set to PrePay. If this parameter is not specified, the default value Month is used.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month: month.</description></item>
        /// <item><description>Year: year.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The name of the Supabase project.</para>
        /// <para>Naming rules:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 1 to 128 characters in length.</description></item>
        /// <item><description>The name can contain letters, digits, hyphens (-), and underscores (_).</description></item>
        /// <item><description>The name must start with a letter or an underscore (_).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>supabase_demo</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The specifications of the Supabase project. The Free billing type uses free-tier specifications. For paid billing types, the specifications must match those available on the console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2C4G</para>
        /// </summary>
        [NameInMap("ProjectSpec")]
        [Validation(Required=false)]
        public string ProjectSpec { get; set; }

        /// <summary>
        /// <para>The region ID. Specifies the region in which to create the project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IP address whitelist. Separate multiple IP addresses or CIDR blocks with commas (,). If this parameter is not specified, the default value 0.0.0.0/0 is used.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0/0</para>
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        /// <summary>
        /// <para>The storage size. Unit: GB. If this parameter is not specified for non-Free billing types, the default value is 1 GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public long? StorageSize { get; set; }

        /// <summary>
        /// <para>The subscription duration of the resource. This parameter takes effect only when PayType is set to PrePay. If this parameter is not specified, the default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The vSwitch ID. This parameter is required. The zone of the vSwitch must be the same as the value of ZoneId.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1234567890</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC). This parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1234567890</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID. The zone of the vSwitch specified by VSwitchId must be the same as the value of this parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
