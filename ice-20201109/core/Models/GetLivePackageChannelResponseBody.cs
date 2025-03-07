// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetLivePackageChannelResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the live package channel.</para>
        /// </summary>
        [NameInMap("LivePackageChannel")]
        [Validation(Required=false)]
        public GetLivePackageChannelResponseBodyLivePackageChannel LivePackageChannel { get; set; }
        public class GetLivePackageChannelResponseBodyLivePackageChannel : TeaModel {
            /// <summary>
            /// <para>The channel name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ch4</para>
            /// </summary>
            [NameInMap("ChannelName")]
            [Validation(Required=false)]
            public string ChannelName { get; set; }

            /// <summary>
            /// <para>The time when the channel was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-01T12:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The channel description.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The channel group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>channel-group-1</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The ingest endpoints.</para>
            /// </summary>
            [NameInMap("IngestEndpoints")]
            [Validation(Required=false)]
            public List<GetLivePackageChannelResponseBodyLivePackageChannelIngestEndpoints> IngestEndpoints { get; set; }
            public class GetLivePackageChannelResponseBodyLivePackageChannelIngestEndpoints : TeaModel {
                /// <summary>
                /// <para>The ingest endpoint ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ingest1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The password.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2F9e******b569c8</para>
                /// </summary>
                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// <para>The ingest endpoint URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xxx-1.packagepush-abcxxx.ap-southeast-1.aliyuncsiceintl.com/v1/group01/1/ch01/manifest">http://xxx-1.packagepush-abcxxx.ap-southeast-1.aliyuncsiceintl.com/v1/group01/1/ch01/manifest</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>us12******das</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <para>The time when the endpoint was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-01T12:00:00Z</para>
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            /// <summary>
            /// <para>The ingest protocol. Only HLS is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HLS</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The number of M3U8 segments.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("SegmentCount")]
            [Validation(Required=false)]
            public int? SegmentCount { get; set; }

            /// <summary>
            /// <para>The segment duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("SegmentDuration")]
            [Validation(Required=false)]
            public int? SegmentDuration { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RequestId-12345678</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
