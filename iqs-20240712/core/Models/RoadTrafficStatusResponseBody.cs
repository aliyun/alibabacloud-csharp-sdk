// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20240712.Models
{
    public class RoadTrafficStatusResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<RoadTrafficStatusResponseBodyData> Data { get; set; }
        public class RoadTrafficStatusResponseBodyData : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("evaluation")]
            [Validation(Required=false)]
            public RoadTrafficStatusResponseBodyDataEvaluation Evaluation { get; set; }
            public class RoadTrafficStatusResponseBodyDataEvaluation : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0.00%</para>
                /// </summary>
                [NameInMap("blockedPercentage")]
                [Validation(Required=false)]
                public string BlockedPercentage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100.00%</para>
                /// </summary>
                [NameInMap("clearPercentage")]
                [Validation(Required=false)]
                public string ClearPercentage { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.00%</para>
                /// </summary>
                [NameInMap("heavyPercentage")]
                [Validation(Required=false)]
                public string HeavyPercentage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.00%</para>
                /// </summary>
                [NameInMap("unknownPercentage")]
                [Validation(Required=false)]
                public string UnknownPercentage { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>504 gateway error</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECB2144C-E277-5434-80E6-12D26678D364</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
