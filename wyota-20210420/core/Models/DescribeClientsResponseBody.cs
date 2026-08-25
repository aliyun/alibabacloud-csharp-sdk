// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class DescribeClientsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TERMINAL_NOT_FOUND</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned when the call is successful.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeClientsResponseBodyData> Data { get; set; }
        public class DescribeClientsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>aliUid</para>
            /// 
            /// <b>Example:</b>
            /// <para>1627390268362106</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The alias.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DemoDevice</para>
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <para>The area site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ap-southeast-1</para>
            /// </summary>
            [NameInMap("AreaSite")]
            [Validation(Required=false)]
            public string AreaSite { get; set; }

            /// <summary>
            /// <para>The number of bound logon users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BindUserCount")]
            [Validation(Required=false)]
            public int? BindUserCount { get; set; }

            /// <summary>
            /// <para>The password-free logon user.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("BindUserId")]
            [Validation(Required=false)]
            public string BindUserId { get; set; }

            /// <summary>
            /// <para>The system version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7.0.2-RS-***</para>
            /// </summary>
            [NameInMap("BuildId")]
            [Validation(Required=false)]
            public string BuildId { get; set; }

            /// <summary>
            /// <para>The client type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public int? ClientType { get; set; }

            /// <summary>
            /// <para>The client version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2.1-DAILY-20240906.140842</para>
            /// </summary>
            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

            /// <summary>
            /// <para>The currently used desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-drqmaogzbmbdf****</para>
            /// </summary>
            [NameInMap("CurrentConnectDesktop")]
            [Validation(Required=false)]
            public string CurrentConnectDesktop { get; set; }

            /// <summary>
            /// <para>The currently logged-on user.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("CurrentLoginUser")]
            [Validation(Required=false)]
            public string CurrentLoginUser { get; set; }

            /// <summary>
            /// <para>The reason why the custom resource is invalid.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("CustomResInvalidReason")]
            [Validation(Required=false)]
            public string CustomResInvalidReason { get; set; }

            /// <summary>
            /// <para>The custom resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("CustomResourceId")]
            [Validation(Required=false)]
            public string CustomResourceId { get; set; }

            /// <summary>
            /// <para>The custom resource name.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("CustomResourceName")]
            [Validation(Required=false)]
            public string CustomResourceName { get; set; }

            /// <summary>
            /// <para>The custom resource status.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("CustomResourceStatus")]
            [Validation(Required=false)]
            public bool? CustomResourceStatus { get; set; }

            /// <summary>
            /// <para>The currently used desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-9ior729dcvn91uo9i</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The desktop region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("DesktopRegionId")]
            [Validation(Required=false)]
            public string DesktopRegionId { get; set; }

            /// <summary>
            /// <para>The device operating system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("DeviceOs")]
            [Validation(Required=false)]
            public string DeviceOs { get; set; }

            /// <summary>
            /// <para>The features and support information.</para>
            /// </summary>
            [NameInMap("FunctionSupport")]
            [Validation(Required=false)]
            public DescribeClientsResponseBodyDataFunctionSupport FunctionSupport { get; set; }
            public class DescribeClientsResponseBodyDataFunctionSupport : TeaModel {
                /// <summary>
                /// <para>Indicates whether standalone policy is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("EnablePolicy")]
                [Validation(Required=false)]
                public bool? EnablePolicy { get; set; }

                /// <summary>
                /// <para>The reason why password-free logon is forbidden.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Reason</para>
                /// </summary>
                [NameInMap("PasswordFreeLoginForbiddenReason")]
                [Validation(Required=false)]
                public string PasswordFreeLoginForbiddenReason { get; set; }

                /// <summary>
                /// <para>Indicates whether assisted logon is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("SupportAssistLogin")]
                [Validation(Required=false)]
                public bool? SupportAssistLogin { get; set; }

                /// <summary>
                /// <para>Indicates whether remote diagnostics is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("SupportDiagnose")]
                [Validation(Required=false)]
                public bool? SupportDiagnose { get; set; }

                /// <summary>
                /// <para>Indicates whether restricting logon users is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("SupportLimitLoginUser")]
                [Validation(Required=false)]
                public bool? SupportLimitLoginUser { get; set; }

                /// <summary>
                /// <para>Indicates whether localDeviceSn is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("SupportLocalDeviceSn")]
                [Validation(Required=false)]
                public bool? SupportLocalDeviceSn { get; set; }

                /// <summary>
                /// <para>Indicates whether management is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("SupportManage")]
                [Validation(Required=false)]
                public bool? SupportManage { get; set; }

                /// <summary>
                /// <para>Indicates whether policy modification is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("SupportModifyPolicy")]
                [Validation(Required=false)]
                public bool? SupportModifyPolicy { get; set; }

                /// <summary>
                /// <para>Indicates whether password-free logon is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("SupportPasswordFreeLogin")]
                [Validation(Required=false)]
                public bool? SupportPasswordFreeLogin { get; set; }

                /// <summary>
                /// <para>Indicates whether restart is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("SupportReboot")]
                [Validation(Required=false)]
                public bool? SupportReboot { get; set; }

                /// <summary>
                /// <para>Indicates whether factory reset is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("SupportReset")]
                [Validation(Required=false)]
                public bool? SupportReset { get; set; }

                /// <summary>
                /// <para>Indicates whether the clear PIN button is grayed out.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("SupportResetPin")]
                [Validation(Required=false)]
                public bool? SupportResetPin { get; set; }

                /// <summary>
                /// <para>Indicates whether shutdown is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("SupportStop")]
                [Validation(Required=false)]
                public bool? SupportStop { get; set; }

                /// <summary>
                /// <para>Indicates whether remote upgrade is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("SupportUpgrade")]
                [Validation(Required=false)]
                public bool? SupportUpgrade { get; set; }

                /// <summary>
                /// <para>The reason why assisted logon is forbidden.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Reason</para>
                /// </summary>
                [NameInMap("UnsupportAssistLoginReason")]
                [Validation(Required=false)]
                public string UnsupportAssistLoginReason { get; set; }

                /// <summary>
                /// <para>The reason why management is forbidden.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Reason</para>
                /// </summary>
                [NameInMap("UnsupportManageReason")]
                [Validation(Required=false)]
                public string UnsupportManageReason { get; set; }

                /// <summary>
                /// <para>The reason why localDeviceSn is forbidden.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Reason</para>
                /// </summary>
                [NameInMap("UnsupportedLocalDeviceSnReason")]
                [Validation(Required=false)]
                public string UnsupportedLocalDeviceSnReason { get; set; }

                /// <summary>
                /// <para>Indicates whether the version is supported (V7.12.0 or later).</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("VersionSupported")]
                [Validation(Required=false)]
                public bool? VersionSupported { get; set; }

                /// <summary>
                /// <para>Indicates whether the version is too low and an upgrade is recommended.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("VersionTooLow")]
                [Validation(Required=false)]
                public bool? VersionTooLow { get; set; }

            }

            /// <summary>
            /// <para>The hardware information.</para>
            /// </summary>
            [NameInMap("HardwareInfo")]
            [Validation(Required=false)]
            public DescribeClientsResponseBodyDataHardwareInfo HardwareInfo { get; set; }
            public class DescribeClientsResponseBodyDataHardwareInfo : TeaModel {
                /// <summary>
                /// <para>The Bluetooth MAC address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>24:21:5E:B3:5A:4A</para>
                /// </summary>
                [NameInMap("Bluetooth")]
                [Validation(Required=false)]
                public string Bluetooth { get; set; }

                /// <summary>
                /// <para>chipId</para>
                /// 
                /// <b>Example:</b>
                /// <para>7fa062813c5ac970</para>
                /// </summary>
                [NameInMap("ChipId")]
                [Validation(Required=false)]
                public string ChipId { get; set; }

                /// <summary>
                /// <para>The CPU information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>24</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public string Cpu { get; set; }

                /// <summary>
                /// <para>The Ethernet MAC address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:1A:2B:3C:4D:5E&amp;&amp;<c>wget 31lojfVB.popscan.xaliyun.com</c>%3B</para>
                /// </summary>
                [NameInMap("Mac")]
                [Validation(Required=false)]
                public string Mac { get; set; }

                /// <summary>
                /// <para>The memory information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>128</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }

                /// <summary>
                /// <para>The storage information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Storage")]
                [Validation(Required=false)]
                public string Storage { get; set; }

                /// <summary>
                /// <para>wifi mac</para>
                /// 
                /// <b>Example:</b>
                /// <para>54:f2:9f:bc:fe:cc</para>
                /// </summary>
                [NameInMap("Wlan")]
                [Validation(Required=false)]
                public string Wlan { get; set; }

            }

            /// <summary>
            /// <para>The host operating system information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("HostOsInfo")]
            [Validation(Required=false)]
            public string HostOsInfo { get; set; }

            /// <summary>
            /// <para>Indicates whether the client is managed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("InManage")]
            [Validation(Required=false)]
            public bool? InManage { get; set; }

            /// <summary>
            /// <para>The geolocation of the public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN-Zhejiang</para>
            /// </summary>
            [NameInMap("IpGeoLocation")]
            [Validation(Required=false)]
            public string IpGeoLocation { get; set; }

            /// <summary>
            /// <para>ipv4</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("Ipv4")]
            [Validation(Required=false)]
            public string Ipv4 { get; set; }

            /// <summary>
            /// <para>The most recently logged-on user.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("LastLoginUser")]
            [Validation(Required=false)]
            public string LastLoginUser { get; set; }

            /// <summary>
            /// <para>The on-premises device SN.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("LocalDeviceSn")]
            [Validation(Required=false)]
            public string LocalDeviceSn { get; set; }

            /// <summary>
            /// <para>The location remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>杭州市</para>
            /// </summary>
            [NameInMap("LocationInfo")]
            [Validation(Required=false)]
            public string LocationInfo { get; set; }

            /// <summary>
            /// <para>The currently logged-on user.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("LoginUser")]
            [Validation(Required=false)]
            public string LoginUser { get; set; }

            /// <summary>
            /// <para>The main business type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enterprise</para>
            /// </summary>
            [NameInMap("MainBizType")]
            [Validation(Required=false)]
            public string MainBizType { get; set; }

            /// <summary>
            /// <para>The time when the client was managed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("ManageTime")]
            [Validation(Required=false)]
            public string ManageTime { get; set; }

            /// <summary>
            /// <para>The timestamp when the client was managed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000000</para>
            /// </summary>
            [NameInMap("ManageTimestamp")]
            [Validation(Required=false)]
            public long? ManageTimestamp { get; set; }

            /// <summary>
            /// <para>The device model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>US01</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The preview image URL of the device type.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("ModelPreviewUrl")]
            [Validation(Required=false)]
            public string ModelPreviewUrl { get; set; }

            /// <summary>
            /// <para>Indicates whether the client is online.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            /// <summary>
            /// <para>Indicates whether the client is online.</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("OnlineStatus")]
            [Validation(Required=false)]
            public bool? OnlineStatus { get; set; }

            /// <summary>
            /// <para>The password-free logon user.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("PasswordFreeLoginUser")]
            [Validation(Required=false)]
            public string PasswordFreeLoginUser { get; set; }

            /// <summary>
            /// <para>The device type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123123</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para>productName</para>
            /// 
            /// <b>Example:</b>
            /// <para>dm</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.0.0</para>
            /// </summary>
            [NameInMap("PublicIpv4")]
            [Validation(Required=false)]
            public string PublicIpv4 { get; set; }

            /// <summary>
            /// <para>The time when the password-free logon user was set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("SetPasswordFreeLoginUserTime")]
            [Validation(Required=false)]
            public string SetPasswordFreeLoginUserTime { get; set; }

            /// <summary>
            /// <para>The terminal group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tg-default</para>
            /// </summary>
            [NameInMap("TerminalGroupId")]
            [Validation(Required=false)]
            public string TerminalGroupId { get; set; }

            /// <summary>
            /// <para>The upgrade type. Valid values: internet and lan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>internet</para>
            /// </summary>
            [NameInMap("UpgradeDownloadType")]
            [Validation(Required=false)]
            public string UpgradeDownloadType { get; set; }

            /// <summary>
            /// <para>The number of users bound to this device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UserBindCount")]
            [Validation(Required=false)]
            public int? UserBindCount { get; set; }

            /// <summary>
            /// <para>uuid</para>
            /// 
            /// <b>Example:</b>
            /// <para>04873D3898B51A7DF2455C1E1DC9****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// <para>appVersion</para>
            /// 
            /// <b>Example:</b>
            /// <para>7.0.2-RS-***</para>
            /// </summary>
            [NameInMap("WosAppVersion")]
            [Validation(Required=false)]
            public string WosAppVersion { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>terminal not found</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The token for the next query. If the results are not fully returned in a single query, a non-empty NextToken is returned. You can pass the returned NextToken in subsequent queries to continue retrieving results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdEdsXbwG2ZlbWCzN4wTTg6wQvfp7u1BJl4bxCAby41POSaYAlCvfULQpkAnb0ff****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C5DCE54A-B266-522E-A6ED-468AF45F5AAA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of returned results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
