// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDatasetListResponseBody : TeaModel {
        /// <summary>
        /// The keyword used to search for the dataset name.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Test dataset
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryDatasetListResponseBodyResult Result { get; set; }
        public class QueryDatasetListResponseBodyResult : TeaModel {
            /// <summary>
            /// Returns the pagination results of the dataset list. The detailed information of the dataset list is stored in the response parameter Data.
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryDatasetListResponseBodyResultData> Data { get; set; }
            public class QueryDatasetListResponseBodyResultData : TeaModel {
                /// <summary>
                /// The details of the dataset list.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// Test Space
                /// </summary>
                [NameInMap("DataSource")]
                [Validation(Required=false)]
                public QueryDatasetListResponseBodyResultDataDataSource DataSource { get; set; }
                public class QueryDatasetListResponseBodyResultDataDataSource : TeaModel {
                    /// <summary>
                    /// The ID of the training dataset that you want to remove from the specified custom linguistic model.
                    /// </summary>
                    [NameInMap("DsId")]
                    [Validation(Required=false)]
                    public string DsId { get; set; }

                    /// <summary>
                    /// The time when the scaling group was modified.
                    /// </summary>
                    [NameInMap("DsName")]
                    [Validation(Required=false)]
                    public string DsName { get; set; }

                    /// <summary>
                    /// The user ID of the dataset owner in the Quick BI.
                    /// </summary>
                    [NameInMap("DsType")]
                    [Validation(Required=false)]
                    public string DsType { get; set; }

                }

                /// <summary>
                /// The name of the workspace.
                /// </summary>
                [NameInMap("DatasetId")]
                [Validation(Required=false)]
                public string DatasetId { get; set; }

                /// <summary>
                /// Tom
                /// </summary>
                [NameInMap("DatasetName")]
                [Validation(Required=false)]
                public string DatasetName { get; set; }

                /// <summary>
                /// The number of rows per page set when the interface is requested.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The information about the data source to which the dataset belongs.
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public QueryDatasetListResponseBodyResultDataDirectory Directory { get; set; }
                public class QueryDatasetListResponseBodyResultDataDirectory : TeaModel {
                    /// <summary>
                    /// The ID of the directory path.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// The ID of the data source.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The type of the data source.
                    /// </summary>
                    [NameInMap("PathId")]
                    [Validation(Required=false)]
                    public string PathId { get; set; }

                    /// <summary>
                    /// The name of the data source.
                    /// </summary>
                    [NameInMap("PathName")]
                    [Validation(Required=false)]
                    public string PathName { get; set; }

                }

                /// <summary>
                /// The nickname of the dataset owner.
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// The creation time.
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                /// <summary>
                /// Whether to enable row-level permissions. Valid values:
                /// 
                /// *   true: The VIP Netty channel is enabled.
                /// *   false: The incremental log backup feature is disabled.
                /// </summary>
                [NameInMap("OwnerName")]
                [Validation(Required=false)]
                public string OwnerName { get; set; }

                /// <summary>
                /// The total number of pages returned.
                /// </summary>
                [NameInMap("RowLevel")]
                [Validation(Required=false)]
                public bool? RowLevel { get; set; }

                /// <summary>
                /// The page number of the returned page.
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                /// <summary>
                /// The description of the dataset.
                /// </summary>
                [NameInMap("WorkspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }

            }

            /// <summary>
            /// The number of rows per page in a paged query.
            /// 
            /// *   Default value: 10.
            /// *   Maximum value: 1,000.
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// Indicates whether the request is successful. Valid values:
            /// 
            /// *   true: The request was successful.
            /// *   false: The request failed.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

            /// <summary>
            /// Current page number for dataset list:
            /// 
            /// *   Pages start from page 1.
            /// *   Default value: 1.
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// Whether to recursively wrap the dataset in the subdirectory. Valid values:
        /// 
        /// *   true: returns datasets in all recursive subdirectories in the directoryId directory.
        /// *   false: Only datasets in the directory specified by directoryId are returned, excluding subdirectories.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
