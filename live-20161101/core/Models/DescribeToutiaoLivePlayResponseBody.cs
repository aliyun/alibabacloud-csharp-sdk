// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeToutiaoLivePlayResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the live stream.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<DescribeToutiaoLivePlayResponseBodyContent> Content { get; set; }
        public class DescribeToutiaoLivePlayResponseBodyContent : TeaModel {
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
            /// <para>The bandwidth. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0801239013671875</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public float? Bandwidth { get; set; }

            /// <summary>
            /// <para>The Content Delivery Network (CDN) name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ali</para>
            /// </summary>
            [NameInMap("CdnName")]
            [Validation(Required=false)]
            public string CdnName { get; set; }

            /// <summary>
            /// <para>The streaming domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The number of viewers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>452</para>
            /// </summary>
            [NameInMap("PlayNum")]
            [Validation(Required=false)]
            public long? PlayNum { get; set; }

            /// <summary>
            /// <para>The name of the live stream.</para>
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
            /// <para>1625484600</para>
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
