// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamTranscodeStreamNumResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of streams for which transcoding is triggered by stream pulling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("LazyTranscodedNumber")]
        [Validation(Required=false)]
        public long? LazyTranscodedNumber { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>150191A4-DD88-5941-B48C-9DF59E0A8B1F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of streams.</para>
        /// 
        /// <b>Example:</b>
        /// <para>57</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        /// <summary>
        /// <para>The details about the transcoding templates.</para>
        /// </summary>
        [NameInMap("TranscodeStreamCountDetails")]
        [Validation(Required=false)]
        public List<DescribeLiveStreamTranscodeStreamNumResponseBodyTranscodeStreamCountDetails> TranscodeStreamCountDetails { get; set; }
        public class DescribeLiveStreamTranscodeStreamNumResponseBodyTranscodeStreamCountDetails : TeaModel {
            /// <summary>
            /// <para>The number of streams that use the transcoding template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The name of the transcoding template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>template_name</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

        }

        /// <summary>
        /// <para>The number of streams that are transcoded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TranscodedNumber")]
        [Validation(Required=false)]
        public long? TranscodedNumber { get; set; }

        /// <summary>
        /// <para>The number of streams that are not transcoded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27</para>
        /// </summary>
        [NameInMap("UntranscodeNumber")]
        [Validation(Required=false)]
        public long? UntranscodeNumber { get; set; }

    }

}
