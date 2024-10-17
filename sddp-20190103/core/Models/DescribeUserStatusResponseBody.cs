// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeUserStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>769FB3C1-F4C9-42DF-9B72-7077A8989C13</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the current account.</para>
        /// </summary>
        [NameInMap("UserStatus")]
        [Validation(Required=false)]
        public DescribeUserStatusResponseBodyUserStatus UserStatus { get; set; }
        public class DescribeUserStatusResponseBodyUserStatus : TeaModel {
            /// <summary>
            /// <para>The AccessKey ID of the current account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LTAI4G67HRBzNRmMhfyv****</para>
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// <para>Indicates whether the SQL Explorer feature can be disabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AuditClosable")]
            [Validation(Required=false)]
            public bool? AuditClosable { get; set; }

            /// <summary>
            /// <para>Indicates whether the audit resources can be released.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AuditReleasable")]
            [Validation(Required=false)]
            public bool? AuditReleasable { get; set; }

            /// <summary>
            /// <para>Indicates whether DSC has permission to access user resources within the current account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Authed")]
            [Validation(Required=false)]
            public bool? Authed { get; set; }

            /// <summary>
            /// <para>The billing method of DCS that is purchased by using the current account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PREPAY</b>: subscription</description></item>
            /// <item><description><b>POSTPAY</b>: pay-as-you-go</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PREPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The permissions that the current account has. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The current account has the administrative permissions or read-only permissions on Data Security Center.</description></item>
            /// <item><description><b>1</b>: The current account has the permissions to manage data domains.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DataManagerRole")]
            [Validation(Required=false)]
            public int? DataManagerRole { get; set; }

            /// <summary>
            /// <para>The ID of the data security center instance purchased by the main account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sddp-cn-****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The number of instances within the current account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("InstanceNum")]
            [Validation(Required=false)]
            public int? InstanceNum { get; set; }

            /// <summary>
            /// <para>The total number of instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("InstanceTotalCount")]
            [Validation(Required=false)]
            public long? InstanceTotalCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the data security lab feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: yes</description></item>
            /// <item><description><b>0</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LabStatus")]
            [Validation(Required=false)]
            public int? LabStatus { get; set; }

            /// <summary>
            /// <para>OSS total storage capacity. Unit: Bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2048</para>
            /// </summary>
            [NameInMap("OssTotalSize")]
            [Validation(Required=false)]
            public long? OssTotalSize { get; set; }

            /// <summary>
            /// <para>Accumulate the number of days to protect user assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ProtectionDays")]
            [Validation(Required=false)]
            public int? ProtectionDays { get; set; }

            /// <summary>
            /// <para>Indicates whether DSC is purchased. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Purchased")]
            [Validation(Required=false)]
            public bool? Purchased { get; set; }

            /// <summary>
            /// <para>The grace period between when DSC is expired and when DSC is released. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("ReleaseDays")]
            [Validation(Required=false)]
            public int? ReleaseDays { get; set; }

            /// <summary>
            /// <para>The time when the audit resources are released. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15000</para>
            /// </summary>
            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }

            /// <summary>
            /// <para>The remaining period for which the data assets within the current account can be protected by DSC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131</para>
            /// </summary>
            [NameInMap("RemainDays")]
            [Validation(Required=false)]
            public int? RemainDays { get; set; }

            /// <summary>
            /// <para>Indicates whether the current account uses a free trial of DSC. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Trail")]
            [Validation(Required=false)]
            public bool? Trail { get; set; }

            /// <summary>
            /// <para>Indicates whether the agent audit feature is used. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: yes</description></item>
            /// <item><description><b>0</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UseAgentAudit")]
            [Validation(Required=false)]
            public bool? UseAgentAudit { get; set; }

            /// <summary>
            /// <para>The number of instances that are used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>125</para>
            /// </summary>
            [NameInMap("UseInstanceNum")]
            [Validation(Required=false)]
            public int? UseInstanceNum { get; set; }

            /// <summary>
            /// <para>The occupied space of the Object Storage Service (OSS) bucket. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>234</para>
            /// </summary>
            [NameInMap("UseOssSize")]
            [Validation(Required=false)]
            public long? UseOssSize { get; set; }

        }

    }

}
