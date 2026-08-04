// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateUserDevicesStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of endpoint devices.</para>
        /// </summary>
        [NameInMap("Devices")]
        [Validation(Required=false)]
        public List<UpdateUserDevicesStatusResponseBodyDevices> Devices { get; set; }
        public class UpdateUserDevicesStatusResponseBodyDevices : TeaModel {
            /// <summary>
            /// <para>The client status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Online</b>: Online.</para>
            /// </description></item>
            /// <item><description><para><b>Offline</b>: Offline.</para>
            /// </description></item>
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
            /// <para>The CPU model of the endpoint device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Apple M1</para>
            /// </summary>
            [NameInMap("CPU")]
            [Validation(Required=false)]
            public string CPU { get; set; }

            /// <summary>
            /// <para>The time when the endpoint device was registered.</para>
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
            /// <item><description><para><b>Online</b>: Online.</para>
            /// </description></item>
            /// <item><description><para><b>Offline</b>: Offline.</para>
            /// </description></item>
            /// <item><description><para><b>LongTermOffline</b>: Long-term offline.</para>
            /// </description></item>
            /// <item><description><para><b>Locked</b>: Locked.</para>
            /// </description></item>
            /// <item><description><para><b>Lost</b>: Reported as lost.</para>
            /// </description></item>
            /// <item><description><para><b>Unbound</b>: Detached.</para>
            /// </description></item>
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
            /// <item><description><para><b>Windows</b>: Windows.</para>
            /// </description></item>
            /// <item><description><para><b>macOS</b>: macOS.</para>
            /// </description></item>
            /// <item><description><para><b>Linux</b>: Linux.</para>
            /// </description></item>
            /// <item><description><para><b>Android</b>: Android.</para>
            /// </description></item>
            /// <item><description><para><b>iOS</b>: iOS.</para>
            /// </description></item>
            /// <item><description><para><b>Windows_Wuying</b>: Alibaba Cloud Cloud Desktop.</para>
            /// </description></item>
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
            /// <para>The data protection status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Enabled</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>Disabled</b>: Disabled.</para>
            /// </description></item>
            /// <item><description><para><b>Unprovisioned</b>: Not configured.</para>
            /// </description></item>
            /// <item><description><para><b>Unauthorized</b>: Unauthorized.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("DlpStatus")]
            [Validation(Required=false)]
            public string DlpStatus { get; set; }

            /// <summary>
            /// <para>The device name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>win10-64bit</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>Internet access status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Enabled</b>: Internet access is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>Disabled</b>: Internet access is disabled.</para>
            /// </description></item>
            /// <item><description><para><b>Unprovisioned</b>: The device is unconfigured.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("IaStatus")]
            [Validation(Required=false)]
            public string IaStatus { get; set; }

            /// <summary>
            /// <para>The private network IP address of the endpoint device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("InnerIP")]
            [Validation(Required=false)]
            public string InnerIP { get; set; }

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
            /// <para>The memory capacity of the endpoint device, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            /// <summary>
            /// <para>The network admission control status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Enabled</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>Disabled</b>: Disabled.</para>
            /// </description></item>
            /// <item><description><para><b>Unprovisioned</b>: Not configured.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("NacStatus")]
            [Validation(Required=false)]
            public string NacStatus { get; set; }

            /// <summary>
            /// <para>A list of network interface controllers (NICs) on the endpoint device.</para>
            /// </summary>
            [NameInMap("NetInterfaceInfo")]
            [Validation(Required=false)]
            public List<UpdateUserDevicesStatusResponseBodyDevicesNetInterfaceInfo> NetInterfaceInfo { get; set; }
            public class UpdateUserDevicesStatusResponseBodyDevicesNetInterfaceInfo : TeaModel {
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
                /// <para>The NIC name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eth0</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The private network access status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Enabled</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>Disabled</b>: Disabled.</para>
            /// </description></item>
            /// <item><description><para><b>Unprovisioned</b>: Not configured.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("PaStatus")]
            [Validation(Required=false)]
            public string PaStatus { get; set; }

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
            /// <para>Whether sharing is enabled for the device. Valid values:</para>
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
            /// <para>The IP address used to log on to the endpoint device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11.49.XX.XX</para>
            /// </summary>
            [NameInMap("SrcIP")]
            [Validation(Required=false)]
            public string SrcIP { get; set; }

            /// <summary>
            /// <para>The last time the endpoint device was online.</para>
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

        }

        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FEF5CFA-14CC-5DE5-BD1F-AFFE0996E71D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
