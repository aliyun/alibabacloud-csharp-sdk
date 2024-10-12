// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListCustomViewPointsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>NoData</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCustomViewPointsResponseBodyData> Data { get; set; }
        public class ListCustomViewPointsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2323ac73e174428a98c91097a59c67e0</para>
            /// </summary>
            [NameInMap("AsyncTaskId")]
            [Validation(Required=false)]
            public string AsyncTaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>观点</para>
            /// </summary>
            [NameInMap("Attitude")]
            [Validation(Required=false)]
            public string Attitude { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-08-15 16:18:59</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>709806dd051042d5ab9de8bdbb3a64ca</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>参数校验失败</para>
            /// </summary>
            [NameInMap("TaskErrorMessage")]
            [Validation(Required=false)]
            public string TaskErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public int? TaskStatus { get; set; }

            [NameInMap("ViewPoints")]
            [Validation(Required=false)]
            public List<ListCustomViewPointsResponseBodyDataViewPoints> ViewPoints { get; set; }
            public class ListCustomViewPointsResponseBodyDataViewPoints : TeaModel {
                [NameInMap("Outlines")]
                [Validation(Required=false)]
                public List<ListCustomViewPointsResponseBodyDataViewPointsOutlines> Outlines { get; set; }
                public class ListCustomViewPointsResponseBodyDataViewPointsOutlines : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>大纲</para>
                    /// </summary>
                    [NameInMap("Outline")]
                    [Validation(Required=false)]
                    public string Outline { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>大纲摘要</para>
                    /// </summary>
                    [NameInMap("Summary")]
                    [Validation(Required=false)]
                    public string Summary { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>视角</para>
                /// </summary>
                [NameInMap("Point")]
                [Validation(Required=false)]
                public string Point { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>摘要</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>下一页的token</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>73</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
