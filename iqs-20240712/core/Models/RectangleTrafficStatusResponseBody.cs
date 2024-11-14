// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20240712.Models
{
    public class RectangleTrafficStatusResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<RectangleTrafficStatusResponseBodyData> Data { get; set; }
        public class RectangleTrafficStatusResponseBodyData : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("evaluation")]
            [Validation(Required=false)]
            public RectangleTrafficStatusResponseBodyDataEvaluation Evaluation { get; set; }
            public class RectangleTrafficStatusResponseBodyDataEvaluation : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0.00%</para>
                /// </summary>
                [NameInMap("blockedPercentage")]
                [Validation(Required=false)]
                public string BlockedPercentage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30.77%</para>
                /// </summary>
                [NameInMap("clearPercentage")]
                [Validation(Required=false)]
                public string ClearPercentage { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7.59%</para>
                /// </summary>
                [NameInMap("heavyPercentage")]
                [Validation(Required=false)]
                public string HeavyPercentage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>61.45%</para>
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
        /// <para>Access was denied</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>78032F8B-0157-53F9-B1A8-3BD86ADE38D0</para>
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
