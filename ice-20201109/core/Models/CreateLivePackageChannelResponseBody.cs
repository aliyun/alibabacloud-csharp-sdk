// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateLivePackageChannelResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the live package channel.</para>
        /// </summary>
        [NameInMap("LivePackageChannel")]
        [Validation(Required=false)]
        public CreateLivePackageChannelResponseBodyLivePackageChannel LivePackageChannel { get; set; }
        public class CreateLivePackageChannelResponseBodyLivePackageChannel : TeaModel {
            /// <summary>
            /// <para>The channel name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-channel</para>
            /// </summary>
            [NameInMap("ChannelName")]
            [Validation(Required=false)]
            public string ChannelName { get; set; }

            /// <summary>
            /// <para>The time when the channel was created. It is in the yyyy-MM-ddTHH:mm:ssZ format and displayed in UTC.</para>
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
            public List<CreateLivePackageChannelResponseBodyLivePackageChannelIngestEndpoints> IngestEndpoints { get; set; }
            public class CreateLivePackageChannelResponseBodyLivePackageChannelIngestEndpoints : TeaModel {
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
            /// <para>The time when the channel was last modified. It is in the yyyy-MM-ddTHH:mm:ssZ format and displayed in UTC.</para>
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
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
