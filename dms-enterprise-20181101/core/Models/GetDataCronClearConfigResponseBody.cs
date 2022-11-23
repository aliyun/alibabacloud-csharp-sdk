// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataCronClearConfigResponseBody : TeaModel {
        [NameInMap("DataCronClearConfig")]
        [Validation(Required=false)]
        public GetDataCronClearConfigResponseBodyDataCronClearConfig DataCronClearConfig { get; set; }
        public class GetDataCronClearConfigResponseBodyDataCronClearConfig : TeaModel {
            [NameInMap("CronCallTimes")]
            [Validation(Required=false)]
            public string CronCallTimes { get; set; }

            [NameInMap("CronFormat")]
            [Validation(Required=false)]
            public string CronFormat { get; set; }

            [NameInMap("CronLastCallStartTime")]
            [Validation(Required=false)]
            public string CronLastCallStartTime { get; set; }

            [NameInMap("CronNextCallTime")]
            [Validation(Required=false)]
            public string CronNextCallTime { get; set; }

            [NameInMap("CronStatus")]
            [Validation(Required=false)]
            public string CronStatus { get; set; }

            [NameInMap("CurrentClearTaskCount")]
            [Validation(Required=false)]
            public long? CurrentClearTaskCount { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            [NameInMap("OptimizeTableAfterEveryClearTimes")]
            [Validation(Required=false)]
            public long? OptimizeTableAfterEveryClearTimes { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
