// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainRecordDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RecordDataInfos")]
        [Validation(Required=false)]
        public DescribeLiveDomainRecordDataResponseBodyRecordDataInfos RecordDataInfos { get; set; }
        public class DescribeLiveDomainRecordDataResponseBodyRecordDataInfos : TeaModel {
            [NameInMap("RecordDataInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainRecordDataResponseBodyRecordDataInfosRecordDataInfo> RecordDataInfo { get; set; }
            public class DescribeLiveDomainRecordDataResponseBodyRecordDataInfosRecordDataInfo : TeaModel {
                public string Date { get; set; }
                public int? Total { get; set; }
                public DescribeLiveDomainRecordDataResponseBodyRecordDataInfosRecordDataInfoDetail Detail { get; set; }
                public class DescribeLiveDomainRecordDataResponseBodyRecordDataInfosRecordDataInfoDetail : TeaModel {
                    [NameInMap("FLV")]
                    [Validation(Required=false)]
                    public int? FLV { get; set; }

                    [NameInMap("TS")]
                    [Validation(Required=false)]
                    public int? TS { get; set; }

                    [NameInMap("MP4")]
                    [Validation(Required=false)]
                    public int? MP4 { get; set; }

                }
            }
        };

    }

}
