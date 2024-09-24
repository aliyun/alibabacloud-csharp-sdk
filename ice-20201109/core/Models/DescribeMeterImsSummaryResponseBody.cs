// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribeMeterImsSummaryResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeMeterImsSummaryResponseBodyData> Data { get; set; }
        public class DescribeMeterImsSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>8722</para>
            /// </summary>
            [NameInMap("EditingDuration")]
            [Validation(Required=false)]
            public string EditingDuration { get; set; }

            [NameInMap("LiveEditDuration")]
            [Validation(Required=false)]
            public string LiveEditDuration { get; set; }

            [NameInMap("LiveRecordDuration")]
            [Validation(Required=false)]
            public string LiveRecordDuration { get; set; }

            [NameInMap("LiveSnapshotCount")]
            [Validation(Required=false)]
            public string LiveSnapshotCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12356</para>
            /// </summary>
            [NameInMap("LiveTranscodeDuration")]
            [Validation(Required=false)]
            public long? LiveTranscodeDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MpsAiDuration")]
            [Validation(Required=false)]
            public long? MpsAiDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>17337</para>
            /// </summary>
            [NameInMap("MpsTranscodeDuration")]
            [Validation(Required=false)]
            public long? MpsTranscodeDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("MpsTranscodeUHDDuration")]
            [Validation(Required=false)]
            public long? MpsTranscodeUHDDuration { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BEA98A0C-7870-15FE-B96F-8880BB600A2C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
