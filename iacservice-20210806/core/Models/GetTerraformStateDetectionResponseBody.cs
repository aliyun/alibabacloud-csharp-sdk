// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetTerraformStateDetectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The job details.</para>
        /// </summary>
        [NameInMap("job")]
        [Validation(Required=false)]
        public GetTerraformStateDetectionResponseBodyJob Job { get; set; }
        public class GetTerraformStateDetectionResponseBodyJob : TeaModel {
            /// <summary>
            /// <para>The collection of resources with state changes.</para>
            /// </summary>
            [NameInMap("changedResources")]
            [Validation(Required=false)]
            public List<GetTerraformStateDetectionResponseBodyJobChangedResources> ChangedResources { get; set; }
            public class GetTerraformStateDetectionResponseBodyJobChangedResources : TeaModel {
                /// <summary>
                /// <para>The collection of attribute changes.</para>
                /// </summary>
                [NameInMap("attributeChanges")]
                [Validation(Required=false)]
                public List<GetTerraformStateDetectionResponseBodyJobChangedResourcesAttributeChanges> AttributeChanges { get; set; }
                public class GetTerraformStateDetectionResponseBodyJobChangedResourcesAttributeChanges : TeaModel {
                    /// <summary>
                    /// <para>The attribute name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc_name</para>
                    /// </summary>
                    [NameInMap("attributePath")]
                    [Validation(Required=false)]
                    public string AttributePath { get; set; }

                    /// <summary>
                    /// <para>The server-side state value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_remote</para>
                    /// </summary>
                    [NameInMap("remoteValue")]
                    [Validation(Required=false)]
                    public string RemoteValue { get; set; }

                    /// <summary>
                    /// <para>The value declared in the template.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_hcl</para>
                    /// </summary>
                    [NameInMap("templateValue")]
                    [Validation(Required=false)]
                    public string TemplateValue { get; set; }

                }

                /// <summary>
                /// <para>The change type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>create</para>
                /// </summary>
                [NameInMap("changedType")]
                [Validation(Required=false)]
                public string ChangedType { get; set; }

                /// <summary>
                /// <para>Indicates whether resource drift exists.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("hasDrift")]
                [Validation(Required=false)]
                public bool? HasDrift { get; set; }

                /// <summary>
                /// <para>The Terraform resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-axxxxx</para>
                /// </summary>
                [NameInMap("resourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The identifier of the resource in the Terraform template. The format is &lt;$componetName&gt;:&lt;$resourceName&gt; for stack tasks and &lt;$resourceName&gt; for tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc:alicloud_vpc.default</para>
                /// </summary>
                [NameInMap("resourceIdentifier")]
                [Validation(Required=false)]
                public string ResourceIdentifier { get; set; }

            }

            /// <summary>
            /// <para>The collection of resources with state drift.</para>
            /// </summary>
            [NameInMap("driftedResources")]
            [Validation(Required=false)]
            public List<GetTerraformStateDetectionResponseBodyJobDriftedResources> DriftedResources { get; set; }
            public class GetTerraformStateDetectionResponseBodyJobDriftedResources : TeaModel {
                /// <summary>
                /// <para>The collection of attribute drifts.</para>
                /// </summary>
                [NameInMap("attributeDrifts")]
                [Validation(Required=false)]
                public List<GetTerraformStateDetectionResponseBodyJobDriftedResourcesAttributeDrifts> AttributeDrifts { get; set; }
                public class GetTerraformStateDetectionResponseBodyJobDriftedResourcesAttributeDrifts : TeaModel {
                    /// <summary>
                    /// <para>The attribute name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc_name</para>
                    /// </summary>
                    [NameInMap("attributePath")]
                    [Validation(Required=false)]
                    public string AttributePath { get; set; }

                    /// <summary>
                    /// <para>The server-side state value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_remote</para>
                    /// </summary>
                    [NameInMap("remoteValue")]
                    [Validation(Required=false)]
                    public string RemoteValue { get; set; }

                    /// <summary>
                    /// <para>The value stored in the state file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_state</para>
                    /// </summary>
                    [NameInMap("stateValue")]
                    [Validation(Required=false)]
                    public string StateValue { get; set; }

                }

                /// <summary>
                /// <para>The drift type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>update</para>
                /// </summary>
                [NameInMap("driftedType")]
                [Validation(Required=false)]
                public string DriftedType { get; set; }

                /// <summary>
                /// <para>The Terraform resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bxxxxx</para>
                /// </summary>
                [NameInMap("resourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The identifier of the resource in the Terraform template. The format is &lt;$componetName&gt;:&lt;$resourceName&gt; for stack tasks and &lt;$resourceName&gt; for tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc:alicloud_vpc.default2</para>
                /// </summary>
                [NameInMap("resourceIdentifier")]
                [Validation(Required=false)]
                public string ResourceIdentifier { get; set; }

            }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>planned failed</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The job identifier. The format is &lt;$stackId&gt;:&lt;$deploymentName&gt; for stack tasks and &lt;$TaskId&gt; for tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stack-as181axxxxxx:development_xxxx</para>
            /// </summary>
            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// <para>The job status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: The initial state after the job is created.</description></item>
            /// <item><description>PlanQueued: The job is queued and waiting because no containers are available after creation.</description></item>
            /// <item><description>Planning: The resource job is in the plan execution phase.</description></item>
            /// <item><description>Planned: The resource job has completed plan execution.</description></item>
            /// <item><description>PlannedAndFinished: The job is in the final state because no differences are found after plan execution.</description></item>
            /// <item><description>Errored: The job has entered the final state due to an execution error.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Errored</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The job type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Stack</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6ED9F71-7FA8-598E-B64D-4606FB3FCCC9</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
