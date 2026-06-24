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
        /// <para>The details of the current account.</para>
        /// </summary>
        [NameInMap("UserStatus")]
        [Validation(Required=false)]
        public DescribeUserStatusResponseBodyUserStatus UserStatus { get; set; }
        public class DescribeUserStatusResponseBodyUserStatus : TeaModel {
            /// <summary>
            /// <para>The authorized AccessKey ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourAccessKeyID</para>
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// <para>Indicates whether the currently logged-in account has been granted the service role permissions for DSC asset synchronization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: authorized.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: unauthorized.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AssetRoleAuthed")]
            [Validation(Required=false)]
            public bool? AssetRoleAuthed { get; set; }

            /// <summary>
            /// <para>Indicates whether SQL Insights can be disabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: no.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AuditClosable")]
            [Validation(Required=false)]
            public bool? AuditClosable { get; set; }

            /// <summary>
            /// <para>Indicates whether SQL Insights can be released.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: no.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AuditReleasable")]
            [Validation(Required=false)]
            public bool? AuditReleasable { get; set; }

            /// <summary>
            /// <para>Indicates whether the current account is granted Resource Access Management (RAM) permissions on DSC. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The account is granted the permissions.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The account is not granted the permissions.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Authed")]
            [Validation(Required=false)]
            public bool? Authed { get; set; }

            /// <summary>
            /// <para>The billing method of the DSC service for the current account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>PREPAY</b>: subscription.</para>
            /// </description></item>
            /// <item><description><para><b>POSTPAY</b>: pay-as-you-go.</para>
            /// </description></item>
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
            /// <item><description><para><b>0</b>: The account has the management or read-only permissions on Data Security Center.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: The account has the management permissions on data domains.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DataManagerRole")]
            [Validation(Required=false)]
            public int? DataManagerRole { get; set; }

            /// <summary>
            /// <para>The ID of the Data Security Center instance purchased by the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sddp-cn-****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The number of instances in the current account.</para>
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
            /// <para>Indicates whether the Asset Lab feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: enabled.</para>
            /// </description></item>
            /// <item><description><para><b>0</b>: disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LabStatus")]
            [Validation(Required=false)]
            public int? LabStatus { get; set; }

            /// <summary>
            /// <para>The total OSS storage. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2048</para>
            /// </summary>
            [NameInMap("OssTotalSize")]
            [Validation(Required=false)]
            public long? OssTotalSize { get; set; }

            /// <summary>
            /// <para>The total number of days that assets have been protected.</para>
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
            /// <item><description><para><b>true</b>: yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: no.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Purchased")]
            [Validation(Required=false)]
            public bool? Purchased { get; set; }

            /// <summary>
            /// <para>The number of days from service expiration to service release. Unit: days.</para>
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
            /// <para>The number of remaining days in the protection period for the assets of the current account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131</para>
            /// </summary>
            [NameInMap("RemainDays")]
            [Validation(Required=false)]
            public int? RemainDays { get; set; }

            /// <summary>
            /// <para>Indicates whether the current account uses the trial version of the DSC service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: no.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Trail")]
            [Validation(Required=false)]
            public bool? Trail { get; set; }

            /// <summary>
            /// <para>Indicates whether the agent-based audit feature has been used. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: yes.</para>
            /// </description></item>
            /// <item><description><para><b>0</b>: no.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UseAgentAudit")]
            [Validation(Required=false)]
            public bool? UseAgentAudit { get; set; }

            /// <summary>
            /// <para>The number of used instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>125</para>
            /// </summary>
            [NameInMap("UseInstanceNum")]
            [Validation(Required=false)]
            public int? UseInstanceNum { get; set; }

            /// <summary>
            /// <para>The used Object Storage Service (OSS) storage. Unit: bytes.</para>
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
