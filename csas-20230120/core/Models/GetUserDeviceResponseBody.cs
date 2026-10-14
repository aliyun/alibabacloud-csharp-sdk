// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetUserDeviceResponseBody : TeaModel {
        /// <summary>
        /// <para>The endpoint device.</para>
        /// </summary>
        [NameInMap("Device")]
        [Validation(Required=false)]
        public GetUserDeviceResponseBodyDevice Device { get; set; }
        public class GetUserDeviceResponseBodyDevice : TeaModel {
            /// <summary>
            /// <para>The status of the client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Online</b>: Online.</description></item>
            /// <item><description><b>Offline</b>: Offline.</description></item>
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
            /// <para>The password-free logon status of the device. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: Enabled.</description></item>
            /// <item><description><b>Disabled</b>: Disabled.</description></item>
            /// <item><description><b>Unprovisioned</b>: Unprovisioned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("AutoLoginStatus")]
            [Validation(Required=false)]
            public string AutoLoginStatus { get; set; }

            /// <summary>
            /// <para>The battery health percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("BatteryHealthPercentage")]
            [Validation(Required=false)]
            public int? BatteryHealthPercentage { get; set; }

            /// <summary>
            /// <para>The remaining battery percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("BatteryRemainingPercentage")]
            [Validation(Required=false)]
            public int? BatteryRemainingPercentage { get; set; }

            /// <summary>
            /// <para>The CPU model of the endpoint device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Apple M1</para>
            /// </summary>
            [NameInMap("CPU")]
            [Validation(Required=false)]
            public string CPU { get; set; }

            /// <summary>
            /// <para>The city to which the public IP address belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hangzhou City</para>
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// <para>The city in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Beijing City</para>
            /// </summary>
            [NameInMap("CityEn")]
            [Validation(Required=false)]
            public string CityEn { get; set; }

            /// <summary>
            /// <para>The city in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>北京市</para>
            /// </summary>
            [NameInMap("CityZh")]
            [Validation(Required=false)]
            public string CityZh { get; set; }

            /// <summary>
            /// <para>The continent to which the public IP address belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia</para>
            /// </summary>
            [NameInMap("Continent")]
            [Validation(Required=false)]
            public string Continent { get; set; }

            /// <summary>
            /// <para>The continent in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia</para>
            /// </summary>
            [NameInMap("ContinentEn")]
            [Validation(Required=false)]
            public string ContinentEn { get; set; }

            /// <summary>
            /// <para>The continent in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>亚洲</para>
            /// </summary>
            [NameInMap("ContinentZh")]
            [Validation(Required=false)]
            public string ContinentZh { get; set; }

            /// <summary>
            /// <para>The country to which the public IP address belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China</para>
            /// </summary>
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            /// <summary>
            /// <para>The country in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China</para>
            /// </summary>
            [NameInMap("CountryEn")]
            [Validation(Required=false)]
            public string CountryEn { get; set; }

            /// <summary>
            /// <para>The country in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>中国</para>
            /// </summary>
            [NameInMap("CountryZh")]
            [Validation(Required=false)]
            public string CountryZh { get; set; }

            /// <summary>
            /// <para>The registration time of the endpoint device. Format: YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-16 17:18:46</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The department to which the user belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test Department</para>
            /// </summary>
            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            /// <summary>
            /// <para>The ownership of the endpoint device. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Personal</b>: Personal device.</description></item>
            /// <item><description><b>Company</b>: Company device.</description></item>
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
            /// <item><description><b>Online</b>: Online.</description></item>
            /// <item><description><b>Offline</b>: Offline.</description></item>
            /// <item><description><b>LongTermOffline</b>: Long-term offline.</description></item>
            /// <item><description><b>Locked</b>: Locked.</description></item>
            /// <item><description><b>Lost</b>: Reported as lost.</description></item>
            /// <item><description><b>Unbound</b>: Unbound.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Online</para>
            /// </summary>
            [NameInMap("DeviceStatus")]
            [Validation(Required=false)]
            public string DeviceStatus { get; set; }

            /// <summary>
            /// <para>The ID of the endpoint device.</para>
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
            /// <para>The available disk space, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("DiskAvailable")]
            [Validation(Required=false)]
            public int? DiskAvailable { get; set; }

            /// <summary>
            /// <para>The used disk space, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>103</para>
            /// </summary>
            [NameInMap("DiskUsed")]
            [Validation(Required=false)]
            public int? DiskUsed { get; set; }

            /// <summary>
            /// <para>The office data protection status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: Enabled.</description></item>
            /// <item><description><b>Disabled</b>: Disabled.</description></item>
            /// <item><description><b>Unprovisioned</b>: Unprovisioned.</description></item>
            /// <item><description><b>Unauthorized</b>: Unauthorized.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Unauthorized</para>
            /// </summary>
            [NameInMap("DlpStatus")]
            [Validation(Required=false)]
            public string DlpStatus { get; set; }

            /// <summary>
            /// <para>The anti-intrusion status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: Enabled.</description></item>
            /// <item><description><b>Disabled</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Disabled</para>
            /// </summary>
            [NameInMap("EdrStatus")]
            [Validation(Required=false)]
            public string EdrStatus { get; set; }

            /// <summary>
            /// <para>The collection of historical users of the endpoint device.</para>
            /// </summary>
            [NameInMap("HistoryUsers")]
            [Validation(Required=false)]
            public List<GetUserDeviceResponseBodyDeviceHistoryUsers> HistoryUsers { get; set; }
            public class GetUserDeviceResponseBodyDeviceHistoryUsers : TeaModel {
                /// <summary>
                /// <para>The ID of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
                /// </summary>
                [NameInMap("SaseUserId")]
                [Validation(Required=false)]
                public string SaseUserId { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Ms. Zhang</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

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
            /// <item><description><b>Enabled</b>: Enabled.</description></item>
            /// <item><description><b>Disabled</b>: Disabled.</description></item>
            /// <item><description><b>Unprovisioned</b>: Unprovisioned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Disabled</para>
            /// </summary>
            [NameInMap("IaStatus")]
            [Validation(Required=false)]
            public string IaStatus { get; set; }

            /// <summary>
            /// <para>The internal IP address of the endpoint device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.XX.XX</para>
            /// </summary>
            [NameInMap("InnerIP")]
            [Validation(Required=false)]
            public string InnerIP { get; set; }

            /// <summary>
            /// <para>Indicates whether the terminal is joined to an Active Directory (AD) domain.</para>
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
            /// <para>48:9e:XX:XX:02:80</para>
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
            /// <item><description><b>Enabled</b>: Enabled.</description></item>
            /// <item><description><b>Disabled</b>: Disabled.</description></item>
            /// <item><description><b>Unprovisioned</b>: Unprovisioned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Unprovisioned</para>
            /// </summary>
            [NameInMap("NacStatus")]
            [Validation(Required=false)]
            public string NacStatus { get; set; }

            /// <summary>
            /// <para>The list of network interface controllers (NICs) of the endpoint device.</para>
            /// </summary>
            [NameInMap("NetInterfaceInfo")]
            [Validation(Required=false)]
            public List<GetUserDeviceResponseBodyDeviceNetInterfaceInfo> NetInterfaceInfo { get; set; }
            public class GetUserDeviceResponseBodyDeviceNetInterfaceInfo : TeaModel {
                /// <summary>
                /// <para>The MAC address of the NIC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:16:XX:XX:7c:46</para>
                /// </summary>
                [NameInMap("Mac")]
                [Validation(Required=false)]
                public string Mac { get; set; }

                /// <summary>
                /// <para>The name of the NIC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eth0</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The internal network access status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: Enabled.</description></item>
            /// <item><description><b>Disabled</b>: Disabled.</description></item>
            /// <item><description><b>Unprovisioned</b>: Unprovisioned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("PaStatus")]
            [Validation(Required=false)]
            public string PaStatus { get; set; }

            /// <summary>
            /// <para>The list of running processes on the terminal.</para>
            /// </summary>
            [NameInMap("Processes")]
            [Validation(Required=false)]
            public List<GetUserDeviceResponseBodyDeviceProcesses> Processes { get; set; }
            public class GetUserDeviceResponseBodyDeviceProcesses : TeaModel {
                /// <summary>
                /// <para>The CPU usage percentage of the process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.05</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public double? Cpu { get; set; }

                /// <summary>
                /// <para>The description of the running process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>C:\Program Files\Google\Chrome\Application\chrome.exe</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The memory usage of the process, in MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>233</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

                /// <summary>
                /// <para>The name of the process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>chrome.exe</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The province to which the public IP address belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhejiang</para>
            /// </summary>
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            /// <summary>
            /// <para>The province in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Beijing</para>
            /// </summary>
            [NameInMap("ProvinceEn")]
            [Validation(Required=false)]
            public string ProvinceEn { get; set; }

            /// <summary>
            /// <para>The province in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>北京市</para>
            /// </summary>
            [NameInMap("ProvinceZh")]
            [Validation(Required=false)]
            public string ProvinceZh { get; set; }

            /// <summary>
            /// <para>The ID of the user.</para>
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
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Disabled.</description></item>
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
            /// <para>The serial number of the BIOS.</para>
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
            /// <para>The serial number of the processor.</para>
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
            /// <para>106.14.XX.XX</para>
            /// </summary>
            [NameInMap("SrcIP")]
            [Validation(Required=false)]
            public string SrcIP { get; set; }

            /// <summary>
            /// <para>The timestamp when the terminal process information was collected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1775096714</para>
            /// </summary>
            [NameInMap("TerminalInfoCollectTime")]
            [Validation(Required=false)]
            public long? TerminalInfoCollectTime { get; set; }

            /// <summary>
            /// <para>The last online time of the endpoint device. Format: YYYY-MM-DD HH:mm:ss.</para>
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
            /// <para>Mr. Wang</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

            /// <summary>
            /// <para>The name of the office area.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test Office Area</para>
            /// </summary>
            [NameInMap("Workshop")]
            [Validation(Required=false)]
            public string Workshop { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EFE7EBB2-449D-5BBB-B381-CA7839BC1649</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
