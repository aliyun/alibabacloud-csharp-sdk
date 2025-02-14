// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class DeployHttpApiRequest : TeaModel {
        [NameInMap("restApiConfig")]
        [Validation(Required=false)]
        public DeployHttpApiRequestRestApiConfig RestApiConfig { get; set; }
        public class DeployHttpApiRequestRestApiConfig : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("environment")]
            [Validation(Required=false)]
            public DeployHttpApiRequestRestApiConfigEnvironment Environment { get; set; }
            public class DeployHttpApiRequestRestApiConfigEnvironment : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>SingleService</para>
                /// </summary>
                [NameInMap("backendScene")]
                [Validation(Required=false)]
                public string BackendScene { get; set; }

                [NameInMap("customDomainIds")]
                [Validation(Required=false)]
                public List<string> CustomDomainIds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>env-cpqnr6tlhtgubc***</para>
                /// </summary>
                [NameInMap("environmentId")]
                [Validation(Required=false)]
                public string EnvironmentId { get; set; }

                [NameInMap("serviceConfigs")]
                [Validation(Required=false)]
                public List<DeployHttpApiRequestRestApiConfigEnvironmentServiceConfigs> ServiceConfigs { get; set; }
                public class DeployHttpApiRequestRestApiConfigEnvironmentServiceConfigs : TeaModel {
                    [NameInMap("match")]
                    [Validation(Required=false)]
                    public HttpApiBackendMatchConditions Match { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>8080</para>
                    /// </summary>
                    [NameInMap("port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HTTP</para>
                    /// </summary>
                    [NameInMap("protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>svc-cr6pk4tlhtgm58e***</para>
                    /// </summary>
                    [NameInMap("serviceId")]
                    [Validation(Required=false)]
                    public string ServiceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>v1</para>
                    /// </summary>
                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>49</para>
                    /// </summary>
                    [NameInMap("weight")]
                    [Validation(Required=false)]
                    public int? Weight { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>apr-xxx</para>
            /// </summary>
            [NameInMap("revisionId")]
            [Validation(Required=false)]
            public string RevisionId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hr-cr82undlhtgrl***</para>
        /// </summary>
        [NameInMap("routeId")]
        [Validation(Required=false)]
        public string RouteId { get; set; }

    }

}
