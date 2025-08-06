// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMTSStatisResponseBody : TeaModel {
        [NameInMap("MTSStatisBySpecList")]
        [Validation(Required=false)]
        public GetMTSStatisResponseBodyMTSStatisBySpecList MTSStatisBySpecList { get; set; }
        public class GetMTSStatisResponseBodyMTSStatisBySpecList : TeaModel {
            [NameInMap("MTSStatisBySpec")]
            [Validation(Required=false)]
            public List<GetMTSStatisResponseBodyMTSStatisBySpecListMTSStatisBySpec> MTSStatisBySpec { get; set; }
            public class GetMTSStatisResponseBodyMTSStatisBySpecListMTSStatisBySpec : TeaModel {
                [NameInMap("MTSStatisDOList")]
                [Validation(Required=false)]
                public GetMTSStatisResponseBodyMTSStatisBySpecListMTSStatisBySpecMTSStatisDOList MTSStatisDOList { get; set; }
                public class GetMTSStatisResponseBodyMTSStatisBySpecListMTSStatisBySpecMTSStatisDOList : TeaModel {
                    [NameInMap("MTSStatisDO")]
                    [Validation(Required=false)]
                    public List<GetMTSStatisResponseBodyMTSStatisBySpecListMTSStatisBySpecMTSStatisDOListMTSStatisDO> MTSStatisDO { get; set; }
                    public class GetMTSStatisResponseBodyMTSStatisBySpecListMTSStatisBySpecMTSStatisDOListMTSStatisDO : TeaModel {
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public long? Duration { get; set; }

                        [NameInMap("Specification")]
                        [Validation(Required=false)]
                        public string Specification { get; set; }

                        [NameInMap("StatTime")]
                        [Validation(Required=false)]
                        public string StatTime { get; set; }

                        [NameInMap("StatTimeUTC")]
                        [Validation(Required=false)]
                        public string StatTimeUTC { get; set; }

                        [NameInMap("UserId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                    }

                }

                [NameInMap("Specification")]
                [Validation(Required=false)]
                public string Specification { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
