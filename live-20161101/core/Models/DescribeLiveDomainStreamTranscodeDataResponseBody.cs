// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainStreamTranscodeDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3C6CCEC4-6B88-4D4A-93E4-D47B3D92CF8F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TranscodeDataList")]
        [Validation(Required=false)]
        public DescribeLiveDomainStreamTranscodeDataResponseBodyTranscodeDataList TranscodeDataList { get; set; }
        public class DescribeLiveDomainStreamTranscodeDataResponseBodyTranscodeDataList : TeaModel {
            [NameInMap("TranscodeData")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainStreamTranscodeDataResponseBodyTranscodeDataListTranscodeData> TranscodeData { get; set; }
            public class DescribeLiveDomainStreamTranscodeDataResponseBodyTranscodeDataListTranscodeData : TeaModel {
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("Resolution")]
                [Validation(Required=false)]
                public string Resolution { get; set; }

                [NameInMap("TanscodeType")]
                [Validation(Required=false)]
                public string TanscodeType { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

    }

}
