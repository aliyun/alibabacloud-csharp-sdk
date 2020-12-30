// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeRequestStatisticLogResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Statistic")]
        [Validation(Required=false)]
        public List<DescribeRequestStatisticLogResponseBodyStatistic> Statistic { get; set; }
        public class DescribeRequestStatisticLogResponseBodyStatistic : TeaModel {
            [NameInMap("ServerTime")]
            [Validation(Required=false)]
            public string ServerTime { get; set; }

            [NameInMap("CallResult")]
            [Validation(Required=false)]
            public string CallResult { get; set; }

            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("CountryId")]
            [Validation(Required=false)]
            public string CountryId { get; set; }

            [NameInMap("DetectIp")]
            [Validation(Required=false)]
            public string DetectIp { get; set; }

            [NameInMap("EsnAppId")]
            [Validation(Required=false)]
            public string EsnAppId { get; set; }

            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            [NameInMap("IspId")]
            [Validation(Required=false)]
            public string IspId { get; set; }

            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            [NameInMap("EscapedTime")]
            [Validation(Required=false)]
            public string EscapedTime { get; set; }

            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

            [NameInMap("CityId")]
            [Validation(Required=false)]
            public string CityId { get; set; }

            [NameInMap("ProvinceId")]
            [Validation(Required=false)]
            public string ProvinceId { get; set; }

            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            [NameInMap("SdkVersion")]
            [Validation(Required=false)]
            public string SdkVersion { get; set; }

            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            [NameInMap("EsnGroupId")]
            [Validation(Required=false)]
            public string EsnGroupId { get; set; }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            [NameInMap("EsnBizId")]
            [Validation(Required=false)]
            public string EsnBizId { get; set; }

        }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

    }

}
