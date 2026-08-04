// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListUserDevicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of endpoint devices.</para>
        /// </summary>
        [NameInMap("Devices")]
        [Validation(Required=false)]
        public List<ListUserDevicesResponseBodyDevices> Devices { get; set; }
        public class ListUserDevicesResponseBodyDevices : TeaModel {
            /// <summary>
            /// <para>The client status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Online</b>: online.</description></item>
            /// <item><description><b>Offline</b>: offline.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Online</para>
            /// </summary>
            [NameInMap("AppStatus")]
            [Validation(Required=false)]
            public string AppStatus { get; set; }

            /// <summary>
            /// <para>The client version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.2.0</para>
            /// </summary>
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// <para>The auto-logon status of the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("AutoLoginStatus")]
            [Validation(Required=false)]
            public string AutoLoginStatus { get; set; }

            /// <summary>
            /// <para>The CPU model of the endpoint device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Apple M1</para>
            /// </summary>
            [NameInMap("CPU")]
            [Validation(Required=false)]
            public string CPU { get; set; }

            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// <para>The city name in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Beijing City</para>
            /// </summary>
            [NameInMap("CityEn")]
            [Validation(Required=false)]
            public string CityEn { get; set; }

            /// <summary>
            /// <para>The city name in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>北京市</para>
            /// </summary>
            [NameInMap("CityZh")]
            [Validation(Required=false)]
            public string CityZh { get; set; }

            [NameInMap("Continent")]
            [Validation(Required=false)]
            public string Continent { get; set; }

            /// <summary>
            /// <para>The continent name in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia</para>
            /// </summary>
            [NameInMap("ContinentEn")]
            [Validation(Required=false)]
            public string ContinentEn { get; set; }

            /// <summary>
            /// <para>The continent name in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>亚洲</para>
            /// </summary>
            [NameInMap("ContinentZh")]
            [Validation(Required=false)]
            public string ContinentZh { get; set; }

            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            /// <summary>
            /// <para>The country name in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China</para>
            /// </summary>
            [NameInMap("CountryEn")]
            [Validation(Required=false)]
            public string CountryEn { get; set; }

            /// <summary>
            /// <para>The country name in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>中国</para>
            /// </summary>
            [NameInMap("CountryZh")]
            [Validation(Required=false)]
            public string CountryZh { get; set; }

            /// <summary>
            /// <para>The registration time of the endpoint device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-17 18:46:55</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The department to which the user belongs.</para>
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
            /// <para>The model of the endpoint device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MacBookPro17,1</para>
            /// </summary>
            [NameInMap("DeviceModel")]
            [Validation(Required=false)]
            public string DeviceModel { get; set; }

            /// <summary>
            /// <para>The status of the endpoint device. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Online</b>: online.</description></item>
            /// <item><description><b>Offline</b>: offline.</description></item>
            /// <item><description><b>LongTermOffline</b>: long-term offline.</description></item>
            /// <item><description><b>Locked</b>: locked.</description></item>
            /// <item><description><b>Lost</b>: reported as lost.</description></item>
            /// <item><description><b>Unbound</b>: unbound.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Online</para>
            /// </summary>
            [NameInMap("DeviceStatus")]
            [Validation(Required=false)]
            public string DeviceStatus { get; set; }

            /// <summary>
            /// <para>The endpoint device ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36efa42d-2c32-c4dc-e3fc-8541e33a****</para>
            /// </summary>
            [NameInMap("DeviceTag")]
            [Validation(Required=false)]
            public string DeviceTag { get; set; }

            /// <summary>
            /// <para>The operating system type of the endpoint device. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Windows</b>: Windows.</description></item>
            /// <item><description><b>macOS</b>: macOS.</description></item>
            /// <item><description><b>Linux</b>: Linux.</description></item>
            /// <item><description><b>Android</b>: Android.</description></item>
            /// <item><description><b>iOS</b>: iOS.</description></item>
            /// <item><description><b>Windows_Wuying</b>: WUYING Workspace.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <para>The operating system version of the endpoint device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.5.1</para>
            /// </summary>
            [NameInMap("DeviceVersion")]
            [Validation(Required=false)]
            public string DeviceVersion { get; set; }

            /// <summary>
            /// <para>The disk model of the endpoint device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>APPLE SSD AP0512Q Media</para>
            /// </summary>
            [NameInMap("Disk")]
            [Validation(Required=false)]
            public string Disk { get; set; }

            /// <summary>
            /// <para>The office data protection status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: enabled.</description></item>
            /// <item><description><b>Disabled</b>: disabled.</description></item>
            /// <item><description><b>Unprovisioned</b>: not configured.</description></item>
            /// <item><description><b>Unauthorized</b>: unauthorized.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("DlpStatus")]
            [Validation(Required=false)]
            public string DlpStatus { get; set; }

            /// <summary>
            /// <para>The anti-intrusion status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: enabled.</description></item>
            /// <item><description><b>Disabled</b>: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("EdrStatus")]
            [Validation(Required=false)]
            public string EdrStatus { get; set; }

            /// <summary>
            /// <para>The list of full department paths.</para>
            /// </summary>
            [NameInMap("FullDepartment")]
            [Validation(Required=false)]
            public List<string> FullDepartment { get; set; }

            /// <summary>
            /// <para>The name of the endpoint device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>win10-64bit</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>The Internet access status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: enabled.</description></item>
            /// <item><description><b>Disabled</b>: disabled.</description></item>
            /// <item><description><b>Unprovisioned</b>: not configured.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("IaStatus")]
            [Validation(Required=false)]
            public string IaStatus { get; set; }

            /// <summary>
            /// <para>The internal IP address of the endpoint device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("InnerIP")]
            [Validation(Required=false)]
            public string InnerIP { get; set; }

            /// <summary>
            /// <para>Indicates whether the device is joined to an Active Directory (AD) domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("JoinAdDomain")]
            [Validation(Required=false)]
            public bool? JoinAdDomain { get; set; }

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
            /// <para>The collection of matched device group IDs.</para>
            /// </summary>
            [NameInMap("MatchDeviceGroupIds")]
            [Validation(Required=false)]
            public List<string> MatchDeviceGroupIds { get; set; }

            /// <summary>
            /// <para>The memory capacity of the endpoint device. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            /// <summary>
            /// <para>The network access control status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: enabled.</description></item>
            /// <item><description><b>Disabled</b>: disabled.</description></item>
            /// <item><description><b>Unprovisioned</b>: not configured.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("NacStatus")]
            [Validation(Required=false)]
            public string NacStatus { get; set; }

            /// <summary>
            /// <para>The list of network interfaces of the endpoint device.</para>
            /// </summary>
            [NameInMap("NetInterfaceInfo")]
            [Validation(Required=false)]
            public List<ListUserDevicesResponseBodyDevicesNetInterfaceInfo> NetInterfaceInfo { get; set; }
            public class ListUserDevicesResponseBodyDevicesNetInterfaceInfo : TeaModel {
                /// <summary>
                /// <para>The MAC address of the network interface.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:16:XX:XX:7c:46</para>
                /// </summary>
                [NameInMap("Mac")]
                [Validation(Required=false)]
                public string Mac { get; set; }

                /// <summary>
                /// <para>The name of the network interface.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eth0</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The private access status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: enabled.</description></item>
            /// <item><description><b>Disabled</b>: disabled.</description></item>
            /// <item><description><b>Unprovisioned</b>: not configured.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("PaStatus")]
            [Validation(Required=false)]
            public string PaStatus { get; set; }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            /// <summary>
            /// <para>The province name in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Beijing</para>
            /// </summary>
            [NameInMap("ProvinceEn")]
            [Validation(Required=false)]
            public string ProvinceEn { get; set; }

            /// <summary>
            /// <para>The province name in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>北京市</para>
            /// </summary>
            [NameInMap("ProvinceZh")]
            [Validation(Required=false)]
            public string ProvinceZh { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
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
            /// <para>The motherboard serial number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PJGGU00WBD****</para>
            /// </summary>
            [NameInMap("SnBaseBoard")]
            [Validation(Required=false)]
            public string SnBaseBoard { get; set; }

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
            /// <para>The hard disk serial number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WD-WXR1A99A****</para>
            /// </summary>
            [NameInMap("SnDiskDrive")]
            [Validation(Required=false)]
            public string SnDiskDrive { get; set; }

            /// <summary>
            /// <para>The processor serial number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BFEBFBFF0008****</para>
            /// </summary>
            [NameInMap("SnProcessor")]
            [Validation(Required=false)]
            public string SnProcessor { get; set; }

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
            /// <para>The logon IP address of the endpoint device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11.49.XX.XX</para>
            /// </summary>
            [NameInMap("SrcIP")]
            [Validation(Required=false)]
            public string SrcIP { get; set; }

            /// <summary>
            /// <para>The last online time of the endpoint device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-24 19:04:42</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The username.</para>
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

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FEF5CFA-14CC-5DE5-BD1F-AFFE0996E71D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of endpoint devices.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

    }

}
