// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class GetAddonResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the addon.</para>
        /// </summary>
        [NameInMap("Addon")]
        [Validation(Required=false)]
        public GetAddonResponseBodyAddon Addon { get; set; }
        public class GetAddonResponseBodyAddon : TeaModel {
            /// <summary>
            /// <para>The addon ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Login-1.0-W2g****</para>
            /// </summary>
            [NameInMap("AddonId")]
            [Validation(Required=false)]
            public string AddonId { get; set; }

            /// <summary>
            /// <para>The addon description.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The addon icon.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/assets/icons/your_icon.svg</para>
            /// </summary>
            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <para>The time when the addon was installed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-08-22 18:11:17</para>
            /// </summary>
            [NameInMap("InstallTime")]
            [Validation(Required=false)]
            public string InstallTime { get; set; }

            /// <summary>
            /// <para>The addon label.</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>The addon name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Login</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The resource configurations of the addon.</para>
            /// </summary>
            [NameInMap("ResourcesSpec")]
            [Validation(Required=false)]
            public GetAddonResponseBodyAddonResourcesSpec ResourcesSpec { get; set; }
            public class GetAddonResponseBodyAddonResourcesSpec : TeaModel {
                /// <summary>
                /// <para>The Elastic Compute Service (ECS) resource configurations of the addon.</para>
                /// </summary>
                [NameInMap("EcsResources")]
                [Validation(Required=false)]
                public List<AddonNodeTemplate> EcsResources { get; set; }

                /// <summary>
                /// <para>The Elastic IP Address (EIP) configurations.</para>
                /// </summary>
                [NameInMap("EipResource")]
                [Validation(Required=false)]
                public GetAddonResponseBodyAddonResourcesSpecEipResource EipResource { get; set; }
                public class GetAddonResponseBodyAddonResourcesSpecEipResource : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the EIP is automatically created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>True</para>
                    /// </summary>
                    [NameInMap("AutoCreate")]
                    [Validation(Required=false)]
                    public bool? AutoCreate { get; set; }

                    /// <summary>
                    /// <para>The maximum bandwidth of the EIP. Unit: Mbit/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Bandwidth")]
                    [Validation(Required=false)]
                    public string Bandwidth { get; set; }

                    /// <summary>
                    /// <para>The EIP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>39.108.xx.xx</para>
                    /// </summary>
                    [NameInMap("EipAddress")]
                    [Validation(Required=false)]
                    public string EipAddress { get; set; }

                    /// <summary>
                    /// <para>The EIP ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eip-bp1vi9124tbx1g3kr****</para>
                    /// </summary>
                    [NameInMap("EipInstanceId")]
                    [Validation(Required=false)]
                    public string EipInstanceId { get; set; }

                    /// <summary>
                    /// <para>The billing method of the EIP.</para>
                    /// <list type="bullet">
                    /// <item><description>PostPaid: pay-as-you-go.</description></item>
                    /// <item><description>PrePaid: subscription.</description></item>
                    /// </list>
                    /// <para>Default value: PostPaid.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PostPaid</para>
                    /// </summary>
                    [NameInMap("InstanceChargeType")]
                    [Validation(Required=false)]
                    public string InstanceChargeType { get; set; }

                    /// <summary>
                    /// <para>The metering method of the EIP. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>PayByBandwidth: pay by bandwidth.</description></item>
                    /// <item><description>PayByTraffic: pay by data transfer.</description></item>
                    /// </list>
                    /// <para>Valid values of N: 1 to 10.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PayByTraffic</para>
                    /// </summary>
                    [NameInMap("InternetChargeType")]
                    [Validation(Required=false)]
                    public string InternetChargeType { get; set; }

                }

            }

            /// <summary>
            /// <para>The service configurations of the addon.</para>
            /// </summary>
            [NameInMap("ServicesSpec")]
            [Validation(Required=false)]
            public List<GetAddonResponseBodyAddonServicesSpec> ServicesSpec { get; set; }
            public class GetAddonResponseBodyAddonServicesSpec : TeaModel {
                /// <summary>
                /// <para>The parameter configurations of the service.</para>
                /// </summary>
                [NameInMap("InputParams")]
                [Validation(Required=false)]
                public List<GetAddonResponseBodyAddonServicesSpecInputParams> InputParams { get; set; }
                public class GetAddonResponseBodyAddonServicesSpecInputParams : TeaModel {
                    /// <summary>
                    /// <para>The help information of the parameter.</para>
                    /// </summary>
                    [NameInMap("HelpText")]
                    [Validation(Required=false)]
                    public string HelpText { get; set; }

                    /// <summary>
                    /// <para>The parameter label.</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The parameter name.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MYSQL_HOME</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The parameter type.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>String</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The parameter value.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>usr/local/mysql</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The security group configurations of the service.</para>
                /// </summary>
                [NameInMap("NetworkACL")]
                [Validation(Required=false)]
                public List<GetAddonResponseBodyAddonServicesSpecNetworkACL> NetworkACL { get; set; }
                public class GetAddonResponseBodyAddonServicesSpecNetworkACL : TeaModel {
                    /// <summary>
                    /// <para>The protocol type. Valid values:</para>
                    /// <para>TCP: forwards TCP packets.</para>
                    /// <para>UDP: forwards UDP packets.</para>
                    /// <para>Any: forwards all packets.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TCP</para>
                    /// </summary>
                    [NameInMap("IpProtocol")]
                    [Validation(Required=false)]
                    public string IpProtocol { get; set; }

                    /// <summary>
                    /// <para>The port number.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3306</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public float? Port { get; set; }

                    /// <summary>
                    /// <para>The source CIDR block.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>172.16.0.0/12</para>
                    /// </summary>
                    [NameInMap("SourceCidrIp")]
                    [Validation(Required=false)]
                    public string SourceCidrIp { get; set; }

                }

                /// <summary>
                /// <para>The service access type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>URL</para>
                /// </summary>
                [NameInMap("ServiceAccessType")]
                [Validation(Required=false)]
                public string ServiceAccessType { get; set; }

                /// <summary>
                /// <para>The service access URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://47.96.xx.xx:12008">https://47.96.xx.xx:12008</a></para>
                /// </summary>
                [NameInMap("ServiceAccessUrl")]
                [Validation(Required=false)]
                public string ServiceAccessUrl { get; set; }

                /// <summary>
                /// <para>The service name.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Web Portal</para>
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

            }

            /// <summary>
            /// <para>The addon status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The addon version.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BBC2F93D-003A-49C4-850C-B826EECF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
