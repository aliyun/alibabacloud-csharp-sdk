// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Snsuapi20180709.Models
{
    public class BandPrecheckResponseBody : TeaModel {
        [NameInMap("ResultModule")]
        [Validation(Required=false)]
        public BandPrecheckResponseBodyResultModule ResultModule { get; set; }
        public class BandPrecheckResponseBodyResultModule : TeaModel {
            [NameInMap("UploadBandwidth")]
            [Validation(Required=false)]
            public int? UploadBandwidth { get; set; }
            [NameInMap("BandId")]
            [Validation(Required=false)]
            public long? BandId { get; set; }
            [NameInMap("BandOfferList")]
            [Validation(Required=false)]
            public BandPrecheckResponseBodyResultModuleBandOfferList BandOfferList { get; set; }
            public class BandPrecheckResponseBodyResultModuleBandOfferList : TeaModel {
                [NameInMap("BandOfferList")]
                [Validation(Required=false)]
                public List<BandPrecheckResponseBodyResultModuleBandOfferListBandOfferList> BandOfferList { get; set; }
                public class BandPrecheckResponseBodyResultModuleBandOfferListBandOfferList : TeaModel {
                    [NameInMap("Direction")]
                    [Validation(Required=false)]
                    public string Direction { get; set; }

                    [NameInMap("OfferId")]
                    [Validation(Required=false)]
                    public long? OfferId { get; set; }

                    [NameInMap("Bandwidth")]
                    [Validation(Required=false)]
                    public int? Bandwidth { get; set; }

                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public long? Duration { get; set; }

                }

            }
            [NameInMap("DownloadBandwidth")]
            [Validation(Required=false)]
            public int? DownloadBandwidth { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
