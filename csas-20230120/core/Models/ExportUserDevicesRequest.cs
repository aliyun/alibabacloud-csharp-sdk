// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ExportUserDevicesRequest : TeaModel {
        /// <summary>
        /// <para>Collection of client statuses.</para>
        /// </summary>
        [NameInMap("AppStatuses")]
        [Validation(Required=false)]
        public List<string> AppStatuses { get; set; }

        /// <summary>
        /// <para>Department name. Must be 1 to 128 characters long. Supports Chinese, uppercase and lowercase letters, digits, periods (.), commas (,), semicolons (;), hyphens (-), underscores (_), forward slashes (/), at signs (@), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试部</para>
        /// </summary>
        [NameInMap("Department")]
        [Validation(Required=false)]
        public string Department { get; set; }

        /// <summary>
        /// <para>Terminal device ownership. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Personal</b>: Personal device.</para>
        /// </description></item>
        /// <item><description><para><b>Company</b>: Company device.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Company</para>
        /// </summary>
        [NameInMap("DeviceBelong")]
        [Validation(Required=false)]
        public string DeviceBelong { get; set; }

        /// <summary>
        /// <para>Collection of terminal device statuses.</para>
        /// </summary>
        [NameInMap("DeviceStatuses")]
        [Validation(Required=false)]
        public List<string> DeviceStatuses { get; set; }

        /// <summary>
        /// <para>Collection of terminal device IDs.</para>
        /// </summary>
        [NameInMap("DeviceTags")]
        [Validation(Required=false)]
        public List<string> DeviceTags { get; set; }

        /// <summary>
        /// <para>Collection of terminal device operating system types.</para>
        /// </summary>
        [NameInMap("DeviceTypes")]
        [Validation(Required=false)]
        public List<string> DeviceTypes { get; set; }

        /// <summary>
        /// <para>Collection of office data protection statuses.</para>
        /// </summary>
        [NameInMap("DlpStatuses")]
        [Validation(Required=false)]
        public List<string> DlpStatuses { get; set; }

        /// <summary>
        /// <para>Terminal device name. Must be 1 to 128 characters long. Supports Chinese, uppercase and lowercase letters, digits, periods (.), commas (,), semicolons (;), hyphens (-), underscores (<em>), forward slashes (/), at signs (@), and spaces. If you enter only an underscore (</em>), the system returns all terminal devices whose names contain four-byte UTF-8 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>win10-64bit</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <para>Collection of Internet access statuses.</para>
        /// </summary>
        [NameInMap("IaStatuses")]
        [Validation(Required=false)]
        public List<string> IaStatuses { get; set; }

        /// <summary>
        /// <para>MAC address of the terminal device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:16:7c:46:<b>:</b></para>
        /// </summary>
        [NameInMap("Mac")]
        [Validation(Required=false)]
        public string Mac { get; set; }

        /// <summary>
        /// <para>Collection of network admission statuses.</para>
        /// </summary>
        [NameInMap("NacStatuses")]
        [Validation(Required=false)]
        public List<string> NacStatuses { get; set; }

        /// <summary>
        /// <para>Collection of private network access statuses.</para>
        /// </summary>
        [NameInMap("PaStatuses")]
        [Validation(Required=false)]
        public List<string> PaStatuses { get; set; }

        /// <summary>
        /// <para>User ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
        /// </summary>
        [NameInMap("SaseUserId")]
        [Validation(Required=false)]
        public string SaseUserId { get; set; }

        /// <summary>
        /// <para>Whether device sharing is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Sharing is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Sharing is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SharingStatus")]
        [Validation(Required=false)]
        public bool? SharingStatus { get; set; }

        /// <summary>
        /// <para>Username. Must be 1 to 128 characters long. Supports Chinese, uppercase and lowercase letters, digits, periods (.), underscores (_), hyphens (-), asterisks (\*), at signs (@), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>王先生</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
