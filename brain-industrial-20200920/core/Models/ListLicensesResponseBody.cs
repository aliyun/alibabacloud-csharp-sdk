// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class ListLicensesResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("LicenseList")]
        [Validation(Required=false)]
        public List<ListLicensesResponseBodyLicenseList> LicenseList { get; set; }
        public class ListLicensesResponseBodyLicenseList : TeaModel {
            [NameInMap("ActivateTime")]
            [Validation(Required=false)]
            public string ActivateTime { get; set; }

            [NameInMap("AdaptiveMachine")]
            [Validation(Required=false)]
            public int? AdaptiveMachine { get; set; }

            [NameInMap("AllDuration")]
            [Validation(Required=false)]
            public string AllDuration { get; set; }

            [NameInMap("BuyTime")]
            [Validation(Required=false)]
            public string BuyTime { get; set; }

            [NameInMap("CpuLimit")]
            [Validation(Required=false)]
            public int? CpuLimit { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            [NameInMap("EffectTime")]
            [Validation(Required=false)]
            public string EffectTime { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("LicenseSpecCode")]
            [Validation(Required=false)]
            public string LicenseSpecCode { get; set; }

            [NameInMap("LicenseSpecName")]
            [Validation(Required=false)]
            public string LicenseSpecName { get; set; }

            [NameInMap("LicenseSpecType")]
            [Validation(Required=false)]
            public string LicenseSpecType { get; set; }

            [NameInMap("MemoryLimit")]
            [Validation(Required=false)]
            public int? MemoryLimit { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UnActivateAllDuration")]
            [Validation(Required=false)]
            public string UnActivateAllDuration { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public string TotalPage { get; set; }

        [NameInMap("TotalPageCount")]
        [Validation(Required=false)]
        public string TotalPageCount { get; set; }

    }

}
