// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataCronClearTaskDetailListResponseBody : TeaModel {
        [NameInMap("DataCronClearTaskDetailList")]
        [Validation(Required=false)]
        public List<GetDataCronClearTaskDetailListResponseBodyDataCronClearTaskDetailList> DataCronClearTaskDetailList { get; set; }
        public class GetDataCronClearTaskDetailListResponseBodyDataCronClearTaskDetailList : TeaModel {
            [NameInMap("ActualAffectRows")]
            [Validation(Required=false)]
            public long? ActualAffectRows { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DBTaskGroupId")]
            [Validation(Required=false)]
            public long? DBTaskGroupId { get; set; }

            [NameInMap("jobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

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

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
