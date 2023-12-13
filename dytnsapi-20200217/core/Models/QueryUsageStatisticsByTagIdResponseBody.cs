// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class QueryUsageStatisticsByTagIdResponseBody : TeaModel {
        /// <summary>
        /// The response code. **OK** indicates that the request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryUsageStatisticsByTagIdResponseBodyData> Data { get; set; }
        public class QueryUsageStatisticsByTagIdResponseBodyData : TeaModel {
            /// <summary>
            /// The authorization code.
            /// </summary>
            [NameInMap("AuthorizationCode")]
            [Validation(Required=false)]
            public string AuthorizationCode { get; set; }

            /// <summary>
            /// The numbers for which the query failed.
            /// </summary>
            [NameInMap("FailTotal")]
            [Validation(Required=false)]
            public long? FailTotal { get; set; }

            /// <summary>
            /// The creation time.
            /// </summary>
            [NameInMap("GmtDateStr")]
            [Validation(Required=false)]
            public string GmtDateStr { get; set; }

            /// <summary>
            /// The ID of the authorization code usage record.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The industry name.
            /// </summary>
            [NameInMap("IndustryName")]
            [Validation(Required=false)]
            public string IndustryName { get; set; }

            /// <summary>
            /// The customer product ID (PID).
            /// </summary>
            [NameInMap("PartnerId")]
            [Validation(Required=false)]
            public long? PartnerId { get; set; }

            /// <summary>
            /// The scene name.
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// The numbers for which the query succeeded.
            /// </summary>
            [NameInMap("SuccessTotal")]
            [Validation(Required=false)]
            public long? SuccessTotal { get; set; }

            /// <summary>
            /// The tag name.
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public long? TagId { get; set; }

            /// <summary>
            /// The tag name.
            /// </summary>
            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

            /// <summary>
            /// The total quantity of numbers that are involved in the query.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call is successful.
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
