// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetRoutineResponseBody : TeaModel {
        /// <summary>
        /// <para>The creation time of the edge function Routine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-11T01:23:21Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The default domain name for accessing the Routine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>routine1.example.com</para>
        /// </summary>
        [NameInMap("DefaultRelatedRecord")]
        [Validation(Required=false)]
        public string DefaultRelatedRecord { get; set; }

        /// <summary>
        /// <para>The description of the edge function Routine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZWRpdCByb3V0aW5lIGNvbmZpZyBkZXNjcmlwdGlvbg</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>A list of environments.</para>
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public List<GetRoutineResponseBodyEnvs> Envs { get; set; }
        public class GetRoutineResponseBodyEnvs : TeaModel {
            /// <summary>
            /// <para>Details of the canary release for a code version.</para>
            /// </summary>
            [NameInMap("CodeDeploy")]
            [Validation(Required=false)]
            public GetRoutineResponseBodyEnvsCodeDeploy CodeDeploy { get; set; }
            public class GetRoutineResponseBodyEnvsCodeDeploy : TeaModel {
                /// <summary>
                /// <para>A list of deployed code versions.</para>
                /// </summary>
                [NameInMap("CodeVersions")]
                [Validation(Required=false)]
                public List<GetRoutineResponseBodyEnvsCodeDeployCodeVersions> CodeVersions { get; set; }
                public class GetRoutineResponseBodyEnvsCodeDeployCodeVersions : TeaModel {
                    /// <summary>
                    /// <para>The code version ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1746583193971399525</para>
                    /// </summary>
                    [NameInMap("CodeVersion")]
                    [Validation(Required=false)]
                    public string CodeVersion { get; set; }

                    /// <summary>
                    /// <para>The creation time of the code version.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-07-23T09:01:40Z</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <para>The description of the code version.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>code version 1.</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The percentage of traffic routed to this code version.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Percentage")]
                    [Validation(Required=false)]
                    public long? Percentage { get; set; }

                }

                /// <summary>
                /// <para>The time the deployment was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-05-11T09:21:36Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The deployment ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>589267</para>
                /// </summary>
                [NameInMap("DeployId")]
                [Validation(Required=false)]
                public string DeployId { get; set; }

                /// <summary>
                /// <para>The deployment strategy. The default value is <c>percentage</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>percentage</para>
                /// </summary>
                [NameInMap("Strategy")]
                [Validation(Required=false)]
                public string Strategy { get; set; }

            }

            /// <summary>
            /// <para>The environment name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>production</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the Routine includes Assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HasAssets")]
        [Validation(Required=false)]
        public bool? HasAssets { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EDBD3EB3-97DA-5465-AEF5-8DCA5DC5E395</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
