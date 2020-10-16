// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListCorpMetricsResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public string Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public List<ListCorpMetricsResponseData> Data { get; set; }
        public class ListCorpMetricsResponseData : TeaModel {
            [NameInMap("CorpId")]
            [Validation(Required=true)]
            public string CorpId { get; set; }

            [NameInMap("TagCode")]
            [Validation(Required=true)]
            public string TagCode { get; set; }

            [NameInMap("TagMetrics")]
            [Validation(Required=true)]
            public string TagMetrics { get; set; }

            [NameInMap("TagValue")]
            [Validation(Required=true)]
            public string TagValue { get; set; }

            [NameInMap("DeviceGroupId")]
            [Validation(Required=true)]
            public string DeviceGroupId { get; set; }

            [NameInMap("DeviceId")]
            [Validation(Required=true)]
            public string DeviceId { get; set; }

            [NameInMap("UserGroupId")]
            [Validation(Required=true)]
            public string UserGroupId { get; set; }

            [NameInMap("PersonId")]
            [Validation(Required=true)]
            public string PersonId { get; set; }

            [NameInMap("DateId")]
            [Validation(Required=true)]
            public string DateId { get; set; }

        }

    }

}
