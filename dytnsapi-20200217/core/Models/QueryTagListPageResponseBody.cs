// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class QueryTagListPageResponseBody : TeaModel {
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
        public QueryTagListPageResponseBodyData Data { get; set; }
        public class QueryTagListPageResponseBodyData : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// The retruned data.
            /// </summary>
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<QueryTagListPageResponseBodyDataRecords> Records { get; set; }
            public class QueryTagListPageResponseBodyDataRecords : TeaModel {
                /// <summary>
                /// The API operation that is called by the frontend.
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// Code
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The URL for the API documentation.
                /// </summary>
                [NameInMap("DocAddress")]
                [Validation(Required=false)]
                public string DocAddress { get; set; }

                /// <summary>
                /// The tag ID.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The industry ID.
                /// </summary>
                [NameInMap("IndustryId")]
                [Validation(Required=false)]
                public long? IndustryId { get; set; }

                /// <summary>
                /// The industry name.
                /// </summary>
                [NameInMap("IndustryName")]
                [Validation(Required=false)]
                public string IndustryName { get; set; }

                /// <summary>
                /// The tag description.
                /// </summary>
                [NameInMap("Introduction")]
                [Validation(Required=false)]
                public string Introduction { get; set; }

                /// <summary>
                /// Indicates whether the number is activated.
                /// </summary>
                [NameInMap("IsOpen")]
                [Validation(Required=false)]
                public long? IsOpen { get; set; }

                /// <summary>
                /// The tag name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// *   0: The number is hidden.
                /// *   1: The number is public.
                /// </summary>
                [NameInMap("SaleStatusStr")]
                [Validation(Required=false)]
                public string SaleStatusStr { get; set; }

                /// <summary>
                /// The scene ID.
                /// </summary>
                [NameInMap("SceneId")]
                [Validation(Required=false)]
                public long? SceneId { get; set; }

                /// <summary>
                /// The scene name.
                /// </summary>
                [NameInMap("SceneName")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

            }

            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            /// <summary>
            /// The total number of returned pages.
            /// </summary>
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public long? TotalPage { get; set; }

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
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
