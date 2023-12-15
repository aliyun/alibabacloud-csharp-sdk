// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AppMallsService20180224.Models
{
    public class TaobaoFilmGetRegionListResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<TaobaoFilmGetRegionListResponseBodyRegions> Regions { get; set; }
        public class TaobaoFilmGetRegionListResponseBodyRegions : TeaModel {
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public long? CityCode { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }

            [NameInMap("PinYin")]
            [Validation(Required=false)]
            public string PinYin { get; set; }

            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("SubMsg")]
        [Validation(Required=false)]
        public string SubMsg { get; set; }

    }

}
