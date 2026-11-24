// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateBackendReportRequest : TeaModel {
        /// <summary>
        /// <para>The expiration time of the report, which is a UNIX timestamp in seconds. This parameter is required when ValidityType is set to FixedTime or is not specified, and the value must be later than the current time. When ValidityType is set to Permanent, do not specify this parameter or set it to 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1788192000</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// <para>The policy type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrivateAccessBlock: private network access</description></item>
        /// <item><description>DomainWhitelist: domain name whitelist</description></item>
        /// <item><description>DomainBlacklist: domain name blacklist</description></item>
        /// <item><description>SoftwareBlock: software blocking</description></item>
        /// <item><description>DlpSend: outbound file transfer</description></item>
        /// <item><description>PeripheralBlock: peripheral control</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrivateAccessBlock</para>
        /// </summary>
        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

        /// <summary>
        /// <para>The reason for the report. The value must be 1 to 1,024 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Temporary access for a project</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The list of report objects in flat serialization format. You can specify 1 to 100 report objects of the same policy type. The object fields must match the policy type.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ReportObjects")]
        [Validation(Required=false)]
        public List<CreateBackendReportRequestReportObjects> ReportObjects { get; set; }
        public class CreateBackendReportRequestReportObjects : TeaModel {
            /// <summary>
            /// <para>The ID of the private access application. This parameter is required when PolicyType is set to PrivateAccessBlock. You can call ListPrivateAccessApplications to query the application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pa-app-****************1234</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The operating system of the endpoint. This parameter is required when PolicyType is set to PeripheralBlock. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>windows: Windows</description></item>
            /// <item><description>macOS: macOS</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>windows</para>
            /// </summary>
            [NameInMap("DevType")]
            [Validation(Required=false)]
            public string DevType { get; set; }

            /// <summary>
            /// <para>The peripheral channel. This parameter is required when PolicyType is set to PeripheralBlock. Windows supports usbStorage, printer, mobile, cardReader, cdrom, and bluetooth. macOS supports usbStorage, airDrop, mobile, and bluetooth.</para>
            /// 
            /// <b>Example:</b>
            /// <para>usbStorage</para>
            /// </summary>
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <para>The MD5 hash of the file. This parameter is required when PolicyType is set to DlpSend. The value must be a 32-character hexadecimal string and is not case-sensitive.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c936226c4745125b5786527d205a****</para>
            /// </summary>
            [NameInMap("FileMd5")]
            [Validation(Required=false)]
            public string FileMd5 { get; set; }

            /// <summary>
            /// <para>The domain name to be reported. This parameter is required when PolicyType is set to DomainWhitelist or DomainBlacklist. Regular domain names and wildcard domain names starting with *. are supported. Protocols, ports, and paths are not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>*.example.com</para>
            /// </summary>
            [NameInMap("ReportDomain")]
            [Validation(Required=false)]
            public string ReportDomain { get; set; }

            /// <summary>
            /// <para>The reporting granularity for peripherals. This parameter is required when PolicyType is set to PeripheralBlock. Only Channel is supported, which indicates reporting by peripheral channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Channel</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>The ID of the blocked software. This parameter is required when PolicyType is set to SoftwareBlock.</para>
            /// 
            /// <b>Example:</b>
            /// <para>swb-c717ee516145****</para>
            /// </summary>
            [NameInMap("SoftwareId")]
            [Validation(Required=false)]
            public string SoftwareId { get; set; }

        }

        /// <summary>
        /// <para>The list of target users in flat serialization format. You can specify 1 to 100 users. Only specific SASE users under the current Alibaba Cloud account are supported. The product of the number of deduplicated users and the number of report objects cannot exceed 100.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<CreateBackendReportRequestTargets> Targets { get; set; }
        public class CreateBackendReportRequestTargets : TeaModel {
            /// <summary>
            /// <para>The SASE user ID. You can call ListUsers to query the user ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>su_8548af20c3b30e931e75cd847a4c****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The validity type. If you do not specify this parameter, the default value is FixedTime. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FixedTime: The exemption expires at the specified time.</description></item>
        /// <item><description>Permanent: The exemption is permanently valid.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FixedTime</para>
        /// </summary>
        [NameInMap("ValidityType")]
        [Validation(Required=false)]
        public string ValidityType { get; set; }

    }

}
