// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoBuildRecordResponseBody : TeaModel {
        /// <summary>
        /// The list of image building records.
        /// </summary>
        [NameInMap("BuildRecords")]
        [Validation(Required=false)]
        public List<ListRepoBuildRecordResponseBodyBuildRecords> BuildRecords { get; set; }
        public class ListRepoBuildRecordResponseBodyBuildRecords : TeaModel {
            /// <summary>
            /// The ID of the image building record.
            /// </summary>
            [NameInMap("BuildRecordId")]
            [Validation(Required=false)]
            public string BuildRecordId { get; set; }

            /// <summary>
            /// The status of the image building.
            /// </summary>
            [NameInMap("BuildStatus")]
            [Validation(Required=false)]
            public string BuildStatus { get; set; }

            /// <summary>
            /// The time when the image building ended.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The information about the image.
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public ListRepoBuildRecordResponseBodyBuildRecordsImage Image { get; set; }
            public class ListRepoBuildRecordResponseBodyBuildRecordsImage : TeaModel {
                /// <summary>
                /// The tag of the image.
                /// </summary>
                [NameInMap("ImageTag")]
                [Validation(Required=false)]
                public string ImageTag { get; set; }

                /// <summary>
                /// The ID of the repository.
                /// </summary>
                [NameInMap("RepoId")]
                [Validation(Required=false)]
                public string RepoId { get; set; }

                /// <summary>
                /// The name of the repository.
                /// </summary>
                [NameInMap("RepoName")]
                [Validation(Required=false)]
                public string RepoName { get; set; }

                /// <summary>
                /// The name of the namespace to which the repository belongs.
                /// </summary>
                [NameInMap("RepoNamespaceName")]
                [Validation(Required=false)]
                public string RepoNamespaceName { get; set; }

            }

            /// <summary>
            /// The time when the image building started.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// The return value.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   `true`: The request is successful.
        /// *   `false`: The request fails.
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// The number of entries returned per page.
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
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
