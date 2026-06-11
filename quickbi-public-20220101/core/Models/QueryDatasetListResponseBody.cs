// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDatasetListResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The paged results of the dataset list. The details of the datasets are returned in the Data parameter.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryDatasetListResponseBodyResult Result { get; set; }
        public class QueryDatasetListResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The details of the dataset list.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryDatasetListResponseBodyResultData> Data { get; set; }
            public class QueryDatasetListResponseBodyResultData : TeaModel {
                /// <summary>
                /// <para>The time when the dataset was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-11-02 10:36:05</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The information about the data source to which the dataset belongs.</para>
                /// </summary>
                [NameInMap("DataSource")]
                [Validation(Required=false)]
                public QueryDatasetListResponseBodyResultDataDataSource DataSource { get; set; }
                public class QueryDatasetListResponseBodyResultDataDataSource : TeaModel {
                    /// <summary>
                    /// <para>The data source ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>261b252d-c3c3-498a-a0a7-5d1ec6cd****</para>
                    /// </summary>
                    [NameInMap("DsId")]
                    [Validation(Required=false)]
                    public string DsId { get; set; }

                    /// <summary>
                    /// <para>The data source name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("DsName")]
                    [Validation(Required=false)]
                    public string DsName { get; set; }

                    /// <summary>
                    /// <para>The data source type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mysql</para>
                    /// </summary>
                    [NameInMap("DsType")]
                    [Validation(Required=false)]
                    public string DsType { get; set; }

                }

                /// <summary>
                /// <para>The dataset ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5820f58c-c734-4d8a-baf1-7979af4f****</para>
                /// </summary>
                [NameInMap("DatasetId")]
                [Validation(Required=false)]
                public string DatasetId { get; set; }

                /// <summary>
                /// <para>The dataset name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>company_sales_record_copy12</para>
                /// </summary>
                [NameInMap("DatasetName")]
                [Validation(Required=false)]
                public string DatasetName { get; set; }

                /// <summary>
                /// <para>The description of the dataset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The information about the folder in which the dataset is located.</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public QueryDatasetListResponseBodyResultDataDirectory Directory { get; set; }
                public class QueryDatasetListResponseBodyResultDataDirectory : TeaModel {
                    /// <summary>
                    /// <para>The folder ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>schemaad8aad00-9c55-4984-a767-b4e0ec60****</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The folder name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The ID of the folder path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>schemaad8aad00-9c55-4984-a767-b4e0ec60****</para>
                    /// </summary>
                    [NameInMap("PathId")]
                    [Validation(Required=false)]
                    public string PathId { get; set; }

                    /// <summary>
                    /// <para>The name of the folder path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("PathName")]
                    [Validation(Required=false)]
                    public string PathName { get; set; }

                }

                /// <summary>
                /// <para>The time when the dataset was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-11-02 10:36:05</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <para>Indicates whether extraction-based acceleration is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: Enabled</para>
                /// </description></item>
                /// <item><description><para>false: Disabled</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("OpenOfflineAcceleration")]
                [Validation(Required=false)]
                public bool? OpenOfflineAcceleration { get; set; }

                /// <summary>
                /// <para>The user ID of the dataset owner in Quick BI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>136516262323****</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                /// <summary>
                /// <para>The nickname of the dataset owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("OwnerName")]
                [Validation(Required=false)]
                public string OwnerName { get; set; }

                /// <summary>
                /// <para>Indicates whether row-level permissions are enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: Enabled</para>
                /// </description></item>
                /// <item><description><para>false: Disabled</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("RowLevel")]
                [Validation(Required=false)]
                public bool? RowLevel { get; set; }

                /// <summary>
                /// <para>The workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>95296e95-ca89-4c7d-8af9-dedf0ad06adf</para>
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                /// <summary>
                /// <para>The workspace name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("WorkspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries per page specified in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The request failed.</para>
        /// </description></item>
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
