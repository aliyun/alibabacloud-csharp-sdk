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
        /// <para>The HTTP API deployment configuration.</para>
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
            /// <para>The route IDs.</para>
            /// </summary>
            [NameInMap("routeIds")]
            [Validation(Required=false)]
            public List<string> RouteIds { get; set; }

        }

        /// <summary>
        /// <para>The REST API deployment configuration. This parameter is required when the HTTP API being published is a REST API. At least one of revisionId, environment, or gatewayId must be provided to specify the publish target.</para>
        /// </summary>
        [NameInMap("restApiConfig")]
        [Validation(Required=false)]
        public DeployHttpApiRequestRestApiConfig RestApiConfig { get; set; }
        public class DeployHttpApiRequestRestApiConfig : TeaModel {
            /// <summary>
            /// <para>The publish description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>User service API publish</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable REST API route compression. If this parameter is omitted or set to false, operations are published individually. If set to true, the API is published as a single prefix route. This field is ignored for historical revision publishing, which uses the route mode saved in the historical revision. When set to true, operationDeployments must not be specified because prefix route publishing supports only full publishing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableRouteCompression")]
            [Validation(Required=false)]
            public bool? EnableRouteCompression { get; set; }

            /// <summary>
            /// <para>The publish environment configuration.</para>
            /// </summary>
            [NameInMap("environment")]
            [Validation(Required=false)]
            public DeployHttpApiRequestRestApiConfigEnvironment Environment { get; set; }
            public class DeployHttpApiRequestRestApiConfigEnvironment : TeaModel {
                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>The API publish scenario. Backend configurations cannot be specified during publishing. Configure them in advance by using UpdateHttpApi or UpdateHttpApiOperation before publishing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SingleService</para>
                /// </summary>
                [NameInMap("backendScene")]
                [Validation(Required=false)]
                [Obsolete]
                public string BackendScene { get; set; }

                /// <summary>
                /// <para>The list of custom domain names.</para>
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
                /// <para>The existing service configurations. In the single-service scenario, only one entry is allowed. In ratio-based or content-based scenarios, multiple entries are allowed. Backend configurations cannot be specified during publishing. Configure them in advance by using UpdateHttpApi or UpdateHttpApiOperation before publishing.</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("serviceConfigs")]
                [Validation(Required=false)]
                [Obsolete]
                public List<DeployHttpApiRequestRestApiConfigEnvironmentServiceConfigs> ServiceConfigs { get; set; }
                public class DeployHttpApiRequestRestApiConfigEnvironmentServiceConfigs : TeaModel {
                    /// <summary>
                    /// <para>The match condition configuration related to API publishing.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{\&quot;change_order_revision\&quot;:\&quot;3.657.33_fc-hz-yunqi.1662568293908382_faas-eerouter\&quot;}</para>
                    /// </summary>
                    [NameInMap("match")]
                    [Validation(Required=false)]
                    public HttpApiBackendMatchConditions Match { get; set; }

                    /// <summary>
                    /// <para>The service port. Do not specify this parameter for dynamic ports.</para>
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
                    /// <para>The service version.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v1</para>
                    /// </summary>
                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                    /// <summary>
                    /// <para>The weight. Valid values: 1 to 100. This parameter takes effect only in the ratio-based scenario.</para>
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
            /// <para>The operation-level deployment control list. This parameter takes effect only when enableRouteCompression is omitted or set to false. This field must not be specified when enableRouteCompression is set to true.</para>
            /// </summary>
            [NameInMap("operationDeployments")]
            [Validation(Required=false)]
            public List<DeployHttpApiRequestRestApiConfigOperationDeployments> OperationDeployments { get; set; }
            public class DeployHttpApiRequestRestApiConfigOperationDeployments : TeaModel {
                /// <summary>
                /// <para>The action type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Publish</para>
                /// </summary>
                [NameInMap("action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The unique identifier of the operation.</para>
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
            /// <para>The operation IDs.</para>
            /// </summary>
            [NameInMap("operationIds")]
            [Validation(Required=false)]
            [Obsolete]
            public List<string> OperationIds { get; set; }

            /// <summary>
            /// <para>The historical revision ID. If this field is specified, the publish information is based on the historical revision.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apr-xxx</para>
            /// </summary>
            [NameInMap("revisionId")]
            [Validation(Required=false)]
            public string RevisionId { get; set; }

        }

        /// <summary>
        /// <para>The route ID. This parameter is required when publishing a route of an HTTP API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hr-cr82undlhtgrl***</para>
        /// </summary>
        [NameInMap("routeId")]
        [Validation(Required=false)]
        public string RouteId { get; set; }

    }

}
