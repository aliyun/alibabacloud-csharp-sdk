// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataTrackJobDegreeResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("JobDegree")]
        [Validation(Required=false)]
        public GetDataTrackJobDegreeResponseBodyJobDegree JobDegree { get; set; }
        public class GetDataTrackJobDegreeResponseBodyJobDegree : TeaModel {
            [NameInMap("DownloadCompletionDegree")]
            [Validation(Required=false)]
            public double? DownloadCompletionDegree { get; set; }

            [NameInMap("FilterCompletionDegree")]
            [Validation(Required=false)]
            public double? FilterCompletionDegree { get; set; }

            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

            [NameInMap("ListCompletionDegree")]
            [Validation(Required=false)]
            public double? ListCompletionDegree { get; set; }

            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
