// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateSupabaseProjectRequest : TeaModel {
        /// <summary>
        /// <para>The initial account password.</para>
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
        /// <para>Specifies whether to enable auto-start and auto-stop. If you do not specify this parameter, the default value is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoScale")]
        [Validation(Required=false)]
        public bool? AutoScale { get; set; }

        /// <summary>
        /// <para>The backup set ID.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/3064623.html">ListSupabaseDataBackups</a> to view the IDs of all backup sets under the target Supabase project.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2176307784</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The client token. It is used to ensure idempotence and prevent duplicate requests from executing the same operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The optional creation parameters. The default value is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("CreateOptions")]
        [Validation(Required=false)]
        public string CreateOptions { get; set; }

        /// <summary>
        /// <para>The performance level of the cloud disk. If you do not specify this parameter, the default value is PL0.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL0</description></item>
        /// <item><description>PL1</description></item>
        /// <item><description>PL2</description></item>
        /// <item><description>PL3</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PL0</para>
        /// </summary>
        [NameInMap("DiskPerformanceLevel")]
        [Validation(Required=false)]
        public string DiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The DPI engine version. If you do not specify this parameter, the default value is PG15. PostgreSQL 17 and later versions support the data sandbox (branch) feature.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PG15: PostgreSQL 15.</description></item>
        /// <item><description>PG17: PostgreSQL 17, which supports the data sandbox feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PG15</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether the project is the lightweight edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Lightweight")]
        [Validation(Required=false)]
        public bool? Lightweight { get; set; }

        /// <summary>
        /// <para>The billing method. If you do not specify this parameter, the default value is Free.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Free: the free billing method.</description></item>
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
        /// <para>The unit of the subscription duration. This parameter takes effect only when PayType is set to Prepaid. If you do not specify this parameter, the default value is Month.</para>
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
        /// <item><description>The name can contain only letters, digits, hyphens (-), and underscores (_).</description></item>
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
        /// <para>The specifications of the Supabase project. The free billing method uses the free specifications. For paid billing methods, the specifications must be consistent with those available in the console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2C4G</para>
        /// </summary>
        [NameInMap("ProjectSpec")]
        [Validation(Required=false)]
        public string ProjectSpec { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IP address whitelist. Separate multiple IP addresses or CIDR blocks with commas (,). If you do not specify this parameter, the default value 0.0.0.0/0 is used.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0/0</para>
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        /// <summary>
        /// <para>The ID of the Supabase project to which the backup set belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spb-xxxxxxxx</para>
        /// </summary>
        [NameInMap("SrcProjectId")]
        [Validation(Required=false)]
        public string SrcProjectId { get; set; }

        /// <summary>
        /// <para>The storage capacity. Unit: GB. If you do not specify this parameter for a non-free billing method, the default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public long? StorageSize { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateSupabaseProjectRequestTags> Tags { get; set; }
        public class CreateSupabaseProjectRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key. Limits:</para>
            /// <list type="bullet">
            /// <item><description>It cannot be an empty string.</description></item>
            /// <item><description>It can be up to 128 characters in length.</description></item>
            /// <item><description>It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>test-key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The value can be an empty string. It can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The subscription duration of the resource. This parameter takes effect only when PayType is set to Prepaid. If you do not specify this parameter, the default value is 1.</para>
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
