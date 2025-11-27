// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ListAttachedOSSBucketsResponseBody : TeaModel {
        /// <summary>
        /// <para>List of bound OSS Buckets.</para>
        /// </summary>
        [NameInMap("AttachedOSSBuckets")]
        [Validation(Required=false)]
        public List<ListAttachedOSSBucketsResponseBodyAttachedOSSBuckets> AttachedOSSBuckets { get; set; }
        public class ListAttachedOSSBucketsResponseBodyAttachedOSSBuckets : TeaModel {
            /// <summary>
            /// <para>Timestamp of the project creation time, formatted as RFC3339Nano.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-29T14:50:13.011643661+08:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Description</para>
            /// 
            /// <b>Example:</b>
            /// <para>test bucket</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>OSS Bucket name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-bucket</para>
            /// </summary>
            [NameInMap("OSSBucket")]
            [Validation(Required=false)]
            public string OSSBucket { get; set; }

            /// <summary>
            /// <para>User ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1023***********</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>Project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-project</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>Timestamp of the project modification time, formatted as RFC3339Nano.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-29T14:50:13.011643661+08:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>Pagination token. When the total number of tasks in the list exceeds the set MaxResults, this token is used for pagination. This parameter has a value only when not all matching task lists are returned.</para>
        /// <para>Use this value as NextToken in the next call to return the subsequent task list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNDU2Nzg6aW1tdGVzdDpleGFtcGxlYnVja2V0OmRhdGFzZXQwMDE6b3NzOi8vZXhhbXBsZWJ1Y2tldC9zYW1wbGVvYmplY3QxLmpwZw==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9847E7D0-A9A3-0053-84C6-BA16FF******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
