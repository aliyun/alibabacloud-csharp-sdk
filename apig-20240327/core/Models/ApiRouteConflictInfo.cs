// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ApiRouteConflictInfo : TeaModel {
        /// <summary>
        /// <para>The list of conflict information.</para>
        /// </summary>
        [NameInMap("conflicts")]
        [Validation(Required=false)]
        public List<ApiRouteConflictInfoConflicts> Conflicts { get; set; }
        public class ApiRouteConflictInfoConflicts : TeaModel {
            /// <summary>
            /// <para>The list of conflict details.</para>
            /// </summary>
            [NameInMap("details")]
            [Validation(Required=false)]
            public List<ApiRouteConflictInfoConflictsDetails> Details { get; set; }
            public class ApiRouteConflictInfoConflictsDetails : TeaModel {
                /// <summary>
                /// <para>The matching rule information of the conflicting target.</para>
                /// </summary>
                [NameInMap("conflictingMatch")]
                [Validation(Required=false)]
                public ApiRouteConflictInfoConflictsDetailsConflictingMatch ConflictingMatch { get; set; }
                public class ApiRouteConflictInfoConflictsDetailsConflictingMatch : TeaModel {
                    /// <summary>
                    /// <para>The matching rule.</para>
                    /// </summary>
                    [NameInMap("match")]
                    [Validation(Required=false)]
                    public HttpRouteMatch Match { get; set; }

                    /// <summary>
                    /// <para>When the conflicting target is an API, this indicates the corresponding operation information.</para>
                    /// </summary>
                    [NameInMap("operationInfo")]
                    [Validation(Required=false)]
                    public ApiRouteConflictInfoConflictsDetailsConflictingMatchOperationInfo OperationInfo { get; set; }
                    public class ApiRouteConflictInfoConflictsDetailsConflictingMatchOperationInfo : TeaModel {
                        /// <summary>
                        /// <para>The operation name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>GetItem</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The operation ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>op-cq35jadlhtgrv07***</para>
                        /// </summary>
                        [NameInMap("operationId")]
                        [Validation(Required=false)]
                        public string OperationId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The matching rule information of the detected target.</para>
                /// </summary>
                [NameInMap("detectedMatch")]
                [Validation(Required=false)]
                public ApiRouteConflictInfoConflictsDetailsDetectedMatch DetectedMatch { get; set; }
                public class ApiRouteConflictInfoConflictsDetailsDetectedMatch : TeaModel {
                    /// <summary>
                    /// <para>The matching rule information of the detected target.</para>
                    /// </summary>
                    [NameInMap("match")]
                    [Validation(Required=false)]
                    public HttpRouteMatch Match { get; set; }

                    /// <summary>
                    /// <para>When the detected target is an API, the conflicting operation information is returned.</para>
                    /// </summary>
                    [NameInMap("operationInfo")]
                    [Validation(Required=false)]
                    public ApiRouteConflictInfoConflictsDetailsDetectedMatchOperationInfo OperationInfo { get; set; }
                    public class ApiRouteConflictInfoConflictsDetailsDetectedMatchOperationInfo : TeaModel {
                        /// <summary>
                        /// <para>The operation name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>GetItemV2</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The operation ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>op-cqf17dllhtgng1m**</para>
                        /// </summary>
                        [NameInMap("operationId")]
                        [Validation(Required=false)]
                        public string OperationId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The conflict level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Critical</para>
                /// </description></item>
                /// <item><description><para>Warning</para>
                /// </description></item>
                /// <item><description><para>Informational</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Critical</para>
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

            }

            /// <summary>
            /// <para>For an API, the conflict exists in a specific environment. If the conflicting object is a route, this field is ignored.</para>
            /// </summary>
            [NameInMap("environmentInfo")]
            [Validation(Required=false)]
            public ApiRouteConflictInfoConflictsEnvironmentInfo EnvironmentInfo { get; set; }
            public class ApiRouteConflictInfoConflictsEnvironmentInfo : TeaModel {
                /// <summary>
                /// <para>The environment ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env-cquqsollhtgidd***</para>
                /// </summary>
                [NameInMap("environmentId")]
                [Validation(Required=false)]
                public string EnvironmentId { get; set; }

                /// <summary>
                /// <para>The environment name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>itemcenter-dev</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The conflicting resource ID, which is the API ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api-crdclqllhtggm***</para>
            /// </summary>
            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The conflicting resource name, which is the API name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>item-stock</para>
            /// </summary>
            [NameInMap("resourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// <para>The conflicting resource type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RestApi</description></item>
            /// <item><description>HttpApiRoute</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HttpApiRoute</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The route information.</para>
            /// </summary>
            [NameInMap("routeInfo")]
            [Validation(Required=false)]
            public ApiRouteConflictInfoConflictsRouteInfo RouteInfo { get; set; }
            public class ApiRouteConflictInfoConflictsRouteInfo : TeaModel {
                /// <summary>
                /// <para>The route name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>itemcenter-route</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The route ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hr-cr82undlhtgrlej***</para>
                /// </summary>
                [NameInMap("routeId")]
                [Validation(Required=false)]
                public string RouteId { get; set; }

            }

        }

        /// <summary>
        /// <para>The conflicting domain information.</para>
        /// </summary>
        [NameInMap("domainInfo")]
        [Validation(Required=false)]
        public ApiRouteConflictInfoDomainInfo DomainInfo { get; set; }
        public class ApiRouteConflictInfoDomainInfo : TeaModel {
            /// <summary>
            /// <para>The domain ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-cqookcllhtgvof7e***</para>
            /// </summary>
            [NameInMap("domainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>httpbin</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
