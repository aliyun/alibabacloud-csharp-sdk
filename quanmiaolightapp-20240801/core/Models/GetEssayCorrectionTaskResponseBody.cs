// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class GetEssayCorrectionTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetEssayCorrectionTaskResponseBodyData Data { get; set; }
        public class GetEssayCorrectionTaskResponseBodyData : TeaModel {
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("results")]
            [Validation(Required=false)]
            public List<GetEssayCorrectionTaskResponseBodyDataResults> Results { get; set; }
            public class GetEssayCorrectionTaskResponseBodyDataResults : TeaModel {
                /// <summary>
                /// <para>xxx</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("customId")]
                [Validation(Required=false)]
                public string CustomId { get; set; }

                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>58</para>
                /// </summary>
                [NameInMap("score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                [NameInMap("usage")]
                [Validation(Required=false)]
                public ModelUsage Usage { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PENDING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("totalUsage")]
            [Validation(Required=false)]
            public ModelUsage TotalUsage { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>117F5ABE-CF02-5502-9A3F-E56BC9081A64</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
