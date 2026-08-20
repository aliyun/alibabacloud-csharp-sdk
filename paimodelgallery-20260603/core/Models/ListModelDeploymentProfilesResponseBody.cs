// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIModelGallery20260603.Models
{
    public class ListModelDeploymentProfilesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>model-6wiou4ta20tgtq9lda</para>
        /// </summary>
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("ModelVersion")]
        [Validation(Required=false)]
        public string ModelVersion { get; set; }

        [NameInMap("Profiles")]
        [Validation(Required=false)]
        public List<ListModelDeploymentProfilesResponseBodyProfiles> Profiles { get; set; }
        public class ListModelDeploymentProfilesResponseBodyProfiles : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>singlenode</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("Devices")]
            [Validation(Required=false)]
            public List<ListModelDeploymentProfilesResponseBodyProfilesDevices> Devices { get; set; }
            public class ListModelDeploymentProfilesResponseBodyProfilesDevices : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>NVIDIA</para>
                /// </summary>
                [NameInMap("DeviceCategory")]
                [Validation(Required=false)]
                public string DeviceCategory { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NVIDIA_L20C</para>
                /// </summary>
                [NameInMap("DeviceType")]
                [Validation(Required=false)]
                public string DeviceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>L20C</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("InstanceTypes")]
                [Validation(Required=false)]
                public List<string> InstanceTypes { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sglang</para>
            /// </summary>
            [NameInMap("Framework")]
            [Validation(Required=false)]
            public string Framework { get; set; }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public Dictionary<string, string> Labels { get; set; }

            [NameInMap("Members")]
            [Validation(Required=false)]
            public List<ListModelDeploymentProfilesResponseBodyProfilesMembers> Members { get; set; }
            public class ListModelDeploymentProfilesResponseBodyProfilesMembers : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Default</para>
                /// </summary>
                [NameInMap("MemberType")]
                [Validation(Required=false)]
                public string MemberType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{ &quot;script&quot;: &quot;sglang serve --disaggregation-mode decode&quot; }</para>
                /// </summary>
                [NameInMap("Meta")]
                [Validation(Required=false)]
                public Dictionary<string, object> Meta { get; set; }

            }

            [NameInMap("Optimizations")]
            [Validation(Required=false)]
            public Dictionary<string, string> Optimizations { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>prf_4f73b31ae****23f9a04c6e83ebc78f</para>
            /// </summary>
            [NameInMap("ProfileId")]
            [Validation(Required=false)]
            public string ProfileId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>singlenode-balanced</para>
            /// </summary>
            [NameInMap("Scenario")]
            [Validation(Required=false)]
            public string Scenario { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B6B54325-C98C-5937-87A3-2F96C07652EC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
