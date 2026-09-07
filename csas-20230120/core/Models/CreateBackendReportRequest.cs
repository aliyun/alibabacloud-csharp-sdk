// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateBackendReportRequest : TeaModel {
        /// <summary>
        /// <para>The filing expiration time as a UNIX timestamp in seconds. This parameter is required when ValidityType is set to FixedTime or ValidityType is not specified, and the value must be later than the current time. When ValidityType is set to Permanent, do not specify this parameter or set it to 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1788192000</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// <para>The filing policy type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrivateAccessBlock: private access.</description></item>
        /// <item><description>DomainWhitelist: domain name whitelist.</description></item>
        /// <item><description>DomainBlacklist: domain name blacklist.</description></item>
        /// <item><description>SoftwareBlock: software blocking.</description></item>
        /// <item><description>DlpSend: file outbound transfer.</description></item>
        /// <item><description>PeripheralBlock: peripheral control.</description></item>
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
        /// <para>The filing reason. The value must be 1 to 1024 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Temporary project access</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The list of filing objects, serialized in Flat format. You can specify 1 to 100 filing objects of the same policy type. The object fields must match the PolicyType value.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ReportObjects")]
        [Validation(Required=false)]
        public List<CreateBackendReportRequestReportObjects> ReportObjects { get; set; }
        public class CreateBackendReportRequestReportObjects : TeaModel {
            /// <summary>
            /// <para>The private access application ID. This parameter is required when PolicyType is set to PrivateAccessBlock. You can call ListPrivateAccessApplications to query the ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pa-app-****************1234</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The endpoint operating system. This parameter is required when PolicyType is set to PeripheralBlock. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>windows: Windows.</description></item>
            /// <item><description>macOS: macOS.</description></item>
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
            /// <para>The file MD5 hash. This parameter is required when PolicyType is set to DlpSend. The value must be a 32-character hexadecimal string and is case-insensitive.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c936226c4745125b5786527d205a****</para>
            /// </summary>
            [NameInMap("FileMd5")]
            [Validation(Required=false)]
            public string FileMd5 { get; set; }

            /// <summary>
            /// <para>The filing domain name. This parameter is required when PolicyType is set to DomainWhitelist or DomainBlacklist. Regular domain names and wildcard domain names that start with *. are supported. Protocols, ports, and paths are not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>*.example.com</para>
            /// </summary>
            [NameInMap("ReportDomain")]
            [Validation(Required=false)]
            public string ReportDomain { get; set; }

            /// <summary>
            /// <para>The peripheral filing granularity. This parameter is required when PolicyType is set to PeripheralBlock. Currently, only Channel is supported, which indicates filing by peripheral channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Channel</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>The blocked software ID. This parameter is required when PolicyType is set to SoftwareBlock.</para>
            /// 
            /// <b>Example:</b>
            /// <para>swb-c717ee516145****</para>
            /// </summary>
            [NameInMap("SoftwareId")]
            [Validation(Required=false)]
            public string SoftwareId { get; set; }

        }

        /// <summary>
        /// <para>The list of filing users, serialized in Flat format. You can specify 1 to 100 users. Only specific SASE users under the current Alibaba Cloud account are supported. The product of the number of deduplicated users and the number of filing objects cannot exceed 100.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<CreateBackendReportRequestTargets> Targets { get; set; }
        public class CreateBackendReportRequestTargets : TeaModel {
            /// <summary>
            /// <para>The SASE user ID. You can call ListUsers to query the ID.</para>
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
        /// <para>The validity duration type. Default value: FixedTime. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FixedTime: Expires at the specified time.</description></item>
        /// <item><description>Permanent: Permanently valid.</description></item>
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
