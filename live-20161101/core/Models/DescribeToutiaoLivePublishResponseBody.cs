// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeToutiaoLivePublishResponseBody : TeaModel {
        /// <summary>
        /// <para>The stream ingest details.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<DescribeToutiaoLivePublishResponseBodyContent> Content { get; set; }
        public class DescribeToutiaoLivePublishResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The name of the application to which the live stream belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>liveApp****</para>
            /// </summary>
            [NameInMap("App")]
            [Validation(Required=false)]
            public string App { get; set; }

            /// <summary>
            /// <para>The bitrate. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>261587</para>
            /// </summary>
            [NameInMap("Bitrate")]
            [Validation(Required=false)]
            public float? Bitrate { get; set; }

            /// <summary>
            /// <para>The bitrate difference.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BwDiff")]
            [Validation(Required=false)]
            public float? BwDiff { get; set; }

            /// <summary>
            /// <para>The name of the content delivery network (CDN) service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ali</para>
            /// </summary>
            [NameInMap("CdnName")]
            [Validation(Required=false)]
            public string CdnName { get; set; }

            /// <summary>
            /// <para>The ingest domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The number of dropped frames.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Flr")]
            [Validation(Required=false)]
            public float? Flr { get; set; }

            /// <summary>
            /// <para>The frame rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>74.4</para>
            /// </summary>
            [NameInMap("Fps")]
            [Validation(Required=false)]
            public float? Fps { get; set; }

            /// <summary>
            /// <para>The name of the ingested stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>liveStream****</para>
            /// </summary>
            [NameInMap("StreamName")]
            [Validation(Required=false)]
            public string StreamName { get; set; }

            /// <summary>
            /// <para>The timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1624358970</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// <para>The description of the response status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
