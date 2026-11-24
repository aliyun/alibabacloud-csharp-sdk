// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetRepoBuildRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The build record ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79174CBA-8556-443A-8976-22C922D7****</para>
        /// </summary>
        [NameInMap("BuildRecordId")]
        [Validation(Required=false)]
        public string BuildRecordId { get; set; }

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
        /// <para>The end time, in UNIX timestamp format. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1568718698000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The image information.</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public GetRepoBuildRecordResponseBodyImage Image { get; set; }
        public class GetRepoBuildRecordResponseBodyImage : TeaModel {
            /// <summary>
            /// <para>The image tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>master</para>
            /// </summary>
            [NameInMap("ImageTag")]
            [Validation(Required=false)]
            public string ImageTag { get; set; }

            /// <summary>
            /// <para>The image repository name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// <para>The namespace name of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RepoNamespaceName")]
            [Validation(Required=false)]
            public string RepoNamespaceName { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a78ec6fb-16ea-4649-93b7-f52afba7d9de1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time, in UNIX timestamp format. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1568718468000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
