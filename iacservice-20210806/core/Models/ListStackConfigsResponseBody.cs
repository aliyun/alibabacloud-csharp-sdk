// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListStackConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of stack configurations.</para>
        /// </summary>
        [NameInMap("configs")]
        [Validation(Required=false)]
        public List<ListStackConfigsResponseBodyConfigs> Configs { get; set; }
        public class ListStackConfigsResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <para>The component configuration.</para>
            /// </summary>
            [NameInMap("componentConfig")]
            [Validation(Required=false)]
            public ListStackConfigsResponseBodyConfigsComponentConfig ComponentConfig { get; set; }
            public class ListStackConfigsResponseBodyConfigsComponentConfig : TeaModel {
                /// <summary>
                /// <para>The list of components.</para>
                /// </summary>
                [NameInMap("component")]
                [Validation(Required=false)]
                public List<ListStackConfigsResponseBodyConfigsComponentConfigComponent> Component { get; set; }
                public class ListStackConfigsResponseBodyConfigsComponentConfigComponent : TeaModel {
                    /// <summary>
                    /// <para>The component name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>log</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The list of component outputs.</para>
                /// </summary>
                [NameInMap("output")]
                [Validation(Required=false)]
                public List<ListStackConfigsResponseBodyConfigsComponentConfigOutput> Output { get; set; }
                public class ListStackConfigsResponseBodyConfigsComponentConfigOutput : TeaModel {
                    /// <summary>
                    /// <para>The output description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>the name of sls project</para>
                    /// </summary>
                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The output name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>project_name</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The output type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>string</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The output value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>log-test</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The list of component variables.</para>
                /// </summary>
                [NameInMap("variable")]
                [Validation(Required=false)]
                public List<ListStackConfigsResponseBodyConfigsComponentConfigVariable> Variable { get; set; }
                public class ListStackConfigsResponseBodyConfigsComponentConfigVariable : TeaModel {
                    /// <summary>
                    /// <para>The default value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ap-southeast-3</para>
                    /// </summary>
                    [NameInMap("default")]
                    [Validation(Required=false)]
                    public string Default { get; set; }

                    /// <summary>
                    /// <para>The description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>region of sls project</para>
                    /// </summary>
                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The variable name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>region</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("sensitive")]
                    [Validation(Required=false)]
                    public bool? Sensitive { get; set; }

                    /// <summary>
                    /// <para>The variable type, such as:</para>
                    /// <list type="bullet">
                    /// <item><description>string</description></item>
                    /// <item><description>list(string)</description></item>
                    /// <item><description>map(string).</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>string</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>The content of the component configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>format_version: IaCService/2021-08-06\ndescription: create ALB \nvariable:\n  - name: region\n    type: string\n ...</para>
            /// </summary>
            [NameInMap("componentContent")]
            [Validation(Required=false)]
            public string ComponentContent { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-08-15T16:14:06Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The deployment configuration.</para>
            /// </summary>
            [NameInMap("deploymentConfig")]
            [Validation(Required=false)]
            public ListStackConfigsResponseBodyConfigsDeploymentConfig DeploymentConfig { get; set; }
            public class ListStackConfigsResponseBodyConfigsDeploymentConfig : TeaModel {
                /// <summary>
                /// <para>The list of deployments.</para>
                /// </summary>
                [NameInMap("deployment")]
                [Validation(Required=false)]
                public List<ListStackConfigsResponseBodyConfigsDeploymentConfigDeployment> Deployment { get; set; }
                public class ListStackConfigsResponseBodyConfigsDeploymentConfigDeployment : TeaModel {
                    /// <summary>
                    /// <para>The deployment name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>production</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The list of outputs.</para>
                /// </summary>
                [NameInMap("publishOutput")]
                [Validation(Required=false)]
                public List<ListStackConfigsResponseBodyConfigsDeploymentConfigPublishOutput> PublishOutput { get; set; }
                public class ListStackConfigsResponseBodyConfigsDeploymentConfigPublishOutput : TeaModel {
                    /// <summary>
                    /// <para>The output description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>the name of sls project</para>
                    /// </summary>
                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The output name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>project_name</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The actual output value after the stack deployment is complete.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>log-test</para>
                    /// </summary>
                    [NameInMap("result")]
                    [Validation(Required=false)]
                    public string Result { get; set; }

                    /// <summary>
                    /// <para>The output type, such as string or list(string).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>string</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The original definition of the output value. Currently, string or list(string) is supported. You can reference a deployment output in the format: deployment.{deploymentName}.{deploymentOutputName}.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>deployment.production.project_name</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The list of upstream inputs.</para>
                /// </summary>
                [NameInMap("upstreamInput")]
                [Validation(Required=false)]
                public List<ListStackConfigsResponseBodyConfigsDeploymentConfigUpstreamInput> UpstreamInput { get; set; }
                public class ListStackConfigsResponseBodyConfigsDeploymentConfigUpstreamInput : TeaModel {
                    /// <summary>
                    /// <para>The input name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>network</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The input source. Currently, only an upstream stack can be specified. The format is {iacEndpoint}/{accountId}/{upstreamStackName}.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>IacEndpoint/156718871222312/stack_network</para>
                    /// </summary>
                    [NameInMap("source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                }

            }

            /// <summary>
            /// <para>The content of the deployment configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>format_version: IaCService/2021-08-06\ndescription: create ALB\nupstream_input:\n  - name: stack_network\n ...</para>
            /// </summary>
            [NameInMap("deploymentContent")]
            [Validation(Required=false)]
            public string DeploymentContent { get; set; }

            [NameInMap("failedReason")]
            [Validation(Required=false)]
            public string FailedReason { get; set; }

            /// <summary>
            /// <para>The status of the stack configuration.</para>
            /// <table>
            /// <thead>
            /// <tr>
            /// <th>Name</th>
            /// <th>Description</th>
            /// </tr>
            /// </thead>
            /// <tbody><tr>
            /// <td>Creating</td>
            /// <td>Being created.</td>
            /// </tr>
            /// <tr>
            /// <td>Created</td>
            /// <td>Created.</td>
            /// </tr>
            /// <tr>
            /// <td>Waiting</td>
            /// <td>Waiting for deployment.</td>
            /// </tr>
            /// <tr>
            /// <td>Deploying</td>
            /// <td>Being deployed.</td>
            /// </tr>
            /// <tr>
            /// <td>Deployed</td>
            /// <td>Deployed.</td>
            /// </tr>
            /// <tr>
            /// <td>Errored</td>
            /// <td>Deployment failed.</td>
            /// </tr>
            /// <tr>
            /// <td>Deleting</td>
            /// <td>Being deleted.</td>
            /// </tr>
            /// <tr>
            /// <td>Deleted</td>
            /// <td>Deleted.</td>
            /// </tr>
            /// <tr>
            /// <td>DeleteFailed</td>
            /// <td>Deletion failed.</td>
            /// </tr>
            /// <tr>
            /// <td>DetectTriggered</td>
            /// <td>Drift detection triggered.</td>
            /// </tr>
            /// </tbody></table>
            /// 
            /// <b>Example:</b>
            /// <para>Deployed</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The configuration version number, such as v1. The initial value is v1. The version number increments each time the stack is updated or refreshed and the configuration changes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records returned in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The position from which the current call starts reading. An empty value indicates that all data has been read.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jIFUaFVhy2VD6whh5GaY854dD+2BRJj42DLT6GrZysw=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9BEDBCF8-03BE-5A59-AC93-9263942B37E8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records that match the request conditions. This parameter is optional and may not be returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>43</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
