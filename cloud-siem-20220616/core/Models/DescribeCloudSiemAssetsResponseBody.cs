// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeCloudSiemAssetsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCloudSiemAssetsResponseBodyData Data { get; set; }
        public class DescribeCloudSiemAssetsResponseBodyData : TeaModel {
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public DescribeCloudSiemAssetsResponseBodyDataPageInfo PageInfo { get; set; }
            public class DescribeCloudSiemAssetsResponseBodyDataPageInfo : TeaModel {
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            [NameInMap("ResponseData")]
            [Validation(Required=false)]
            public List<DescribeCloudSiemAssetsResponseBodyDataResponseData> ResponseData { get; set; }
            public class DescribeCloudSiemAssetsResponseBodyDataResponseData : TeaModel {
                [NameInMap("AlertUuid")]
                [Validation(Required=false)]
                public string AlertUuid { get; set; }

                [NameInMap("Aliuid")]
                [Validation(Required=false)]
                public long? Aliuid { get; set; }

                [NameInMap("AssetId")]
                [Validation(Required=false)]
                public string AssetId { get; set; }

                [NameInMap("AssetInfo")]
                [Validation(Required=false)]
                public List<DescribeCloudSiemAssetsResponseBodyDataResponseDataAssetInfo> AssetInfo { get; set; }
                public class DescribeCloudSiemAssetsResponseBodyDataResponseDataAssetInfo : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("KeyName")]
                    [Validation(Required=false)]
                    public string KeyName { get; set; }

                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public string Values { get; set; }

                }

                [NameInMap("AssetName")]
                [Validation(Required=false)]
                public string AssetName { get; set; }

                [NameInMap("AssetType")]
                [Validation(Required=false)]
                public string AssetType { get; set; }

                [NameInMap("CloudCode")]
                [Validation(Required=false)]
                public string CloudCode { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("IncidentUuid")]
                [Validation(Required=false)]
                public string IncidentUuid { get; set; }

                [NameInMap("SubUserId")]
                [Validation(Required=false)]
                public long? SubUserId { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
