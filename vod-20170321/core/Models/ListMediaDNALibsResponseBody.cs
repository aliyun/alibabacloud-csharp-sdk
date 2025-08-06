// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListMediaDNALibsResponseBody : TeaModel {
        [NameInMap("AIDNALibInfoList")]
        [Validation(Required=false)]
        public ListMediaDNALibsResponseBodyAIDNALibInfoList AIDNALibInfoList { get; set; }
        public class ListMediaDNALibsResponseBodyAIDNALibInfoList : TeaModel {
            [NameInMap("AIDNALibInfo")]
            [Validation(Required=false)]
            public List<ListMediaDNALibsResponseBodyAIDNALibInfoListAIDNALibInfo> AIDNALibInfo { get; set; }
            public class ListMediaDNALibsResponseBodyAIDNALibInfoListAIDNALibInfo : TeaModel {
                [NameInMap("FpDBId")]
                [Validation(Required=false)]
                public string FpDBId { get; set; }

                [NameInMap("ModelType")]
                [Validation(Required=false)]
                public string ModelType { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
