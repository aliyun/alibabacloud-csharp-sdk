// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CountDTXAppStatsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CountDTXAppStatsResponseBodyData Data { get; set; }
        public class CountDTXAppStatsResponseBodyData : TeaModel {
            [NameInMap("Stats")]
            [Validation(Required=false)]
            public CountDTXAppStatsResponseBodyDataStats Stats { get; set; }
            public class CountDTXAppStatsResponseBodyDataStats : TeaModel {
                [NameInMap("Today")]
                [Validation(Required=false)]
                public CountDTXAppStatsResponseBodyDataStatsToday Today { get; set; }
                public class CountDTXAppStatsResponseBodyDataStatsToday : TeaModel {
                    [NameInMap("ActivityNum")]
                    [Validation(Required=false)]
                    public long? ActivityNum { get; set; }
                    [NameInMap("ActionNum")]
                    [Validation(Required=false)]
                    public long? ActionNum { get; set; }
                };

                [NameInMap("Exception")]
                [Validation(Required=false)]
                public CountDTXAppStatsResponseBodyDataStatsException Exception { get; set; }
                public class CountDTXAppStatsResponseBodyDataStatsException : TeaModel {
                    [NameInMap("Total")]
                    [Validation(Required=false)]
                    public long? Total { get; set; }
                };

                [NameInMap("Ongoing")]
                [Validation(Required=false)]
                public CountDTXAppStatsResponseBodyDataStatsOngoing Ongoing { get; set; }
                public class CountDTXAppStatsResponseBodyDataStatsOngoing : TeaModel {
                    [NameInMap("ActivityNum")]
                    [Validation(Required=false)]
                    public long? ActivityNum { get; set; }
                    [NameInMap("ActionNum")]
                    [Validation(Required=false)]
                    public long? ActionNum { get; set; }
                };

            }
            [NameInMap("AppInfo")]
            [Validation(Required=false)]
            public CountDTXAppStatsResponseBodyDataAppInfo AppInfo { get; set; }
            public class CountDTXAppStatsResponseBodyDataAppInfo : TeaModel {
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

            }
        };

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
