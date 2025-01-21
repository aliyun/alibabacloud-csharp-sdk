// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetLivePackageChannelResponseBody : TeaModel {
        [NameInMap("LivePackageChannel")]
        [Validation(Required=false)]
        public GetLivePackageChannelResponseBodyLivePackageChannel LivePackageChannel { get; set; }
        public class GetLivePackageChannelResponseBodyLivePackageChannel : TeaModel {
            /// <summary>
            /// <para>频道名称，字符必须为大小写英文字母或-、<em>。
            /// 1 ~ 200个字符。
            /// 格式：[A-Za-z0-9</em>-]+</para>
            /// 
            /// <b>Example:</b>
            /// <para>ch4</para>
            /// </summary>
            [NameInMap("ChannelName")]
            [Validation(Required=false)]
            public string ChannelName { get; set; }

            /// <summary>
            /// <para>代表创建时间的资源属性字段</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-01T12:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>频道描述，最大1000个字符</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>频道组名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>channel-group-1</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("IngestEndpoints")]
            [Validation(Required=false)]
            public List<GetLivePackageChannelResponseBodyLivePackageChannelIngestEndpoints> IngestEndpoints { get; set; }
            public class GetLivePackageChannelResponseBodyLivePackageChannelIngestEndpoints : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ingest1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2F9e******b569c8</para>
                /// </summary>
                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://xxx-1.packagepush-abcxxx.ap-southeast-1.aliyuncsiceintl.com/v1/group01/1/ch01/manifest">http://xxx-1.packagepush-abcxxx.ap-southeast-1.aliyuncsiceintl.com/v1/group01/1/ch01/manifest</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>us12******das</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <para>最后修改时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-01T12:00:00Z</para>
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            /// <summary>
            /// <para>输入协议，目前仅支持HLS</para>
            /// 
            /// <b>Example:</b>
            /// <para>HLS</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>输入流m3u8切片个数，2～100</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("SegmentCount")]
            [Validation(Required=false)]
            public int? SegmentCount { get; set; }

            /// <summary>
            /// <para>输入流切片时长，1～30</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("SegmentDuration")]
            [Validation(Required=false)]
            public int? SegmentDuration { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RequestId-12345678</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
