// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListStackConfigsResponseBody : TeaModel {
        [NameInMap("configs")]
        [Validation(Required=false)]
        public List<ListStackConfigsResponseBodyConfigs> Configs { get; set; }
        public class ListStackConfigsResponseBodyConfigs : TeaModel {
            [NameInMap("componentConfig")]
            [Validation(Required=false)]
            public ListStackConfigsResponseBodyConfigsComponentConfig ComponentConfig { get; set; }
            public class ListStackConfigsResponseBodyConfigsComponentConfig : TeaModel {
                [NameInMap("component")]
                [Validation(Required=false)]
                public List<ListStackConfigsResponseBodyConfigsComponentConfigComponent> Component { get; set; }
                public class ListStackConfigsResponseBodyConfigsComponentConfigComponent : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>log</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("output")]
                [Validation(Required=false)]
                public List<ListStackConfigsResponseBodyConfigsComponentConfigOutput> Output { get; set; }
                public class ListStackConfigsResponseBodyConfigsComponentConfigOutput : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>the name of sls project</para>
                    /// </summary>
                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>project_name</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>string</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>log-test</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("variable")]
                [Validation(Required=false)]
                public List<ListStackConfigsResponseBodyConfigsComponentConfigVariable> Variable { get; set; }
                public class ListStackConfigsResponseBodyConfigsComponentConfigVariable : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ap-southeast-3</para>
                    /// </summary>
                    [NameInMap("default")]
                    [Validation(Required=false)]
                    public string Default { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>region of sls project</para>
                    /// </summary>
                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>region</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>string</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>format_version: IaCService/2021-08-06\ndescription: create ALB \nvariable:\n  - name: region\n    type: string\n ...</para>
            /// </summary>
            [NameInMap("componentContent")]
            [Validation(Required=false)]
            public string ComponentContent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-08-15T16:14:06Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("deploymentConfig")]
            [Validation(Required=false)]
            public ListStackConfigsResponseBodyConfigsDeploymentConfig DeploymentConfig { get; set; }
            public class ListStackConfigsResponseBodyConfigsDeploymentConfig : TeaModel {
                [NameInMap("deployment")]
                [Validation(Required=false)]
                public List<ListStackConfigsResponseBodyConfigsDeploymentConfigDeployment> Deployment { get; set; }
                public class ListStackConfigsResponseBodyConfigsDeploymentConfigDeployment : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>production</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("publishOutput")]
                [Validation(Required=false)]
                public List<ListStackConfigsResponseBodyConfigsDeploymentConfigPublishOutput> PublishOutput { get; set; }
                public class ListStackConfigsResponseBodyConfigsDeploymentConfigPublishOutput : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>the name of sls project</para>
                    /// </summary>
                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>project_name</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>log-test</para>
                    /// </summary>
                    [NameInMap("result")]
                    [Validation(Required=false)]
                    public string Result { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>string</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>deployment.production.project_name</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("upstreamInput")]
                [Validation(Required=false)]
                public List<ListStackConfigsResponseBodyConfigsDeploymentConfigUpstreamInput> UpstreamInput { get; set; }
                public class ListStackConfigsResponseBodyConfigsDeploymentConfigUpstreamInput : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>network</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>IacEndpoint/156718871222312/stack_network</para>
                    /// </summary>
                    [NameInMap("source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>format_version: IaCService/2021-08-06\ndescription: create ALB\nupstream_input:\n  - name: stack_network\n ...</para>
            /// </summary>
            [NameInMap("deploymentContent")]
            [Validation(Required=false)]
            public string DeploymentContent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Deployed</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jIFUaFVhy2VD6whh5GaY854dD+2BRJj42DLT6GrZysw=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9BEDBCF8-03BE-5A59-AC93-9263942B37E8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>43</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
