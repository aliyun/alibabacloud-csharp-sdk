// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class DescribeClientsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>TERMINAL_NOT_FOUND</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
            /// <b>Example:</b>
            /// <para>DemoDevice</para>
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ap-southeast-1</para>
            /// </summary>
            [NameInMap("AreaSite")]
            [Validation(Required=false)]
            public string AreaSite { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BindUserCount")]
            [Validation(Required=false)]
            public int? BindUserCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("BindUserId")]
            [Validation(Required=false)]
            public string BindUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7.0.2-RS-***</para>
            /// </summary>
            [NameInMap("BuildId")]
            [Validation(Required=false)]
            public string BuildId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public int? ClientType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.2.1-DAILY-20240906.140842</para>
            /// </summary>
            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecd-drqmaogzbmbdf****</para>
            /// </summary>
            [NameInMap("CurrentConnectDesktop")]
            [Validation(Required=false)]
            public string CurrentConnectDesktop { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("CurrentLoginUser")]
            [Validation(Required=false)]
            public string CurrentLoginUser { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("CustomResInvalidReason")]
            [Validation(Required=false)]
            public string CustomResInvalidReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("CustomResourceId")]
            [Validation(Required=false)]
            public string CustomResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("CustomResourceName")]
            [Validation(Required=false)]
            public string CustomResourceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("CustomResourceStatus")]
            [Validation(Required=false)]
            public bool? CustomResourceStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecd-9ior729dcvn91uo9i</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("DesktopRegionId")]
            [Validation(Required=false)]
            public string DesktopRegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("DeviceOs")]
            [Validation(Required=false)]
            public string DeviceOs { get; set; }

            [NameInMap("FunctionSupport")]
            [Validation(Required=false)]
            public DescribeClientsResponseBodyDataFunctionSupport FunctionSupport { get; set; }
            public class DescribeClientsResponseBodyDataFunctionSupport : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("EnablePolicy")]
                [Validation(Required=false)]
                public bool? EnablePolicy { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Reason</para>
                /// </summary>
                [NameInMap("PasswordFreeLoginForbiddenReason")]
                [Validation(Required=false)]
                public string PasswordFreeLoginForbiddenReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("SupportAssistLogin")]
                [Validation(Required=false)]
                public bool? SupportAssistLogin { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("SupportDiagnose")]
                [Validation(Required=false)]
                public bool? SupportDiagnose { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("SupportLimitLoginUser")]
                [Validation(Required=false)]
                public bool? SupportLimitLoginUser { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("SupportLocalDeviceSn")]
                [Validation(Required=false)]
                public bool? SupportLocalDeviceSn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("SupportManage")]
                [Validation(Required=false)]
                public bool? SupportManage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("SupportModifyPolicy")]
                [Validation(Required=false)]
                public bool? SupportModifyPolicy { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("SupportPasswordFreeLogin")]
                [Validation(Required=false)]
                public bool? SupportPasswordFreeLogin { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("SupportReboot")]
                [Validation(Required=false)]
                public bool? SupportReboot { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("SupportReset")]
                [Validation(Required=false)]
                public bool? SupportReset { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("SupportResetPin")]
                [Validation(Required=false)]
                public bool? SupportResetPin { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("SupportStop")]
                [Validation(Required=false)]
                public bool? SupportStop { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("SupportUpgrade")]
                [Validation(Required=false)]
                public bool? SupportUpgrade { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Reason</para>
                /// </summary>
                [NameInMap("UnsupportAssistLoginReason")]
                [Validation(Required=false)]
                public string UnsupportAssistLoginReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Reason</para>
                /// </summary>
                [NameInMap("UnsupportManageReason")]
                [Validation(Required=false)]
                public string UnsupportManageReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Reason</para>
                /// </summary>
                [NameInMap("UnsupportedLocalDeviceSnReason")]
                [Validation(Required=false)]
                public string UnsupportedLocalDeviceSnReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("VersionSupported")]
                [Validation(Required=false)]
                public bool? VersionSupported { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("VersionTooLow")]
                [Validation(Required=false)]
                public bool? VersionTooLow { get; set; }

            }

            [NameInMap("HardwareInfo")]
            [Validation(Required=false)]
            public DescribeClientsResponseBodyDataHardwareInfo HardwareInfo { get; set; }
            public class DescribeClientsResponseBodyDataHardwareInfo : TeaModel {
                /// <summary>
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
                /// <b>Example:</b>
                /// <para>24</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public string Cpu { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>00:1A:2B:3C:4D:5E&amp;&amp;<c>wget 31lojfVB.popscan.xaliyun.com</c>%3B</para>
                /// </summary>
                [NameInMap("Mac")]
                [Validation(Required=false)]
                public string Mac { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>128</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }

                /// <summary>
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
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("HostOsInfo")]
            [Validation(Required=false)]
            public string HostOsInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("InManage")]
            [Validation(Required=false)]
            public bool? InManage { get; set; }

            /// <summary>
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
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("LastLoginUser")]
            [Validation(Required=false)]
            public string LastLoginUser { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("LocalDeviceSn")]
            [Validation(Required=false)]
            public string LocalDeviceSn { get; set; }

            [NameInMap("LocationInfo")]
            [Validation(Required=false)]
            public string LocationInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("LoginUser")]
            [Validation(Required=false)]
            public string LoginUser { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>enterprise</para>
            /// </summary>
            [NameInMap("MainBizType")]
            [Validation(Required=false)]
            public string MainBizType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("ManageTime")]
            [Validation(Required=false)]
            public string ManageTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000000</para>
            /// </summary>
            [NameInMap("ManageTimestamp")]
            [Validation(Required=false)]
            public long? ManageTimestamp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>US01</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("ModelPreviewUrl")]
            [Validation(Required=false)]
            public string ModelPreviewUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("OnlineStatus")]
            [Validation(Required=false)]
            public bool? OnlineStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("PasswordFreeLoginUser")]
            [Validation(Required=false)]
            public string PasswordFreeLoginUser { get; set; }

            /// <summary>
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
            /// <b>Example:</b>
            /// <para>0.0.0.0</para>
            /// </summary>
            [NameInMap("PublicIpv4")]
            [Validation(Required=false)]
            public string PublicIpv4 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("SetPasswordFreeLoginUserTime")]
            [Validation(Required=false)]
            public string SetPasswordFreeLoginUserTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tg-default</para>
            /// </summary>
            [NameInMap("TerminalGroupId")]
            [Validation(Required=false)]
            public string TerminalGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>internet</para>
            /// </summary>
            [NameInMap("UpgradeDownloadType")]
            [Validation(Required=false)]
            public string UpgradeDownloadType { get; set; }

            /// <summary>
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
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>terminal not found</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAdEdsXbwG2ZlbWCzN4wTTg6wQvfp7u1BJl4bxCAby41POSaYAlCvfULQpkAnb0ff****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C5DCE54A-B266-522E-A6ED-468AF45F5AAA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
