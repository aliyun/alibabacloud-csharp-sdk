// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListPersonVisitCountResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=true)]
        public string PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public string PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public string Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public string TotalCount { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public List<ListPersonVisitCountResponseData> Data { get; set; }
        public class ListPersonVisitCountResponseData : TeaModel {
            [NameInMap("CorpId")]
            [Validation(Required=true)]
            public string CorpId { get; set; }

            [NameInMap("DeviceId")]
            [Validation(Required=true)]
            public string DeviceId { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=true)]
            public string GroupId { get; set; }

            [NameInMap("PersonId")]
            [Validation(Required=true)]
            public string PersonId { get; set; }

            [NameInMap("TagCode")]
            [Validation(Required=true)]
            public string TagCode { get; set; }

            [NameInMap("TagMetrics")]
            [Validation(Required=true)]
            public string TagMetrics { get; set; }

            [NameInMap("HourId")]
            [Validation(Required=true)]
            public string HourId { get; set; }

            [NameInMap("DayId")]
            [Validation(Required=true)]
            public string DayId { get; set; }

        }

    }

}
