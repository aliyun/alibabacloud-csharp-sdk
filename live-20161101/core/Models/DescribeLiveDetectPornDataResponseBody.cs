// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDetectPornDataResponseBody : TeaModel {
        [NameInMap("DetectPornData")]
        [Validation(Required=false)]
        public DescribeLiveDetectPornDataResponseBodyDetectPornData DetectPornData { get; set; }
        public class DescribeLiveDetectPornDataResponseBodyDetectPornData : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeLiveDetectPornDataResponseBodyDetectPornDataDataModule> DataModule { get; set; }
            public class DescribeLiveDetectPornDataResponseBodyDetectPornDataDataModule : TeaModel {
                [NameInMap("App")]
                [Validation(Required=false)]
                public string App { get; set; }

                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("Fee")]
                [Validation(Required=false)]
                public string Fee { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                [NameInMap("Stream")]
                [Validation(Required=false)]
                public string Stream { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B955107D-E658-4E77-B913-E0AC3D31693E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
