// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListUserDevicesRequest : TeaModel {
        /// <summary>
        /// <para>The collection of client statuses.</para>
        /// </summary>
        [NameInMap("AppStatuses")]
        [Validation(Required=false)]
        public List<string> AppStatuses { get; set; }

        /// <summary>
        /// <para>The collection of client versions.</para>
        /// </summary>
        [NameInMap("AppVersions")]
        [Validation(Required=false)]
        public List<string> AppVersions { get; set; }

        [NameInMap("AutoLoginStatuses")]
        [Validation(Required=false)]
        public List<string> AutoLoginStatuses { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paging query. Valid values: 1 to 10000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The department to which the user belongs. The value is 1 to 128 characters in length and supports Chinese characters and uppercase and lowercase letters. It can contain digits, periods (.), commas (,), semicolons (;), hyphens (-), underscores (_), forward slashes (/), at signs (@), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试部</para>
        /// </summary>
        [NameInMap("Department")]
        [Validation(Required=false)]
        public string Department { get; set; }

        /// <summary>
        /// <para>The ownership of the endpoint device. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Personal</b>: personal device.</description></item>
        /// <item><description><b>Company</b>: company device.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Company</para>
        /// </summary>
        [NameInMap("DeviceBelong")]
        [Validation(Required=false)]
        public string DeviceBelong { get; set; }

        /// <summary>
        /// <para>The device group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>device-group-5191cf830a5e****</para>
        /// </summary>
        [NameInMap("DeviceGroupId")]
        [Validation(Required=false)]
        public string DeviceGroupId { get; set; }

        /// <summary>
        /// <para>The collection of endpoint device statuses.</para>
        /// </summary>
        [NameInMap("DeviceStatuses")]
        [Validation(Required=false)]
        public List<string> DeviceStatuses { get; set; }

        /// <summary>
        /// <para>The collection of endpoint device IDs.</para>
        /// </summary>
        [NameInMap("DeviceTags")]
        [Validation(Required=false)]
        public List<string> DeviceTags { get; set; }

        /// <summary>
        /// <para>The collection of endpoint device operating system types.</para>
        /// </summary>
        [NameInMap("DeviceTypes")]
        [Validation(Required=false)]
        public List<string> DeviceTypes { get; set; }

        /// <summary>
        /// <para>The collection of office data protection statuses.</para>
        /// </summary>
        [NameInMap("DlpStatuses")]
        [Validation(Required=false)]
        public List<string> DlpStatuses { get; set; }

        /// <summary>
        /// <para>The name of the endpoint device. The value is 1 to 128 characters in length and supports Chinese characters and uppercase and lowercase letters. It can contain digits, periods (.), commas (,), semicolons (;), hyphens (-), underscores (<em>), forward slashes (/), at signs (@), and spaces. If you enter only an underscore (</em>), endpoint devices whose names contain 4-byte UTF-8 characters are also queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>win10-64bit</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <para>The collection of Internet access statuses.</para>
        /// </summary>
        [NameInMap("IaStatuses")]
        [Validation(Required=false)]
        public List<string> IaStatuses { get; set; }

        /// <summary>
        /// <para>The internal IP address of the endpoint device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("InnerIp")]
        [Validation(Required=false)]
        public string InnerIp { get; set; }

        /// <summary>
        /// <para>The MAC address of the endpoint device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:16:XX:XX:7c:46</para>
        /// </summary>
        [NameInMap("Mac")]
        [Validation(Required=false)]
        public string Mac { get; set; }

        /// <summary>
        /// <para>The collection of network access control statuses.</para>
        /// </summary>
        [NameInMap("NacStatuses")]
        [Validation(Required=false)]
        public List<string> NacStatuses { get; set; }

        /// <summary>
        /// <para>The collection of private access statuses.</para>
        /// </summary>
        [NameInMap("PaStatuses")]
        [Validation(Required=false)]
        public List<string> PaStatuses { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paging query. Settings: 1 to 500.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The user ID. You can obtain this value from the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~GetUserDevice~~">GetUserDevice</a>: Queries the details of a user endpoint device.</description></item>
        /// <item><description><a href="~~ListUserDevices~~">ListUserDevices</a>: Lists user endpoint devices.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
        /// </summary>
        [NameInMap("SaseUserId")]
        [Validation(Required=false)]
        public string SaseUserId { get; set; }

        /// <summary>
        /// <para>Specifies whether sharing is enabled for the device. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Sharing is enabled.</description></item>
        /// <item><description><b>false</b>: Sharing is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SharingStatus")]
        [Validation(Required=false)]
        public bool? SharingStatus { get; set; }

        /// <summary>
        /// <para>The BIOS system serial number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5CG003****</para>
        /// </summary>
        [NameInMap("SnBios")]
        [Validation(Required=false)]
        public string SnBios { get; set; }

        /// <summary>
        /// <para>The system serial number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KVN9C9****</para>
        /// </summary>
        [NameInMap("SnSystem")]
        [Validation(Required=false)]
        public string SnSystem { get; set; }

        /// <summary>
        /// <para>The sort parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Username</b>: sorted by Username in ascending order.</description></item>
        /// <item><description><b>AppVersion</b>: sorted by AppVersion in descending order.</description></item>
        /// <item><description><b>UpdateTime</b>: sorted by UpdateTime in descending order.</description></item>
        /// <item><description><b>CreateTime</b>: sorted by CreateTime in descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UpdateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The username. The value is 1 to 128 characters in length and supports Chinese characters and uppercase and lowercase letters. It can contain digits, periods (.), underscores (_), hyphens (-), asterisks (*), at signs (@), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>王先生</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The name of the office area.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试办公区</para>
        /// </summary>
        [NameInMap("Workshop")]
        [Validation(Required=false)]
        public string Workshop { get; set; }

    }

}
