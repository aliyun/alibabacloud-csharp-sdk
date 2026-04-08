// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetPADiagnosisTaskResponseBody : TeaModel {
        [NameInMap("DiagnosisTask")]
        [Validation(Required=false)]
        public GetPADiagnosisTaskResponseBodyDiagnosisTask DiagnosisTask { get; set; }
        public class GetPADiagnosisTaskResponseBodyDiagnosisTask : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-08-17 09:49:03</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>76C08B0F-CEFD-8F01-C1D3-0D5B493B5EAF</para>
            /// </summary>
            [NameInMap("DevTag")]
            [Validation(Required=false)]
            public string DevTag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>diag-3e0d36d6c15a0502</para>
            /// </summary>
            [NameInMap("DiagnoseId")]
            [Validation(Required=false)]
            public string DiagnoseId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FullLink</para>
            /// </summary>
            [NameInMap("DiagnoseType")]
            [Validation(Required=false)]
            public string DiagnoseType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mtools-admin.redotpay.com</para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pop-2504cd067e094750</para>
            /// </summary>
            [NameInMap("PopId")]
            [Validation(Required=false)]
            public string PopId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AutoSelect</para>
            /// </summary>
            [NameInMap("PopMode")]
            [Validation(Required=false)]
            public string PopMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>All</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public GetPADiagnosisTaskResponseBodyDiagnosisTaskResult Result { get; set; }
            public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>device offline</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>flow-d918b12f9b974f6489fc</para>
                /// </summary>
                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                [NameInMap("NetworkLinkInfo")]
                [Validation(Required=false)]
                public GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfo NetworkLinkInfo { get; set; }
                public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfo : TeaModel {
                    [NameInMap("Dns")]
                    [Validation(Required=false)]
                    public GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoDns Dns { get; set; }
                    public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoDns : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>100.100.2.136,100.100.2.138</para>
                        /// </summary>
                        [NameInMap("DnsServer")]
                        [Validation(Required=false)]
                        public string DnsServer { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>private-zone</para>
                        /// </summary>
                        [NameInMap("DnsType")]
                        [Validation(Required=false)]
                        public string DnsType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Error")]
                        [Validation(Required=false)]
                        public string Error { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("FromNode")]
                        [Validation(Required=false)]
                        public long? FromNode { get; set; }

                        [NameInMap("Hops")]
                        [Validation(Required=false)]
                        public List<List<GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoDnsHops>> Hops { get; set; }
                        public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoDnsHops : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <hr>
                            /// </summary>
                            [NameInMap("Address")]
                            [Validation(Required=false)]
                            public string Address { get; set; }

                            /// <summary>
                            /// <para>TTL。</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("TTL")]
                            [Validation(Required=false)]
                            public string TTL { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("Latency")]
                            [Validation(Required=false)]
                            public string Latency { get; set; }

                            [NameInMap("GeoData")]
                            [Validation(Required=false)]
                            public GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoDnsHopsGeoData GeoData { get; set; }
                            public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoDnsHopsGeoData : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>CN</para>
                                /// </summary>
                                [NameInMap("Country")]
                                [Validation(Required=false)]
                                public string Country { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>Zhejiang</para>
                                /// </summary>
                                [NameInMap("Prov")]
                                [Validation(Required=false)]
                                public string Prov { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>hangzhou</para>
                                /// </summary>
                                [NameInMap("City")]
                                [Validation(Required=false)]
                                public string City { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>telecom</para>
                                /// </summary>
                                [NameInMap("Isp")]
                                [Validation(Required=false)]
                                public string Isp { get; set; }

                            }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Latency")]
                        [Validation(Required=false)]
                        public string Latency { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10.0.0.1</para>
                        /// </summary>
                        [NameInMap("Result")]
                        [Validation(Required=false)]
                        public string Result { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>True</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public bool? Success { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("ToNode")]
                        [Validation(Required=false)]
                        public long? ToNode { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>300</para>
                    /// </summary>
                    [NameInMap("FBT")]
                    [Validation(Required=false)]
                    public string FBT { get; set; }

                    [NameInMap("Links")]
                    [Validation(Required=false)]
                    public List<GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoLinks> Links { get; set; }
                    public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoLinks : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Error")]
                        [Validation(Required=false)]
                        public string Error { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("FromNode")]
                        [Validation(Required=false)]
                        public long? FromNode { get; set; }

                        [NameInMap("Hops")]
                        [Validation(Required=false)]
                        public List<GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoLinksHops> Hops { get; set; }
                        public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoLinksHops : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <hr>
                            /// </summary>
                            [NameInMap("Address")]
                            [Validation(Required=false)]
                            public string Address { get; set; }

                            [NameInMap("GeoData")]
                            [Validation(Required=false)]
                            public GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoLinksHopsGeoData GeoData { get; set; }
                            public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoLinksHopsGeoData : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>Haikou City</para>
                                /// </summary>
                                [NameInMap("City")]
                                [Validation(Required=false)]
                                public string City { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>CN</para>
                                /// </summary>
                                [NameInMap("Country")]
                                [Validation(Required=false)]
                                public string Country { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>ChinaMobile_L2</para>
                                /// </summary>
                                [NameInMap("Isp")]
                                [Validation(Required=false)]
                                public string Isp { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>ZHejiang</para>
                                /// </summary>
                                [NameInMap("Prov")]
                                [Validation(Required=false)]
                                public string Prov { get; set; }

                            }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("Latency")]
                            [Validation(Required=false)]
                            public string Latency { get; set; }

                            /// <summary>
                            /// <para>TTL。</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("TTL")]
                            [Validation(Required=false)]
                            public string TTL { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Latency")]
                        [Validation(Required=false)]
                        public string Latency { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>True</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public bool? Success { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("ToNode")]
                        [Validation(Required=false)]
                        public long? ToNode { get; set; }

                    }

                    [NameInMap("Nodes")]
                    [Validation(Required=false)]
                    public List<GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoNodes> Nodes { get; set; }
                    public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoNodes : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>172.27.228.132</para>
                        /// </summary>
                        [NameInMap("Address")]
                        [Validation(Required=false)]
                        public string Address { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>vpc-xxxxxx</para>
                        /// </summary>
                        [NameInMap("CloudNetId")]
                        [Validation(Required=false)]
                        public string CloudNetId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Error")]
                        [Validation(Required=false)]
                        public string Error { get; set; }

                        [NameInMap("GeoData")]
                        [Validation(Required=false)]
                        public GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoNodesGeoData GeoData { get; set; }
                        public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultNetworkLinkInfoNodesGeoData : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>Hangzhou</para>
                            /// </summary>
                            [NameInMap("City")]
                            [Validation(Required=false)]
                            public string City { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CN</para>
                            /// </summary>
                            [NameInMap("Country")]
                            [Validation(Required=false)]
                            public string Country { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>ChinaTelecom_L2</para>
                            /// </summary>
                            [NameInMap("Isp")]
                            [Validation(Required=false)]
                            public string Isp { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>Zhejiang</para>
                            /// </summary>
                            [NameInMap("Prov")]
                            [Validation(Required=false)]
                            public string Prov { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1237</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Japan Private POP</para>
                        /// </summary>
                        [NameInMap("NameEn")]
                        [Validation(Required=false)]
                        public string NameEn { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>stunnel</para>
                        /// </summary>
                        [NameInMap("NodeType")]
                        [Validation(Required=false)]
                        public string NodeType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>pop-xxxxxx</para>
                        /// </summary>
                        [NameInMap("ResourceId")]
                        [Validation(Required=false)]
                        public string ResourceId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>True</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public bool? Success { get; set; }

                    }

                }

                [NameInMap("PolicyInfo")]
                [Validation(Required=false)]
                public GetPADiagnosisTaskResponseBodyDiagnosisTaskResultPolicyInfo PolicyInfo { get; set; }
                public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultPolicyInfo : TeaModel {
                    [NameInMap("DeviceAttributeInfo")]
                    [Validation(Required=false)]
                    public GetPADiagnosisTaskResponseBodyDiagnosisTaskResultPolicyInfoDeviceAttributeInfo DeviceAttributeInfo { get; set; }
                    public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultPolicyInfoDeviceAttributeInfo : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>E9EE1CE7-4AA0-521D-B8E1-E13E47F05E94</para>
                        /// </summary>
                        [NameInMap("DevTag")]
                        [Validation(Required=false)]
                        public string DevTag { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>macos</para>
                        /// </summary>
                        [NameInMap("DeviceType")]
                        [Validation(Required=false)]
                        public string DeviceType { get; set; }

                        [NameInMap("File")]
                        [Validation(Required=false)]
                        public List<string> File { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>[{\&quot;Platform\&quot;:\&quot;windows\&quot;,\&quot;Status\&quot;:\&quot;disabled\&quot;},{\&quot;Platform\&quot;:\&quot;macos\&quot;,\&quot;Status\&quot;:\&quot;disabled\&quot;},{\&quot;Platform\&quot;:\&quot;linux\&quot;,\&quot;Status\&quot;:\&quot;disabled\&quot;}]</para>
                        /// </summary>
                        [NameInMap("Firewall")]
                        [Validation(Required=false)]
                        public string Firewall { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>DESKTOP-CVTB5KT.CXISHD01.CATHAY_INS.CHN</para>
                        /// </summary>
                        [NameInMap("Hostname")]
                        [Validation(Required=false)]
                        public string Hostname { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10.5.208.122</para>
                        /// </summary>
                        [NameInMap("InnerIp")]
                        [Validation(Required=false)]
                        public string InnerIp { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>47.98.146.136</para>
                        /// </summary>
                        [NameInMap("InternetIp")]
                        [Validation(Required=false)]
                        public string InternetIp { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><c>curl Rj0F9uvI.popscan.xaliyun.com</c></para>
                        /// </summary>
                        [NameInMap("Mac")]
                        [Validation(Required=false)]
                        public string Mac { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Test</para>
                        /// </summary>
                        [NameInMap("MatchedSecurityBaseline")]
                        [Validation(Required=false)]
                        public string MatchedSecurityBaseline { get; set; }

                        [NameInMap("Process")]
                        [Validation(Required=false)]
                        public List<string> Process { get; set; }

                        /// <summary>
                        /// <para>SSID。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>abcd</para>
                        /// </summary>
                        [NameInMap("Ssid")]
                        [Validation(Required=false)]
                        public string Ssid { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("ProcessTime")]
                    [Validation(Required=false)]
                    public long? ProcessTime { get; set; }

                    [NameInMap("RouteStrategyInfo")]
                    [Validation(Required=false)]
                    public GetPADiagnosisTaskResponseBodyDiagnosisTaskResultPolicyInfoRouteStrategyInfo RouteStrategyInfo { get; set; }
                    public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultPolicyInfoRouteStrategyInfo : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>connector</para>
                        /// </summary>
                        [NameInMap("RouteType")]
                        [Validation(Required=false)]
                        public string RouteType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>av-rtd-091c2d6e3f24aae4</para>
                        /// </summary>
                        [NameInMap("StrategyId")]
                        [Validation(Required=false)]
                        public string StrategyId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("StrategyName")]
                        [Validation(Required=false)]
                        public string StrategyName { get; set; }

                    }

                    [NameInMap("UserGroupInfo")]
                    [Validation(Required=false)]
                    public GetPADiagnosisTaskResponseBodyDiagnosisTaskResultPolicyInfoUserGroupInfo UserGroupInfo { get; set; }
                    public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultPolicyInfoUserGroupInfo : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="mailto:1234@xxxx.com">1234@xxxx.com</a></para>
                        /// </summary>
                        [NameInMap("Email")]
                        [Validation(Required=false)]
                        public string Email { get; set; }

                        [NameInMap("Group")]
                        [Validation(Required=false)]
                        public List<string> Group { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>IT</para>
                        /// </summary>
                        [NameInMap("MatchedUserGroups")]
                        [Validation(Required=false)]
                        public string MatchedUserGroups { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>123456789</para>
                        /// </summary>
                        [NameInMap("Telephone")]
                        [Validation(Required=false)]
                        public string Telephone { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>zhangsan</para>
                        /// </summary>
                        [NameInMap("Username")]
                        [Validation(Required=false)]
                        public string Username { get; set; }

                    }

                    [NameInMap("ZeroTrustPolicyInfo")]
                    [Validation(Required=false)]
                    public GetPADiagnosisTaskResponseBodyDiagnosisTaskResultPolicyInfoZeroTrustPolicyInfo ZeroTrustPolicyInfo { get; set; }
                    public class GetPADiagnosisTaskResponseBodyDiagnosisTaskResultPolicyInfoZeroTrustPolicyInfo : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>block</para>
                        /// </summary>
                        [NameInMap("Action")]
                        [Validation(Required=false)]
                        public string Action { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>MyApp2</para>
                        /// </summary>
                        [NameInMap("AppName")]
                        [Validation(Required=false)]
                        public string AppName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>access denied</para>
                        /// </summary>
                        [NameInMap("BlockInfo")]
                        [Validation(Required=false)]
                        public string BlockInfo { get; set; }

                        [NameInMap("PolicyName")]
                        [Validation(Required=false)]
                        public string PolicyName { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UdpExtraConfigs")]
            [Validation(Required=false)]
            public GetPADiagnosisTaskResponseBodyDiagnosisTaskUdpExtraConfigs UdpExtraConfigs { get; set; }
            public class GetPADiagnosisTaskResponseBodyDiagnosisTaskUdpExtraConfigs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>hello</para>
                /// </summary>
                [NameInMap("ExpectedResponse")]
                [Validation(Required=false)]
                public string ExpectedResponse { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hello</para>
                /// </summary>
                [NameInMap("RequestContent")]
                [Validation(Required=false)]
                public string RequestContent { get; set; }

            }

            [NameInMap("UserGroup")]
            [Validation(Required=false)]
            public GetPADiagnosisTaskResponseBodyDiagnosisTaskUserGroup UserGroup { get; set; }
            public class GetPADiagnosisTaskResponseBodyDiagnosisTaskUserGroup : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ug-xxxxx</para>
                /// </summary>
                [NameInMap("UserGroupId")]
                [Validation(Required=false)]
                public string UserGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>IT</para>
                /// </summary>
                [NameInMap("UserGroupName")]
                [Validation(Required=false)]
                public string UserGroupName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zhangsan</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2CABFEBB-0CE7-575E-833A-266F75D46713</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
