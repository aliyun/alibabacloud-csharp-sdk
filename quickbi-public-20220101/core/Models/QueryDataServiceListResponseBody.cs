// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDataServiceListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>78C1AA2D-9201-599E-A0BA-6FC462E57A95</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryDataServiceListResponseBodyResult Result { get; set; }
        public class QueryDataServiceListResponseBodyResult : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryDataServiceListResponseBodyResultData> Data { get; set; }
            public class QueryDataServiceListResponseBodyResultData : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public QueryDataServiceListResponseBodyResultDataContent Content { get; set; }
                public class QueryDataServiceListResponseBodyResultDataContent : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>56f9f34a-bdba-496a-91a3-a18b1ff73a80</para>
                    /// </summary>
                    [NameInMap("CubeId")]
                    [Validation(Required=false)]
                    public string CubeId { get; set; }

                    [NameInMap("CubeName")]
                    [Validation(Required=false)]
                    public string CubeName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Detail")]
                    [Validation(Required=false)]
                    public bool? Detail { get; set; }

                    [NameInMap("Filter")]
                    [Validation(Required=false)]
                    public QueryDataServiceListResponseBodyResultDataContentFilter Filter { get; set; }
                    public class QueryDataServiceListResponseBodyResultDataContentFilter : TeaModel {
                        [NameInMap("Filters")]
                        [Validation(Required=false)]
                        public List<Dictionary<string, object>> Filters { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>and</para>
                        /// </summary>
                        [NameInMap("LogicalOperator")]
                        [Validation(Required=false)]
                        public string LogicalOperator { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>basic</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("ReturnFields")]
                    [Validation(Required=false)]
                    public List<QueryDataServiceListResponseBodyResultDataContentReturnFields> ReturnFields { get; set; }
                    public class QueryDataServiceListResponseBodyResultDataContentReturnFields : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>SUM</para>
                        /// </summary>
                        [NameInMap("Aggregator")]
                        [Validation(Required=false)]
                        public string Aggregator { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>s_number</para>
                        /// </summary>
                        [NameInMap("Alias")]
                        [Validation(Required=false)]
                        public string Alias { get; set; }

                        [NameInMap("Desc")]
                        [Validation(Required=false)]
                        public string Desc { get; set; }

                        [NameInMap("Field")]
                        [Validation(Required=false)]
                        public QueryDataServiceListResponseBodyResultDataContentReturnFieldsField Field { get; set; }
                        public class QueryDataServiceListResponseBodyResultDataContentReturnFieldsField : TeaModel {
                            [NameInMap("Caption")]
                            [Validation(Required=false)]
                            public string Caption { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>shid_star</para>
                            /// </summary>
                            [NameInMap("Column")]
                            [Validation(Required=false)]
                            public string Column { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>datetime</para>
                            /// </summary>
                            [NameInMap("DataType")]
                            [Validation(Required=false)]
                            public string DataType { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1c1f88cb7d</para>
                            /// </summary>
                            [NameInMap("Fid")]
                            [Validation(Required=false)]
                            public string Fid { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>yearRegion</para>
                            /// </summary>
                            [NameInMap("Granularity")]
                            [Validation(Required=false)]
                            public string Granularity { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>sss</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>dimension</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>no</para>
                        /// </summary>
                        [NameInMap("Orderby")]
                        [Validation(Required=false)]
                        public string Orderby { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7cb94cd48701</para>
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>d14e7448-0eb3-40d3-9375-4afef8de29fd</para>
                /// </summary>
                [NameInMap("CubeId")]
                [Validation(Required=false)]
                public string CubeId { get; set; }

                [NameInMap("CubeName")]
                [Validation(Required=false)]
                public string CubeName { get; set; }

                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-05-18 14:00:02.0</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-03-21 18:02:36</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7cb94cd48701</para>
                /// </summary>
                [NameInMap("ModifierId")]
                [Validation(Required=false)]
                public string ModifierId { get; set; }

                [NameInMap("ModifierName")]
                [Validation(Required=false)]
                public string ModifierName { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>862801339</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                [NameInMap("OwnerName")]
                [Validation(Required=false)]
                public string OwnerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dtsuq3i31f5j8v848b</para>
                /// </summary>
                [NameInMap("Sid")]
                [Validation(Required=false)]
                public string Sid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7350a155-0e94-4c6c-8620-57bbec38****</para>
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                [NameInMap("WorkspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
