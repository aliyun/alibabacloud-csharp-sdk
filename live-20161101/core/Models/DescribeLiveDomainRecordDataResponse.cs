// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainRecordDataResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("RecordDataInfos")]
        [Validation(Required=true)]
        public DescribeLiveDomainRecordDataResponseRecordDataInfos RecordDataInfos { get; set; }
        public class DescribeLiveDomainRecordDataResponseRecordDataInfos : TeaModel {
            [NameInMap("RecordDataInfo")]
            [Validation(Required=true)]
            public List<DescribeLiveDomainRecordDataResponseRecordDataInfosRecordDataInfo> RecordDataInfo { get; set; }
            public class DescribeLiveDomainRecordDataResponseRecordDataInfosRecordDataInfo : TeaModel {
                public string Date { get; set; }
                public int? Total { get; set; }
                public DescribeLiveDomainRecordDataResponseRecordDataInfosRecordDataInfoDetail Detail { get; set; }
                public class DescribeLiveDomainRecordDataResponseRecordDataInfosRecordDataInfoDetail : TeaModel {
                    [NameInMap("MP4")]
                    [Validation(Required=true)]
                    public int? MP4 { get; set; }

                    [NameInMap("FLV")]
                    [Validation(Required=true)]
                    public int? FLV { get; set; }

                    [NameInMap("TS")]
                    [Validation(Required=true)]
                    public int? TS { get; set; }

                }
            }
        };

    }

}
