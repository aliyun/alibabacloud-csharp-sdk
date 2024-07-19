// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeBackendListResponseBody : TeaModel {
        /// <summary>
        /// The backend services.
        /// </summary>
        [NameInMap("BackendInfoList")]
        [Validation(Required=false)]
        public List<DescribeBackendListResponseBodyBackendInfoList> BackendInfoList { get; set; }
        public class DescribeBackendListResponseBodyBackendInfoList : TeaModel {
            /// <summary>
            /// The ID of the backend service.
            /// </summary>
            [NameInMap("BackendId")]
            [Validation(Required=false)]
            public string BackendId { get; set; }

            /// <summary>
            /// The name of the backend service.
            /// </summary>
            [NameInMap("BackendName")]
            [Validation(Required=false)]
            public string BackendName { get; set; }

            /// <summary>
            /// The type of the backend service.
            /// </summary>
            [NameInMap("BackendType")]
            [Validation(Required=false)]
            public string BackendType { get; set; }

            /// <summary>
            /// The time when the backend service was created.
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// The description of the backend service.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The time when the backend service was modified.
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// The list of tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeBackendListResponseBodyBackendInfoListTags> Tags { get; set; }
            public class DescribeBackendListResponseBodyBackendInfoListTags : TeaModel {
                /// <summary>
                /// The name of the tag.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the tag.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The number of the current page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
