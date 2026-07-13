// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class QueryFeaturesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryFeaturesResponseBodyData Data { get; set; }
        public class QueryFeaturesResponseBodyData : TeaModel {
            [NameInMap("Features")]
            [Validation(Required=false)]
            public List<QueryFeaturesResponseBodyDataFeatures> Features { get; set; }
            public class QueryFeaturesResponseBodyDataFeatures : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("FeatureCode")]
                [Validation(Required=false)]
                public string FeatureCode { get; set; }

                [NameInMap("Supported")]
                [Validation(Required=false)]
                public bool? Supported { get; set; }

                [NameInMap("UnsupportedReason")]
                [Validation(Required=false)]
                public string UnsupportedReason { get; set; }

                [NameInMap("UnsupportedReasonCode")]
                [Validation(Required=false)]
                public string UnsupportedReasonCode { get; set; }

            }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            [NameInMap("TargetScope")]
            [Validation(Required=false)]
            public string TargetScope { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
