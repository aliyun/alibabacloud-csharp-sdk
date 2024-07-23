// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListAllMediaBucketResponseBody : TeaModel {
        /// <summary>
        /// <para>The media buckets returned.</para>
        /// </summary>
        [NameInMap("MediaBucketList")]
        [Validation(Required=false)]
        public ListAllMediaBucketResponseBodyMediaBucketList MediaBucketList { get; set; }
        public class ListAllMediaBucketResponseBodyMediaBucketList : TeaModel {
            [NameInMap("MediaBucket")]
            [Validation(Required=false)]
            public List<ListAllMediaBucketResponseBodyMediaBucketListMediaBucket> MediaBucket { get; set; }
            public class ListAllMediaBucketResponseBodyMediaBucketListMediaBucket : TeaModel {
                /// <summary>
                /// <para>The name of the media bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-bucket-****</para>
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// <para>The settings of Object Storage Service (OSS) hotlink protection. For more information, see <a href="https://help.aliyun.com/document_detail/31869.html">Hotlink protection</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">http://www.example.com</a></para>
                /// </summary>
                [NameInMap("Referer")]
                [Validation(Required=false)]
                public string Referer { get; set; }

                /// <summary>
                /// <para>The type of the media bucket. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Input: input media bucket</description></item>
                /// <item><description>Output: output media bucket</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Input</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned value of NextPageToken is a pagination token, which can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>P2Zqo1PLGhZdygo-ajSsjUX5zrBHCgXy6j4hEvv****</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79760D91-D3CF-4165-****-B7E2836EF62A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
