// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDataServiceListResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>78C1AA2D-9201-599E-A0BA-6FC462E57A95</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryDataServiceListResponseBodyResult Result { get; set; }
        public class QueryDataServiceListResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The data service information.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryDataServiceListResponseBodyResultData> Data { get; set; }
            public class QueryDataServiceListResponseBodyResultData : TeaModel {
                /// <summary>
                /// <para>The model of the data service in JSON format.</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public QueryDataServiceListResponseBodyResultDataContent Content { get; set; }
                public class QueryDataServiceListResponseBodyResultDataContent : TeaModel {
                    /// <summary>
                    /// <para>The cube ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>56f9f34a-bdba-496a-91a3-a18b1ff73a80</para>
                    /// </summary>
                    [NameInMap("CubeId")]
                    [Validation(Required=false)]
                    public string CubeId { get; set; }

                    /// <summary>
                    /// <para>The name of the dataset.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Test dataset</para>
                    /// </summary>
                    [NameInMap("CubeName")]
                    [Validation(Required=false)]
                    public string CubeName { get; set; }

                    /// <summary>
                    /// <para>The detail or aggregate type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Detail")]
                    [Validation(Required=false)]
                    public bool? Detail { get; set; }

                    /// <summary>
                    /// <para>The request parameter information.</para>
                    /// </summary>
                    [NameInMap("Filter")]
                    [Validation(Required=false)]
                    public QueryDataServiceListResponseBodyResultDataContentFilter Filter { get; set; }
                    public class QueryDataServiceListResponseBodyResultDataContentFilter : TeaModel {
                        /// <summary>
                        /// <para>The combined conditions.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>[{
                        ///     &quot;field&quot;: {
                        ///         &quot;fid&quot;: &quot;1c1f88cb7d&quot;,
                        ///         &quot;granularity&quot;: &quot;yearRegion&quot;,
                        ///         &quot;dataType&quot;: &quot;datetime&quot;,
                        ///         &quot;column&quot;: &quot;s_date&quot;,
                        ///         &quot;caption&quot;: &quot;Date (year)&quot;,
                        ///         &quot;type&quot;: &quot;dimension&quot;
                        ///     },
                        ///     &quot;defaultValue&quot;: [&quot;2024&quot;],
                        ///     &quot;alias&quot;: &quot;s_date&quot;,
                        ///     &quot;type&quot;: &quot;basic&quot;,
                        ///     &quot;operator&quot;: &quot;equal-to&quot;,
                        ///     &quot;essential&quot;: true
                        /// }]</para>
                        /// </summary>
                        [NameInMap("Filters")]
                        [Validation(Required=false)]
                        public List<Dictionary<string, object>> Filters { get; set; }

                        /// <summary>
                        /// <para>The logical relationship between multiple SQL text keywords.</para>
                        /// <list type="bullet">
                        /// <item><description><b>or</b>: OR.</description></item>
                        /// <item><description><b>and</b>: AND.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>and</para>
                        /// </summary>
                        [NameInMap("LogicalOperator")]
                        [Validation(Required=false)]
                        public string LogicalOperator { get; set; }

                        /// <summary>
                        /// <para>The type.</para>
                        /// <list type="bullet">
                        /// <item><description>basic: Basic.</description></item>
                        /// <item><description>combined: Complex.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>basic</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The returned information.</para>
                    /// </summary>
                    [NameInMap("ReturnFields")]
                    [Validation(Required=false)]
                    public List<QueryDataServiceListResponseBodyResultDataContentReturnFields> ReturnFields { get; set; }
                    public class QueryDataServiceListResponseBodyResultDataContentReturnFields : TeaModel {
                        /// <summary>
                        /// <para>The aggregate operation (aggregation), such as SUM, AVG, and MAX.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SUM</para>
                        /// </summary>
                        [NameInMap("Aggregator")]
                        [Validation(Required=false)]
                        public string Aggregator { get; set; }

                        /// <summary>
                        /// <para>The field parameter name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>s_number</para>
                        /// </summary>
                        [NameInMap("Alias")]
                        [Validation(Required=false)]
                        public string Alias { get; set; }

                        /// <summary>
                        /// <para>The description of the returned field.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>The theme configuration already exists</para>
                        /// </summary>
                        [NameInMap("Desc")]
                        [Validation(Required=false)]
                        public string Desc { get; set; }

                        /// <summary>
                        /// <para>The corresponding cube field information.</para>
                        /// </summary>
                        [NameInMap("Field")]
                        [Validation(Required=false)]
                        public QueryDataServiceListResponseBodyResultDataContentReturnFieldsField Field { get; set; }
                        public class QueryDataServiceListResponseBodyResultDataContentReturnFieldsField : TeaModel {
                            /// <summary>
                            /// <para>The display name in the cube model, which can be in Chinese or English.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Date (year)</para>
                            /// </summary>
                            [NameInMap("Caption")]
                            [Validation(Required=false)]
                            public string Caption { get; set; }

                            /// <summary>
                            /// <para>The corresponding physical field name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>shid_star</para>
                            /// </summary>
                            [NameInMap("Column")]
                            [Validation(Required=false)]
                            public string Column { get; set; }

                            /// <summary>
                            /// <para>The data type.</para>
                            /// <list type="bullet">
                            /// <item><description>number: Number.</description></item>
                            /// <item><description>string: String.</description></item>
                            /// <item><description>date: Date.</description></item>
                            /// <item><description>datetime: Datetime.</description></item>
                            /// <item><description>time: Time.</description></item>
                            /// <item><description>geographic: Geographic.</description></item>
                            /// <item><description>boolean: Boolean.</description></item>
                            /// <item><description>url: URL.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>datetime</para>
                            /// </summary>
                            [NameInMap("DataType")]
                            [Validation(Required=false)]
                            public string DataType { get; set; }

                            /// <summary>
                            /// <para>The unique ID of the original field.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1c1f88cb7d</para>
                            /// </summary>
                            [NameInMap("Fid")]
                            [Validation(Required=false)]
                            public string Fid { get; set; }

                            /// <summary>
                            /// <para>The supported granularity. This property is included in date and geographic dimensions.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>yearRegion</para>
                            /// </summary>
                            [NameInMap("Granularity")]
                            [Validation(Required=false)]
                            public string Granularity { get; set; }

                            /// <summary>
                            /// <para>The unique name of the cube field, which is primarily used to uniquely locate the returned result.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>sss</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <para>The type.</para>
                            /// <list type="bullet">
                            /// <item><description>Dimension: Dimension.</description></item>
                            /// <item><description>Measure: Measure.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>dimension</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                        /// <summary>
                        /// <para>The sort order.</para>
                        /// <list type="bullet">
                        /// <item><description>asc: Ascending.</description></item>
                        /// <item><description>desc: Descending.</description></item>
                        /// <item><description>no: Unsorted.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>no</para>
                        /// </summary>
                        [NameInMap("Orderby")]
                        [Validation(Required=false)]
                        public string Orderby { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7cb94cd48701</para>
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// <para>The name of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhang Zilong</para>
                /// </summary>
                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                /// <summary>
                /// <para>The cube ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d14e7448-0eb3-40d3-9375-4afef8de29fd</para>
                /// </summary>
                [NameInMap("CubeId")]
                [Validation(Required=false)]
                public string CubeId { get; set; }

                /// <summary>
                /// <para>The name of the dataset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test dataset</para>
                /// </summary>
                [NameInMap("CubeName")]
                [Validation(Required=false)]
                public string CubeName { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>For testing</para>
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-05-18 14:00:02.0</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-03-21 18:02:36</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The user ID of the modifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7cb94cd48701</para>
                /// </summary>
                [NameInMap("ModifierId")]
                [Validation(Required=false)]
                public string ModifierId { get; set; }

                /// <summary>
                /// <para>The name of the modifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhang Zilong</para>
                /// </summary>
                [NameInMap("ModifierName")]
                [Validation(Required=false)]
                public string ModifierName { get; set; }

                /// <summary>
                /// <para>The service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test report</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>862801339</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                /// <summary>
                /// <para>The name of the owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Li Si</para>
                /// </summary>
                [NameInMap("OwnerName")]
                [Validation(Required=false)]
                public string OwnerName { get; set; }

                /// <summary>
                /// <para>The unique ID of the data service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dtsuq3i31f5j8v848b</para>
                /// </summary>
                [NameInMap("Sid")]
                [Validation(Required=false)]
                public string Sid { get; set; }

                /// <summary>
                /// <para>The workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7350a155-0e94-4c6c-8620-57bbec38****</para>
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                /// <summary>
                /// <para>The name of the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test workspace</para>
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
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of rows.</para>
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
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
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
