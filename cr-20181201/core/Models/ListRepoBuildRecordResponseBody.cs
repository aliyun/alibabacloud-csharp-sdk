// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoBuildRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of build records.</para>
        /// </summary>
        [NameInMap("BuildRecords")]
        [Validation(Required=false)]
        public List<ListRepoBuildRecordResponseBodyBuildRecords> BuildRecords { get; set; }
        public class ListRepoBuildRecordResponseBodyBuildRecords : TeaModel {
            /// <summary>
            /// <para>The build record ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>537e08ab-735e-415f-b7c2-160eb87f8****</para>
            /// </summary>
            [NameInMap("BuildRecordId")]
            [Validation(Required=false)]
            public string BuildRecordId { get; set; }

            /// <summary>
            /// <para>The build status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("BuildStatus")]
            [Validation(Required=false)]
            public string BuildStatus { get; set; }

            /// <summary>
            /// <para>The end time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1572875610000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The image information.</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public ListRepoBuildRecordResponseBodyBuildRecordsImage Image { get; set; }
            public class ListRepoBuildRecordResponseBodyBuildRecordsImage : TeaModel {
                /// <summary>
                /// <para>The image tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v0.1</para>
                /// </summary>
                [NameInMap("ImageTag")]
                [Validation(Required=false)]
                public string ImageTag { get; set; }

                /// <summary>
                /// <para>The repository ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>crr-gzsrlevmvoaq****</para>
                /// </summary>
                [NameInMap("RepoId")]
                [Validation(Required=false)]
                public string RepoId { get; set; }

                /// <summary>
                /// <para>The repository name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("RepoName")]
                [Validation(Required=false)]
                public string RepoName { get; set; }

                /// <summary>
                /// <para>The repository namespace name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("RepoNamespaceName")]
                [Validation(Required=false)]
                public string RepoNamespaceName { get; set; }

            }

            /// <summary>
            /// <para>The start time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1572872207000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>The return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The API call is successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The API call failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9D23DEDF-E91D-434B-B7D5-9D12C648D166</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
