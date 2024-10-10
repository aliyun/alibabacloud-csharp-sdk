// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDatasetListResponseBody : TeaModel {
        /// <summary>
        /// <para>The keyword used to search for the dataset name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Test dataset</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryDatasetListResponseBodyResult Result { get; set; }
        public class QueryDatasetListResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Returns the pagination results of the dataset list. The detailed information of the dataset list is stored in the response parameter Data.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryDatasetListResponseBodyResultData> Data { get; set; }
            public class QueryDatasetListResponseBodyResultData : TeaModel {
                /// <summary>
                /// <para>The details of the dataset list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-11-02 10:36:05</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Test Space</para>
                /// </summary>
                [NameInMap("DataSource")]
                [Validation(Required=false)]
                public QueryDatasetListResponseBodyResultDataDataSource DataSource { get; set; }
                public class QueryDatasetListResponseBodyResultDataDataSource : TeaModel {
                    /// <summary>
                    /// <para>The ID of the training dataset that you want to remove from the specified custom linguistic model.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>261b252d-c3c3-498a-a0a7-5d1ec6cd****</para>
                    /// </summary>
                    [NameInMap("DsId")]
                    [Validation(Required=false)]
                    public string DsId { get; set; }

                    /// <summary>
                    /// <para>The time when the scaling group was modified.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The name of the training dataset.</para>
                    /// </summary>
                    [NameInMap("DsName")]
                    [Validation(Required=false)]
                    public string DsName { get; set; }

                    /// <summary>
                    /// <para>The user ID of the dataset owner in the Quick BI.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mysql</para>
                    /// </summary>
                    [NameInMap("DsType")]
                    [Validation(Required=false)]
                    public string DsType { get; set; }

                }

                /// <summary>
                /// <para>The name of the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5820f58c-c734-4d8a-baf1-7979af4f****</para>
                /// </summary>
                [NameInMap("DatasetId")]
                [Validation(Required=false)]
                public string DatasetId { get; set; }

                /// <summary>
                /// <para>Tom</para>
                /// 
                /// <b>Example:</b>
                /// <para>company_sales_record_copy12</para>
                /// </summary>
                [NameInMap("DatasetName")]
                [Validation(Required=false)]
                public string DatasetName { get; set; }

                /// <summary>
                /// <para>The number of rows per page set when the interface is requested.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The total number of rows in the table.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The information about the data source to which the dataset belongs.</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public QueryDatasetListResponseBodyResultDataDirectory Directory { get; set; }
                public class QueryDatasetListResponseBodyResultDataDirectory : TeaModel {
                    /// <summary>
                    /// <para>The ID of the directory path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>schemaad8aad00-9c55-4984-a767-b4e0ec60****</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The ID of the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Information about the directory where the dataset is located</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The type of the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>schemaad8aad00-9c55-4984-a767-b4e0ec60****</para>
                    /// </summary>
                    [NameInMap("PathId")]
                    [Validation(Required=false)]
                    public string PathId { get; set; }

                    /// <summary>
                    /// <para>The name of the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Test a data source</para>
                    /// </summary>
                    [NameInMap("PathName")]
                    [Validation(Required=false)]
                    public string PathName { get; set; }

                }

                /// <summary>
                /// <para>The nickname of the dataset owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-11-02 10:36:05</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                [NameInMap("OpenOfflineAcceleration")]
                [Validation(Required=false)]
                public bool? OpenOfflineAcceleration { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>136516262323****</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                /// <summary>
                /// <para>Whether to enable row-level permissions. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The VIP Netty channel is enabled.</description></item>
                /// <item><description>false: The incremental log backup feature is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>The ID of the workspace.</para>
                /// </summary>
                [NameInMap("OwnerName")]
                [Validation(Required=false)]
                public string OwnerName { get; set; }

                /// <summary>
                /// <para>The total number of pages returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("RowLevel")]
                [Validation(Required=false)]
                public bool? RowLevel { get; set; }

                /// <summary>
                /// <para>The page number of the returned page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>95296e95-ca89-4c7d-8af9-dedf0ad06adf</para>
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                /// <summary>
                /// <para>The description of the dataset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test dataset</para>
                /// </summary>
                [NameInMap("WorkspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }

            }

            /// <summary>
            /// <para>The number of rows per page in a paged query.</para>
            /// <list type="bullet">
            /// <item><description>Default value: 10.</description></item>
            /// <item><description>Maximum value: 1,000.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>Indicates whether the request is successful. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The request was successful.</description></item>
            /// <item><description>false: The request failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The ID of the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

            /// <summary>
            /// <para>Current page number for dataset list:</para>
            /// <list type="bullet">
            /// <item><description>Pages start from page 1.</description></item>
            /// <item><description>Default value: 1.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// <para>Whether to recursively wrap the dataset in the subdirectory. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: returns datasets in all recursive subdirectories in the directoryId directory.</description></item>
        /// <item><description>false: Only datasets in the directory specified by directoryId are returned, excluding subdirectories.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
