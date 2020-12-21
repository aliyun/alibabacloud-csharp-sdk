// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListPersonVisitCountResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListPersonVisitCountResponseBodyData> Data { get; set; }
        public class ListPersonVisitCountResponseBodyData : TeaModel {
            [NameInMap("DayId")]
            [Validation(Required=false)]
            public string DayId { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            [NameInMap("TagCode")]
            [Validation(Required=false)]
            public string TagCode { get; set; }

            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("TagMetrics")]
            [Validation(Required=false)]
            public string TagMetrics { get; set; }

            [NameInMap("HourId")]
            [Validation(Required=false)]
            public string HourId { get; set; }

            [NameInMap("PersonId")]
            [Validation(Required=false)]
            public string PersonId { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
