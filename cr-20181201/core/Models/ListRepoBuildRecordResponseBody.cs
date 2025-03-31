// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoBuildRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of image building records.</para>
        /// </summary>
        [NameInMap("BuildRecords")]
        [Validation(Required=false)]
        public List<ListRepoBuildRecordResponseBodyBuildRecords> BuildRecords { get; set; }
        public class ListRepoBuildRecordResponseBodyBuildRecords : TeaModel {
            /// <summary>
            /// <para>The ID of the image building record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>537e08ab-735e-415f-b7c2-160eb87f8****</para>
            /// </summary>
            [NameInMap("BuildRecordId")]
            [Validation(Required=false)]
            public string BuildRecordId { get; set; }

            /// <summary>
            /// <para>The status of the image building.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("BuildStatus")]
            [Validation(Required=false)]
            public string BuildStatus { get; set; }

            /// <summary>
            /// <para>The time when the image building ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1572875610000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The information about the image.</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public ListRepoBuildRecordResponseBodyBuildRecordsImage Image { get; set; }
            public class ListRepoBuildRecordResponseBodyBuildRecordsImage : TeaModel {
                /// <summary>
                /// <para>The tag of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v0.1</para>
                /// </summary>
                [NameInMap("ImageTag")]
                [Validation(Required=false)]
                public string ImageTag { get; set; }

                /// <summary>
                /// <para>The ID of the repository.</para>
                /// 
                /// <b>Example:</b>
                /// <para>crr-gzsrlevmvoaq****</para>
                /// </summary>
                [NameInMap("RepoId")]
                [Validation(Required=false)]
                public string RepoId { get; set; }

                /// <summary>
                /// <para>The name of the repository.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("RepoName")]
                [Validation(Required=false)]
                public string RepoName { get; set; }

                /// <summary>
                /// <para>The name of the namespace to which the repository belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("RepoNamespaceName")]
                [Validation(Required=false)]
                public string RepoNamespaceName { get; set; }

            }

            /// <summary>
            /// <para>The time when the image building started.</para>
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
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request is successful.</description></item>
        /// <item><description><c>false</c>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9D23DEDF-E91D-434B-B7D5-9D12C648D166</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
