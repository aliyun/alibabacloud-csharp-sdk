// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeUserStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>769FB3C1-F4C9-42DF-9B72-7077A8989C13</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the current logon account.</para>
        /// </summary>
        [NameInMap("UserStatus")]
        [Validation(Required=false)]
        public DescribeUserStatusResponseBodyUserStatus UserStatus { get; set; }
        public class DescribeUserStatusResponseBodyUserStatus : TeaModel {
            /// <summary>
            /// <para>The AccessKey ID authorized by the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourAccessKeyID</para>
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// <para>Indicates whether the current logon account has authorized the service-linked role for DSC asset synchronization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: authorized.</description></item>
            /// <item><description><b>false</b>: not authorized.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AssetRoleAuthed")]
            [Validation(Required=false)]
            public bool? AssetRoleAuthed { get; set; }

            /// <summary>
            /// <para>Indicates whether SQL Explorer can be disabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: can be disabled.</description></item>
            /// <item><description><b>false</b>: cannot be disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AuditClosable")]
            [Validation(Required=false)]
            public bool? AuditClosable { get; set; }

            /// <summary>
            /// <para>Indicates whether SQL Explorer can be released. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: can be released.</description></item>
            /// <item><description><b>false</b>: cannot be released.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AuditReleasable")]
            [Validation(Required=false)]
            public bool? AuditReleasable { get; set; }

            /// <summary>
            /// <para>Indicates whether the current logon account has authorized DSC to access RAM. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: authorized.</description></item>
            /// <item><description><b>false</b>: not authorized.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Authed")]
            [Validation(Required=false)]
            public bool? Authed { get; set; }

            /// <summary>
            /// <para>The billing method of the DSC service purchased by the current logon account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PREPAY</b>: subscription.</description></item>
            /// <item><description><b>POSTPAY</b>: pay-as-you-go.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PREPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The permissions of the current account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: has management or read-only permissions for Data Security Center.</description></item>
            /// <item><description><b>1</b>: has data domain management permissions.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DataManagerRole")]
            [Validation(Required=false)]
            public int? DataManagerRole { get; set; }

            /// <summary>
            /// <para>The instance ID of the Data Security Center product purchased by the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sddp-cn-****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The number of instances in the current logon account.</para>
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
            /// <para>Indicates whether the asset lab feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: enabled.</description></item>
            /// <item><description><b>0</b>: not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LabStatus")]
            [Validation(Required=false)]
            public int? LabStatus { get; set; }

            /// <summary>
            /// <para>The total OSS storage capacity. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2048</para>
            /// </summary>
            [NameInMap("OssTotalSize")]
            [Validation(Required=false)]
            public long? OssTotalSize { get; set; }

            /// <summary>
            /// <para>The total number of days that user assets have been protected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("ProtectionDays")]
            [Validation(Required=false)]
            public int? ProtectionDays { get; set; }

            /// <summary>
            /// <para>Indicates whether the DSC service is purchased. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: purchased.</description></item>
            /// <item><description><b>false</b>: not purchased.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Purchased")]
            [Validation(Required=false)]
            public bool? Purchased { get; set; }

            /// <summary>
            /// <para>The number of days from expiration to release. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("ReleaseDays")]
            [Validation(Required=false)]
            public int? ReleaseDays { get; set; }

            /// <summary>
            /// <para>The release time. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15000</para>
            /// </summary>
            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }

            /// <summary>
            /// <para>The remaining days of the protection period for assets in the current logon account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131</para>
            /// </summary>
            [NameInMap("RemainDays")]
            [Validation(Required=false)]
            public int? RemainDays { get; set; }

            /// <summary>
            /// <para>Indicates whether the current logon account is using a trial version of DSC. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: trial.</description></item>
            /// <item><description><b>false</b>: non-trial.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Trail")]
            [Validation(Required=false)]
            public bool? Trail { get; set; }

            /// <summary>
            /// <para>Indicates whether the Agent audit feature has been used. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: has been used.</description></item>
            /// <item><description><b>0</b>: has not been used.</description></item>
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
            /// <para>The used OSS storage capacity. Unit: bytes.</para>
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
