// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class DeployHttpApiRequest : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>httpApiConfig</para>
        /// </summary>
        [NameInMap("httpApiConfig")]
        [Validation(Required=false)]
        [Obsolete]
        public DeployHttpApiRequestHttpApiConfig HttpApiConfig { get; set; }
        public class DeployHttpApiRequestHttpApiConfig : TeaModel {
            /// <summary>
            /// <para>The gateway ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-csrhgfmm1hknf0hu6o3g</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <para>routeIds</para>
            /// </summary>
            [NameInMap("routeIds")]
            [Validation(Required=false)]
            public List<string> RouteIds { get; set; }

        }

        /// <summary>
        /// <para>The REST API deployment configuration. This parameter is required when you publish a REST API.</para>
        /// </summary>
        [NameInMap("restApiConfig")]
        [Validation(Required=false)]
        public DeployHttpApiRequestRestApiConfig RestApiConfig { get; set; }
        public class DeployHttpApiRequestRestApiConfig : TeaModel {
            /// <summary>
            /// <para>The publish description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The user service API</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The environment configurations.</para>
            /// </summary>
            [NameInMap("environment")]
            [Validation(Required=false)]
            public DeployHttpApiRequestRestApiConfigEnvironment Environment { get; set; }
            public class DeployHttpApiRequestRestApiConfigEnvironment : TeaModel {
                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>The publishing scenario.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SingleService</description></item>
                /// <item><description>MultiServiceByRatio</description></item>
                /// <item><description>MultiServiceByContent</description></item>
                /// <item><description>Mock</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SingleService</para>
                /// </summary>
                [NameInMap("backendScene")]
                [Validation(Required=false)]
                [Obsolete]
                public string BackendScene { get; set; }

                /// <summary>
                /// <para>The custom domain names.</para>
                /// </summary>
                [NameInMap("customDomainIds")]
                [Validation(Required=false)]
                public List<string> CustomDomainIds { get; set; }

                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>The environment ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env-cpqnr6tlhtgubc***</para>
                /// </summary>
                [NameInMap("environmentId")]
                [Validation(Required=false)]
                [Obsolete]
                public string EnvironmentId { get; set; }

                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>The configurations of existing services. For single-service publishing, only one entry is allowed. For other scenarios, multiple entries are allowed.</para>
                /// </summary>
                [NameInMap("serviceConfigs")]
                [Validation(Required=false)]
                [Obsolete]
                public List<DeployHttpApiRequestRestApiConfigEnvironmentServiceConfigs> ServiceConfigs { get; set; }
                public class DeployHttpApiRequestRestApiConfigEnvironmentServiceConfigs : TeaModel {
                    /// <summary>
                    /// <para>The matching condition configurations related to API publishing.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{\&quot;change_order_revision\&quot;:\&quot;3.657.33_fc-hz-yunqi.1662568293908382_faas-eerouter\&quot;}</para>
                    /// </summary>
                    [NameInMap("match")]
                    [Validation(Required=false)]
                    public HttpApiBackendMatchConditions Match { get; set; }

                    /// <summary>
                    /// <para>The service port. If you want to use a dynamic port, do not pass this parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8080</para>
                    /// </summary>
                    [NameInMap("port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The service protocol. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>HTTP</description></item>
                    /// <item><description>HTTPS</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTTP</para>
                    /// </summary>
                    [NameInMap("protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// <para>The service ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>svc-cr6pk4tlhtgm58e***</para>
                    /// </summary>
                    [NameInMap("serviceId")]
                    [Validation(Required=false)]
                    public string ServiceId { get; set; }

                    /// <summary>
                    /// <para>The version of the microservice.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v1</para>
                    /// </summary>
                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                    /// <summary>
                    /// <para>The weight. Valid values: [1,100]. This parameter is valid only in proportional routing.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>49</para>
                    /// </summary>
                    [NameInMap("weight")]
                    [Validation(Required=false)]
                    public int? Weight { get; set; }

                }

            }

            /// <summary>
            /// <para>The gateway ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-cvn2u46m1hkun04oll8g</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <para>Operation-level deployment control list</para>
            /// </summary>
            [NameInMap("operationDeployments")]
            [Validation(Required=false)]
            public List<DeployHttpApiRequestRestApiConfigOperationDeployments> OperationDeployments { get; set; }
            public class DeployHttpApiRequestRestApiConfigOperationDeployments : TeaModel {
                /// <summary>
                /// <para>Operation type</para>
                /// 
                /// <b>Example:</b>
                /// <para>Publish</para>
                /// </summary>
                [NameInMap("action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>Unique identifier of the operation</para>
                /// 
                /// <b>Example:</b>
                /// <para>op-xxx</para>
                /// </summary>
                [NameInMap("operationId")]
                [Validation(Required=false)]
                public string OperationId { get; set; }

            }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>operationIds</para>
            /// </summary>
            [NameInMap("operationIds")]
            [Validation(Required=false)]
            [Obsolete]
            public List<string> OperationIds { get; set; }

            /// <summary>
            /// <para>The historical version of the API. If you specify this parameter, the corresponding version of the API is published.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apr-xxx</para>
            /// </summary>
            [NameInMap("revisionId")]
            [Validation(Required=false)]
            public string RevisionId { get; set; }

        }

        /// <summary>
        /// <para>The route ID. You must specify this parameter when you publish an HTTP API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hr-cr82undlhtgrl***</para>
        /// </summary>
        [NameInMap("routeId")]
        [Validation(Required=false)]
        public string RouteId { get; set; }

    }

}
