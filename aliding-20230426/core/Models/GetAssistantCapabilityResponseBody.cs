// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetAssistantCapabilityResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>助理描述</para>
        /// </summary>
        [NameInMap("assistantDescription")]
        [Validation(Required=false)]
        public string AssistantDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("canHandle")]
        [Validation(Required=false)]
        public bool? CanHandle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("capabilityAssessment")]
        [Validation(Required=false)]
        public GetAssistantCapabilityResponseBodyCapabilityAssessment CapabilityAssessment { get; set; }
        public class GetAssistantCapabilityResponseBodyCapabilityAssessment : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>能力概览</para>
            /// </summary>
            [NameInMap("briefCapability")]
            [Validation(Required=false)]
            public string BriefCapability { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("capabilityList")]
            [Validation(Required=false)]
            public List<GetAssistantCapabilityResponseBodyCapabilityAssessmentCapabilityList> CapabilityList { get; set; }
            public class GetAssistantCapabilityResponseBodyCapabilityAssessmentCapabilityList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>能力概览</para>
                /// </summary>
                [NameInMap("capabilityOverview")]
                [Validation(Required=false)]
                public string CapabilityOverview { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>能力描述</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("metadata")]
                [Validation(Required=false)]
                public Dictionary<string, object> Metadata { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>能力名称</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>id1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>requestId</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
