// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListWebReviewPointsResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoData</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Business Data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListWebReviewPointsResponseBodyData> Data { get; set; }
        public class ListWebReviewPointsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Current viewpoint</para>
            /// 
            /// <b>Example:</b>
            /// <para>当前观点</para>
            /// </summary>
            [NameInMap("Attitude")]
            [Validation(Required=false)]
            public string Attitude { get; set; }

            /// <summary>
            /// <para>Viewpoint type</para>
            /// 
            /// <b>Example:</b>
            /// <para>观点类型</para>
            /// </summary>
            [NameInMap("AttitudeType")]
            [Validation(Required=false)]
            public string AttitudeType { get; set; }

            /// <summary>
            /// <para>List of user opinions</para>
            /// </summary>
            [NameInMap("Comments")]
            [Validation(Required=false)]
            public List<ListWebReviewPointsResponseBodyDataComments> Comments { get; set; }
            public class ListWebReviewPointsResponseBodyDataComments : TeaModel {
                /// <summary>
                /// <para>Source</para>
                /// 
                /// <b>Example:</b>
                /// <para>来源</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>Content</para>
                /// 
                /// <b>Example:</b>
                /// <para>内容</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>title</para>
                /// 
                /// <b>Example:</b>
                /// <para>标题</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>Current URL</para>
                /// 
                /// <b>Example:</b>
                /// <para>当前所属的URL</para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <para>username</para>
                /// 
                /// <b>Example:</b>
                /// <para>用户名</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <para>Proportion of the current opinion</para>
            /// 
            /// <b>Example:</b>
            /// <para>当前观点占比</para>
            /// </summary>
            [NameInMap("Ratio")]
            [Validation(Required=false)]
            public string Ratio { get; set; }

            /// <summary>
            /// <para>List of topic perspectives</para>
            /// </summary>
            [NameInMap("ViewPoints")]
            [Validation(Required=false)]
            public List<ListWebReviewPointsResponseBodyDataViewPoints> ViewPoints { get; set; }
            public class ListWebReviewPointsResponseBodyDataViewPoints : TeaModel {
                /// <summary>
                /// <para>Outline</para>
                /// </summary>
                [NameInMap("Outlines")]
                [Validation(Required=false)]
                public List<ListWebReviewPointsResponseBodyDataViewPointsOutlines> Outlines { get; set; }
                public class ListWebReviewPointsResponseBodyDataViewPointsOutlines : TeaModel {
                    /// <summary>
                    /// <para>Outline</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>大纲</para>
                    /// </summary>
                    [NameInMap("Outline")]
                    [Validation(Required=false)]
                    public string Outline { get; set; }

                    /// <summary>
                    /// <para>Outline summary</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>大纲摘要</para>
                    /// </summary>
                    [NameInMap("Summary")]
                    [Validation(Required=false)]
                    public string Summary { get; set; }

                }

                /// <summary>
                /// <para>Generated point</para>
                /// 
                /// <b>Example:</b>
                /// <para>视角</para>
                /// </summary>
                [NameInMap("Point")]
                [Validation(Required=false)]
                public string Point { get; set; }

                /// <summary>
                /// <para>Summary</para>
                /// 
                /// <b>Example:</b>
                /// <para>摘要</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

            }

        }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Maximum number of return results</para>
        /// 
        /// <b>Example:</b>
        /// <para>79</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Fault description</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Token for the next page</para>
        /// 
        /// <b>Example:</b>
        /// <para>下一页的token</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Request UUID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation succeeded: true for success, false for failure</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Total count</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
