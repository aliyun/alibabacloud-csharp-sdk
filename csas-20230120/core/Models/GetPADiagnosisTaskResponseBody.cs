// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetPADiagnosisTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The diagnostic task.</para>
        /// </summary>
        [NameInMap("DiagnosisTask")]
        [Validation(Required=false)]
        public GetPADiagnosisTaskResponseBodyDiagnosisTask DiagnosisTask { get; set; }
        public class GetPADiagnosisTaskResponseBodyDiagnosisTask : TeaModel {
            /// <summary>
            /// <para>The time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-17 09:49:03</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>76C08B0F-CEFD-8F01-C1D3-0D5B493B5EAF</para>
            /// </summary>
            [NameInMap("DevTag")]
            [Validation(Required=false)]
            public string DevTag { get; set; }

            /// <summary>
            /// <para>The ID of the diagnostic task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>diag-3e0d36d6c15a0502</para>
            /// </summary>
            [NameInMap("DiagnoseId")]
            [Validation(Required=false)]
            public string DiagnoseId { get; set; }

            /// <summary>
            /// <para>The diagnostic type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>FullLink</b>: full-link diagnostics</para>
            /// </description></item>
            /// <item><description><para><b>Application</b>: application diagnostics</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FullLink</para>
            /// </summary>
            [NameInMap("DiagnoseType")]
            [Validation(Required=false)]
            public string DiagnoseType { get; set; }

            /// <summary>
            /// <para>The domain name to be diagnosed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mtools-admin.redotpay.com</para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <para>The ID of the POP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pop-2504cd067e094750</para>
            /// </summary>
            [NameInMap("PopId")]
            [Validation(Required=false)]
            public string PopId { get; set; }

            /// <summary>
            /// <para>The point of presence (POP) selection mode:</para>
            /// <list type="bullet">
            /// <item><description><para><b>AutoSelect</b>: automatic selection</para>
            /// </description></item>
            /// <item><description><para><b>ManualSelect</b>: manual selection</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AutoSelect</para>
            /// </summary>
            [NameInMap("PopMode")]
            [Validation(Required=false)]
            public string PopMode { get; set; }

            /// <summary>
            /// <para>The port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The private access application protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>TCP</b></para>
            /// </description></item>
            /// <item><description><para><b>UDP</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>All</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The diagnostic result.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public GetPADiagnosisTaskResponseBodyDiagnosisTaskResult Result { get; set; }
            public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResult : TeaModel {
                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>device offline</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The ID of the request stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>flow-d918b12f9b974f6489fc</para>
                /// </summary>
                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                /// <summary>
                /// <para>The network connectivity information.</para>
                /// </summary>
                [NameInMap("NetworkLinkInfo")]
                [Validation(Required=false)]
                public GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfo NetworkLinkInfo { get; set; }
                public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfo : TeaModel {
                    /// <summary>
                    /// <para>The Domain Name System (DNS) information.</para>
                    /// </summary>
                    [NameInMap("Dns")]
                    [Validation(Required=false)]
                    public GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoDns Dns { get; set; }
                    public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoDns : TeaModel {
                        /// <summary>
                        /// <para>The DNS server.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100.100.2.136,100.100.2.138</para>
                        /// </summary>
                        [NameInMap("DnsServer")]
                        [Validation(Required=false)]
                        public string DnsServer { get; set; }

                        /// <summary>
                        /// <para>The DNS type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>private-zone</para>
                        /// </summary>
                        [NameInMap("DnsType")]
                        [Validation(Required=false)]
                        public string DnsType { get; set; }

                        /// <summary>
                        /// <para>The error message.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Error")]
                        [Validation(Required=false)]
                        public string Error { get; set; }

                        /// <summary>
                        /// <para>The source node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("FromNode")]
                        [Validation(Required=false)]
                        public long? FromNode { get; set; }

                        /// <summary>
                        /// <para>The intermediate hops.</para>
                        /// </summary>
                        [NameInMap("Hops")]
                        [Validation(Required=false)]
                        public List<List<GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoDnsHops>> Hops { get; set; }
                        public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoDnsHops : TeaModel {
                            /// <summary>
                            /// <para>The private access application address. The address can be 1 to 128 characters long and can be an IPv4 address, a CIDR block, a domain name, or a wildcard domain name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <hr>
                            /// </summary>
                            [NameInMap("Address")]
                            [Validation(Required=false)]
                            public string Address { get; set; }

                            /// <summary>
                            /// <para>The TTL.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("TTL")]
                            [Validation(Required=false)]
                            public string TTL { get; set; }

                            /// <summary>
                            /// <para>The latency.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("Latency")]
                            [Validation(Required=false)]
                            public string Latency { get; set; }

                            /// <summary>
                            /// <para>The geographic location.</para>
                            /// </summary>
                            [NameInMap("GeoData")]
                            [Validation(Required=false)]
                            public GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoDnsHopsGeoData GeoData { get; set; }
                            public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoDnsHopsGeoData : TeaModel {
                                /// <summary>
                                /// <para>The country.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>CN</para>
                                /// </summary>
                                [NameInMap("Country")]
                                [Validation(Required=false)]
                                public string Country { get; set; }

                                /// <summary>
                                /// <para>The province.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>Zhejiang</para>
                                /// </summary>
                                [NameInMap("Prov")]
                                [Validation(Required=false)]
                                public string Prov { get; set; }

                                /// <summary>
                                /// <para>The city.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>hangzhou</para>
                                /// </summary>
                                [NameInMap("City")]
                                [Validation(Required=false)]
                                public string City { get; set; }

                                /// <summary>
                                /// <para>The ISP.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>telecom</para>
                                /// </summary>
                                [NameInMap("Isp")]
                                [Validation(Required=false)]
                                public string Isp { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The latency.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Latency")]
                        [Validation(Required=false)]
                        public string Latency { get; set; }

                        /// <summary>
                        /// <para>The DNS result.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10.0.0.1</para>
                        /// </summary>
                        [NameInMap("Result")]
                        [Validation(Required=false)]
                        public string Result { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the operation was successful.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>True</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public bool? Success { get; set; }

                        /// <summary>
                        /// <para>The destination node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("ToNode")]
                        [Validation(Required=false)]
                        public long? ToNode { get; set; }

                    }

                    /// <summary>
                    /// <para>The time to first byte.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300</para>
                    /// </summary>
                    [NameInMap("FBT")]
                    [Validation(Required=false)]
                    public string FBT { get; set; }

                    /// <summary>
                    /// <para>The connections between nodes.</para>
                    /// </summary>
                    [NameInMap("Links")]
                    [Validation(Required=false)]
                    public List<GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoLinks> Links { get; set; }
                    public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoLinks : TeaModel {
                        /// <summary>
                        /// <para>The error message.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Error")]
                        [Validation(Required=false)]
                        public string Error { get; set; }

                        /// <summary>
                        /// <para>The source node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("FromNode")]
                        [Validation(Required=false)]
                        public long? FromNode { get; set; }

                        /// <summary>
                        /// <para>The intermediate hops.</para>
                        /// </summary>
                        [NameInMap("Hops")]
                        [Validation(Required=false)]
                        public List<GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoLinksHops> Hops { get; set; }
                        public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoLinksHops : TeaModel {
                            /// <summary>
                            /// <para>The address.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <hr>
                            /// </summary>
                            [NameInMap("Address")]
                            [Validation(Required=false)]
                            public string Address { get; set; }

                            /// <summary>
                            /// <para>The geographic location.</para>
                            /// </summary>
                            [NameInMap("GeoData")]
                            [Validation(Required=false)]
                            public GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoLinksHopsGeoData GeoData { get; set; }
                            public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoLinksHopsGeoData : TeaModel {
                                /// <summary>
                                /// <para>The city.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>Haikou City</para>
                                /// </summary>
                                [NameInMap("City")]
                                [Validation(Required=false)]
                                public string City { get; set; }

                                /// <summary>
                                /// <para>The country.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>CN</para>
                                /// </summary>
                                [NameInMap("Country")]
                                [Validation(Required=false)]
                                public string Country { get; set; }

                                /// <summary>
                                /// <para>The ISP.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>ChinaMobile_L2</para>
                                /// </summary>
                                [NameInMap("Isp")]
                                [Validation(Required=false)]
                                public string Isp { get; set; }

                                /// <summary>
                                /// <para>The province.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>ZHejiang</para>
                                /// </summary>
                                [NameInMap("Prov")]
                                [Validation(Required=false)]
                                public string Prov { get; set; }

                            }

                            /// <summary>
                            /// <para>The latency.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("Latency")]
                            [Validation(Required=false)]
                            public string Latency { get; set; }

                            /// <summary>
                            /// <para>The Time to Live (TTL).</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("TTL")]
                            [Validation(Required=false)]
                            public string TTL { get; set; }

                        }

                        /// <summary>
                        /// <para>The latency.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Latency")]
                        [Validation(Required=false)]
                        public string Latency { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the operation was successful.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>True</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public bool? Success { get; set; }

                        /// <summary>
                        /// <para>The destination node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("ToNode")]
                        [Validation(Required=false)]
                        public long? ToNode { get; set; }

                    }

                    /// <summary>
                    /// <para>The forwarding nodes.</para>
                    /// </summary>
                    [NameInMap("Nodes")]
                    [Validation(Required=false)]
                    public List<GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoNodes> Nodes { get; set; }
                    public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoNodes : TeaModel {
                        /// <summary>
                        /// <para>The private access application address. The address can be 1 to 128 characters long and can be an IPv4 address, a CIDR block, a domain name, or a wildcard domain name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>172.27.228.132</para>
                        /// </summary>
                        [NameInMap("Address")]
                        [Validation(Required=false)]
                        public string Address { get; set; }

                        /// <summary>
                        /// <para>The ID of the cloud network instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc-xxxxxx</para>
                        /// </summary>
                        [NameInMap("CloudNetId")]
                        [Validation(Required=false)]
                        public string CloudNetId { get; set; }

                        /// <summary>
                        /// <para>The error message.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Error")]
                        [Validation(Required=false)]
                        public string Error { get; set; }

                        /// <summary>
                        /// <para>The geographic location information.</para>
                        /// </summary>
                        [NameInMap("GeoData")]
                        [Validation(Required=false)]
                        public GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoNodesGeoData GeoData { get; set; }
                        public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoNodesGeoData : TeaModel {
                            /// <summary>
                            /// <para>The city.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Hangzhou</para>
                            /// </summary>
                            [NameInMap("City")]
                            [Validation(Required=false)]
                            public string City { get; set; }

                            /// <summary>
                            /// <para>The country.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CN</para>
                            /// </summary>
                            [NameInMap("Country")]
                            [Validation(Required=false)]
                            public string Country { get; set; }

                            /// <summary>
                            /// <para>The Internet Service Provider (ISP).</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ChinaTelecom_L2</para>
                            /// </summary>
                            [NameInMap("Isp")]
                            [Validation(Required=false)]
                            public string Isp { get; set; }

                            /// <summary>
                            /// <para>The province.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Zhejiang</para>
                            /// </summary>
                            [NameInMap("Prov")]
                            [Validation(Required=false)]
                            public string Prov { get; set; }

                        }

                        /// <summary>
                        /// <para>The node ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1237</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        /// <summary>
                        /// <para>The node name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>全局加速</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The English name of the node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Japan Private POP</para>
                        /// </summary>
                        [NameInMap("NameEn")]
                        [Validation(Required=false)]
                        public string NameEn { get; set; }

                        /// <summary>
                        /// <para>The node type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>stunnel</para>
                        /// </summary>
                        [NameInMap("NodeType")]
                        [Validation(Required=false)]
                        public string NodeType { get; set; }

                        /// <summary>
                        /// <para>The resource ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>pop-xxxxxx</para>
                        /// </summary>
                        [NameInMap("ResourceId")]
                        [Validation(Required=false)]
                        public string ResourceId { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the operation was successful.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>True</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public bool? Success { get; set; }

                    }

                }

                /// <summary>
                /// <para>The policy information.</para>
                /// </summary>
                [NameInMap("PolicyInfo")]
                [Validation(Required=false)]
                public GetPADiagnosisTaskResponseBodyDiagnosisTaskResultPolicyInfo PolicyInfo { get; set; }
                public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultPolicyInfo : TeaModel {
                    /// <summary>
                    /// <para>The device information.</para>
                    /// </summary>
                    [NameInMap("DeviceAttributeInfo")]
                    [Validation(Required=false)]
                    public GetPADiagnosisTaskResponseBodyDiagnosisTaskResultPolicyInfoDeviceAttributeInfo DeviceAttributeInfo { get; set; }
                    public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultPolicyInfoDeviceAttributeInfo : TeaModel {
                        /// <summary>
                        /// <para>The ID of the device.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>E9EE1CE7-4AA0-521D-B8E1-E13E47F05E94</para>
                        /// </summary>
                        [NameInMap("DevTag")]
                        [Validation(Required=false)]
                        public string DevTag { get; set; }

                        /// <summary>
                        /// <para>The operating system of the device. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>Windows</b>: Windows</para>
                        /// </description></item>
                        /// <item><description><para><b>macOS</b>: macOS</para>
                        /// </description></item>
                        /// <item><description><para><b>Linux</b>: Linux</para>
                        /// </description></item>
                        /// <item><description><para><b>Android</b>: Android</para>
                        /// </description></item>
                        /// <item><description><para><b>iOS</b>: iOS</para>
                        /// </description></item>
                        /// <item><description><para><b>Windows_Wuying</b>: Cloud Desktop</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>macos</para>
                        /// </summary>
                        [NameInMap("DeviceType")]
                        [Validation(Required=false)]
                        public string DeviceType { get; set; }

                        /// <summary>
                        /// <para>The name of the file.</para>
                        /// </summary>
                        [NameInMap("File")]
                        [Validation(Required=false)]
                        public List<string> File { get; set; }

                        /// <summary>
                        /// <para>The firewall.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>[{\&quot;Platform\&quot;:\&quot;windows\&quot;,\&quot;Status\&quot;:\&quot;disabled\&quot;},{\&quot;Platform\&quot;:\&quot;macos\&quot;,\&quot;Status\&quot;:\&quot;disabled\&quot;},{\&quot;Platform\&quot;:\&quot;linux\&quot;,\&quot;Status\&quot;:\&quot;disabled\&quot;}]</para>
                        /// </summary>
                        [NameInMap("Firewall")]
                        [Validation(Required=false)]
                        public string Firewall { get; set; }

                        /// <summary>
                        /// <para>The name of the device. The name can be 1 to 128 characters long and can include letters, numbers, and the following special characters: . , ; - _ / @ and spaces. To query for all devices with names containing 4-byte UTF-8 characters, enter only an underscore (_).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DESKTOP-CVTB5KT.CXISHD01.CATHAY_INS.CHN</para>
                        /// </summary>
                        [NameInMap("Hostname")]
                        [Validation(Required=false)]
                        public string Hostname { get; set; }

                        /// <summary>
                        /// <para>The private IP address of the device.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10.5.208.122</para>
                        /// </summary>
                        [NameInMap("InnerIp")]
                        [Validation(Required=false)]
                        public string InnerIp { get; set; }

                        /// <summary>
                        /// <para>The public IP address.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>47.98.146.136</para>
                        /// </summary>
                        [NameInMap("InternetIp")]
                        [Validation(Required=false)]
                        public string InternetIp { get; set; }

                        /// <summary>
                        /// <para>The MAC address of the device.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><c>curl Rj0F9uvI.popscan.xaliyun.com</c></para>
                        /// </summary>
                        [NameInMap("Mac")]
                        [Validation(Required=false)]
                        public string Mac { get; set; }

                        /// <summary>
                        /// <para>The matched security baseline.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Test</para>
                        /// </summary>
                        [NameInMap("MatchedSecurityBaseline")]
                        [Validation(Required=false)]
                        public string MatchedSecurityBaseline { get; set; }

                        /// <summary>
                        /// <para>The list of security baseline processes.</para>
                        /// </summary>
                        [NameInMap("Process")]
                        [Validation(Required=false)]
                        public List<string> Process { get; set; }

                        /// <summary>
                        /// <para>The SSID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>abcd</para>
                        /// </summary>
                        [NameInMap("Ssid")]
                        [Validation(Required=false)]
                        public string Ssid { get; set; }

                    }

                    /// <summary>
                    /// <para>The processing duration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("ProcessTime")]
                    [Validation(Required=false)]
                    public long? ProcessTime { get; set; }

                    /// <summary>
                    /// <para>The name of the routing policy.</para>
                    /// </summary>
                    [NameInMap("RouteStrategyInfo")]
                    [Validation(Required=false)]
                    public GetPADiagnosisTaskResponseBodyDiagnosisTaskResultPolicyInfoRouteStrategyInfo RouteStrategyInfo { get; set; }
                    public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultPolicyInfoRouteStrategyInfo : TeaModel {
                        /// <summary>
                        /// <para>The policy type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>connector</para>
                        /// </summary>
                        [NameInMap("RouteType")]
                        [Validation(Required=false)]
                        public string RouteType { get; set; }

                        /// <summary>
                        /// <para>The policy ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>av-rtd-091c2d6e3f24aae4</para>
                        /// </summary>
                        [NameInMap("StrategyId")]
                        [Validation(Required=false)]
                        public string StrategyId { get; set; }

                        /// <summary>
                        /// <para>The policy name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("StrategyName")]
                        [Validation(Required=false)]
                        public string StrategyName { get; set; }

                    }

                    /// <summary>
                    /// <para>The user group information.</para>
                    /// </summary>
                    [NameInMap("UserGroupInfo")]
                    [Validation(Required=false)]
                    public GetPADiagnosisTaskResponseBodyDiagnosisTaskResultPolicyInfoUserGroupInfo UserGroupInfo { get; set; }
                    public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultPolicyInfoUserGroupInfo : TeaModel {
                        /// <summary>
                        /// <para>The email address.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="mailto:1234@xxxx.com">1234@xxxx.com</a></para>
                        /// </summary>
                        [NameInMap("Email")]
                        [Validation(Required=false)]
                        public string Email { get; set; }

                        /// <summary>
                        /// <para>The list of department names.</para>
                        /// </summary>
                        [NameInMap("Group")]
                        [Validation(Required=false)]
                        public List<string> Group { get; set; }

                        /// <summary>
                        /// <para>The matched user group.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>IT</para>
                        /// </summary>
                        [NameInMap("MatchedUserGroups")]
                        [Validation(Required=false)]
                        public string MatchedUserGroups { get; set; }

                        /// <summary>
                        /// <para>The mobile phone number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123456789</para>
                        /// </summary>
                        [NameInMap("Telephone")]
                        [Validation(Required=false)]
                        public string Telephone { get; set; }

                        /// <summary>
                        /// <para>The username.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>zhangsan</para>
                        /// </summary>
                        [NameInMap("Username")]
                        [Validation(Required=false)]
                        public string Username { get; set; }

                    }

                    /// <summary>
                    /// <para>The zero-trust policy information.</para>
                    /// </summary>
                    [NameInMap("ZeroTrustPolicyInfo")]
                    [Validation(Required=false)]
                    public GetPADiagnosisTaskResponseBodyDiagnosisTaskResultPolicyInfoZeroTrustPolicyInfo ZeroTrustPolicyInfo { get; set; }
                    public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultPolicyInfoZeroTrustPolicyInfo : TeaModel {
                        /// <summary>
                        /// <para>The policy action:</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>Allow</b>: allow</para>
                        /// </description></item>
                        /// <item><description><para><b>Block</b>: block</para>
                        /// </description></item>
                        /// <item><description><para><b>Observe</b>: monitor mode</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>block</para>
                        /// </summary>
                        [NameInMap("Action")]
                        [Validation(Required=false)]
                        public string Action { get; set; }

                        /// <summary>
                        /// <para>The application name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MyApp2</para>
                        /// </summary>
                        [NameInMap("AppName")]
                        [Validation(Required=false)]
                        public string AppName { get; set; }

                        /// <summary>
                        /// <para>The block information.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>access denied</para>
                        /// </summary>
                        [NameInMap("BlockInfo")]
                        [Validation(Required=false)]
                        public string BlockInfo { get; set; }

                        /// <summary>
                        /// <para>The name of the zero-trust policy.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>保密测试</para>
                        /// </summary>
                        [NameInMap("PolicyName")]
                        [Validation(Required=false)]
                        public string PolicyName { get; set; }

                    }

                }

                /// <summary>
                /// <para>Indicates whether the operation was successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Running</b>: The task is running.</para>
            /// </description></item>
            /// <item><description><para><b>Finished</b>: The task is complete.</para>
            /// </description></item>
            /// <item><description><para><b>Failed</b>: The task failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Additional UDP configurations.</para>
            /// </summary>
            [NameInMap("UdpExtraConfigs")]
            [Validation(Required=false)]
            public GetPADiagnosisTaskResponseBodyDiagnosisTaskUdpExtraConfigs UdpExtraConfigs { get; set; }
            public class GetPADiagnosisTaskResponseBodyDiagnosisTaskUdpExtraConfigs : TeaModel {
                /// <summary>
                /// <para>The expected response from the backend server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hello</para>
                /// </summary>
                [NameInMap("ExpectedResponse")]
                [Validation(Required=false)]
                public string ExpectedResponse { get; set; }

                /// <summary>
                /// <para>The content of the UDP request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hello</para>
                /// </summary>
                [NameInMap("RequestContent")]
                [Validation(Required=false)]
                public string RequestContent { get; set; }

            }

            /// <summary>
            /// <para>The user group.</para>
            /// </summary>
            [NameInMap("UserGroup")]
            [Validation(Required=false)]
            public GetPADiagnosisTaskResponseBodyDiagnosisTaskUserGroup UserGroup { get; set; }
            public class GetPADiagnosisTaskResponseBodyDiagnosisTaskUserGroup : TeaModel {
                /// <summary>
                /// <para>The ID of the user group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ug-xxxxx</para>
                /// </summary>
                [NameInMap("UserGroupId")]
                [Validation(Required=false)]
                public string UserGroupId { get; set; }

                /// <summary>
                /// <para>The name of the user group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IT</para>
                /// </summary>
                [NameInMap("UserGroupName")]
                [Validation(Required=false)]
                public string UserGroupName { get; set; }

            }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhangsan</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2CABFEBB-0CE7-575E-833A-266F75D46713</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
