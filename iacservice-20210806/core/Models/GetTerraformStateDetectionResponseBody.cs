// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetTerraformStateDetectionResponseBody : TeaModel {
        [NameInMap("job")]
        [Validation(Required=false)]
        public GetTerraformStateDetectionResponseBodyJob Job { get; set; }
        public class GetTerraformStateDetectionResponseBodyJob : TeaModel {
            [NameInMap("changedResources")]
            [Validation(Required=false)]
            public List<GetTerraformStateDetectionResponseBodyJobChangedResources> ChangedResources { get; set; }
            public class GetTerraformStateDetectionResponseBodyJobChangedResources : TeaModel {
                [NameInMap("attributeChanges")]
                [Validation(Required=false)]
                public List<GetTerraformStateDetectionResponseBodyJobChangedResourcesAttributeChanges> AttributeChanges { get; set; }
                public class GetTerraformStateDetectionResponseBodyJobChangedResourcesAttributeChanges : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>vpc_name</para>
                    /// </summary>
                    [NameInMap("attributePath")]
                    [Validation(Required=false)]
                    public string AttributePath { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test_remote</para>
                    /// </summary>
                    [NameInMap("remoteValue")]
                    [Validation(Required=false)]
                    public string RemoteValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test_hcl</para>
                    /// </summary>
                    [NameInMap("templateValue")]
                    [Validation(Required=false)]
                    public string TemplateValue { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>create</para>
                /// </summary>
                [NameInMap("changedType")]
                [Validation(Required=false)]
                public string ChangedType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("hasDrift")]
                [Validation(Required=false)]
                public bool? HasDrift { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc-axxxxx</para>
                /// </summary>
                [NameInMap("resourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc:alicloud_vpc.default</para>
                /// </summary>
                [NameInMap("resourceIdentifier")]
                [Validation(Required=false)]
                public string ResourceIdentifier { get; set; }

            }

            [NameInMap("driftedResources")]
            [Validation(Required=false)]
            public List<GetTerraformStateDetectionResponseBodyJobDriftedResources> DriftedResources { get; set; }
            public class GetTerraformStateDetectionResponseBodyJobDriftedResources : TeaModel {
                [NameInMap("attributeDrifts")]
                [Validation(Required=false)]
                public List<GetTerraformStateDetectionResponseBodyJobDriftedResourcesAttributeDrifts> AttributeDrifts { get; set; }
                public class GetTerraformStateDetectionResponseBodyJobDriftedResourcesAttributeDrifts : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>vpc_name</para>
                    /// </summary>
                    [NameInMap("attributePath")]
                    [Validation(Required=false)]
                    public string AttributePath { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test_remote</para>
                    /// </summary>
                    [NameInMap("remoteValue")]
                    [Validation(Required=false)]
                    public string RemoteValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test_state</para>
                    /// </summary>
                    [NameInMap("stateValue")]
                    [Validation(Required=false)]
                    public string StateValue { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>update</para>
                /// </summary>
                [NameInMap("driftedType")]
                [Validation(Required=false)]
                public string DriftedType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc-bxxxxx</para>
                /// </summary>
                [NameInMap("resourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc:alicloud_vpc.default2</para>
                /// </summary>
                [NameInMap("resourceIdentifier")]
                [Validation(Required=false)]
                public string ResourceIdentifier { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>planned failed</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>stack-as181axxxxxx:development_xxxx</para>
            /// </summary>
            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Errored</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
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
