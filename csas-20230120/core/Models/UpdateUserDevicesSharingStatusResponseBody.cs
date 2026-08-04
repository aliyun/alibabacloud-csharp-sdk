// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateUserDevicesSharingStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Device list.</para>
        /// </summary>
        [NameInMap("Devices")]
        [Validation(Required=false)]
        public List<UpdateUserDevicesSharingStatusResponseBodyDevices> Devices { get; set; }
        public class UpdateUserDevicesSharingStatusResponseBodyDevices : TeaModel {
            /// <summary>
            /// <para>The client status. Values:</para>
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
            /// <para>Client version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.2.0</para>
            /// </summary>
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// <para>Device CPU model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Apple M1</para>
            /// </summary>
            [NameInMap("CPU")]
            [Validation(Required=false)]
            public string CPU { get; set; }

            /// <summary>
            /// <para>Device registration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-16 17:18:46</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>User\&quot;s department.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试部</para>
            /// </summary>
            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            /// <summary>
            /// <para>Device ownership. Values:</para>
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
            /// <para>Device model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MacBookPro17,1</para>
            /// </summary>
            [NameInMap("DeviceModel")]
            [Validation(Required=false)]
            public string DeviceModel { get; set; }

            /// <summary>
            /// <para>The status of the device. Values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Online</b>: Online.</para>
            /// </description></item>
            /// <item><description><para><b>Offline</b>: Offline.</para>
            /// </description></item>
            /// <item><description><para><b>LongTermOffline</b>: Long-term offline.</para>
            /// </description></item>
            /// <item><description><para><b>Locked</b>: Locked.</para>
            /// </description></item>
            /// <item><description><para><b>Lost</b>: Lost.</para>
            /// </description></item>
            /// <item><description><para><b>Unbound</b>: Unbound.</para>
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
            /// <para>Device ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36efa42d-2c32-c4dc-e3fc-8541e33a****</para>
            /// </summary>
            [NameInMap("DeviceTag")]
            [Validation(Required=false)]
            public string DeviceTag { get; set; }

            /// <summary>
            /// <para>The operating system type of the device. Values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Windows</b>: Windows system.</para>
            /// </description></item>
            /// <item><description><para><b>macOS</b>: macOS system.</para>
            /// </description></item>
            /// <item><description><para><b>Linux</b>: Linux system.</para>
            /// </description></item>
            /// <item><description><para><b>Android</b>: Android system.</para>
            /// </description></item>
            /// <item><description><para><b>iOS</b>: iOS system.</para>
            /// </description></item>
            /// <item><description><para><b>Windows_Wuying</b>: Wuying Cloud Desktop system.</para>
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
            /// <para>Device operating system version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.5.1</para>
            /// </summary>
            [NameInMap("DeviceVersion")]
            [Validation(Required=false)]
            public string DeviceVersion { get; set; }

            /// <summary>
            /// <para>Device disk model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>APPLE SSD AP0512Q Media</para>
            /// </summary>
            [NameInMap("Disk")]
            [Validation(Required=false)]
            public string Disk { get; set; }

            /// <summary>
            /// <para>Data protection status. Values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Enabled</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>Disabled</b>: Disabled.</para>
            /// </description></item>
            /// <item><description><para><b>Unprovisioned</b>: Unprovisioned.</para>
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
            /// <para>Device name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>win10-64bit</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>Internet access status. Values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Enabled</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>Disabled</b>: Disabled.</para>
            /// </description></item>
            /// <item><description><para><b>Unprovisioned</b>: Unprovisioned.</para>
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
            /// <para>Device private network IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("InnerIP")]
            [Validation(Required=false)]
            public string InnerIP { get; set; }

            /// <summary>
            /// <para>Device MAC address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:16:XX:XX:7c:46</para>
            /// </summary>
            [NameInMap("Mac")]
            [Validation(Required=false)]
            public string Mac { get; set; }

            /// <summary>
            /// <para>Device memory capacity. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            /// <summary>
            /// <para>Network access control status. Values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Enabled</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>Disabled</b>: Disabled.</para>
            /// </description></item>
            /// <item><description><para><b>Unprovisioned</b>: Unprovisioned.</para>
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
            /// <para>NIC list.</para>
            /// </summary>
            [NameInMap("NetInterfaceInfo")]
            [Validation(Required=false)]
            public List<UpdateUserDevicesSharingStatusResponseBodyDevicesNetInterfaceInfo> NetInterfaceInfo { get; set; }
            public class UpdateUserDevicesSharingStatusResponseBodyDevicesNetInterfaceInfo : TeaModel {
                /// <summary>
                /// <para>NIC MAC address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:16:XX:XX:7c:46</para>
                /// </summary>
                [NameInMap("Mac")]
                [Validation(Required=false)]
                public string Mac { get; set; }

                /// <summary>
                /// <para>NIC name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eth0</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>Private network access status. Values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Enabled</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>Disabled</b>: Disabled.</para>
            /// </description></item>
            /// <item><description><para><b>Unprovisioned</b>: Unprovisioned.</para>
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
            /// <para>User ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
            /// </summary>
            [NameInMap("SaseUserId")]
            [Validation(Required=false)]
            public string SaseUserId { get; set; }

            /// <summary>
            /// <para>Indicates whether device sharing is enabled. Values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enable sharing.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disable sharing.</para>
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
            /// <para>Device logon IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11.49.XX.XX</para>
            /// </summary>
            [NameInMap("SrcIP")]
            [Validation(Required=false)]
            public string SrcIP { get; set; }

            /// <summary>
            /// <para>Device last online time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-24 19:04:42</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>Username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>王先生</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4D169859-A4F2-5EC8-853B-8447787C0D8A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
