// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryAdvertisementSettleInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public QueryAdvertisementSettleInfoResponseBodyModel Model { get; set; }
        public class QueryAdvertisementSettleInfoResponseBodyModel : TeaModel {
            [NameInMap("AdvertiseSettleInfoList")]
            [Validation(Required=false)]
            public List<QueryAdvertisementSettleInfoResponseBodyModelAdvertiseSettleInfoList> AdvertiseSettleInfoList { get; set; }
            public class QueryAdvertisementSettleInfoResponseBodyModelAdvertiseSettleInfoList : TeaModel {
                [NameInMap("AdvertiseName")]
                [Validation(Required=false)]
                public string AdvertiseName { get; set; }

                [NameInMap("AdvertiseSettleAmount")]
                [Validation(Required=false)]
                public string AdvertiseSettleAmount { get; set; }

                [NameInMap("AdvertiseSettleDetailId")]
                [Validation(Required=false)]
                public string AdvertiseSettleDetailId { get; set; }

                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("ExtInfo")]
                [Validation(Required=false)]
                public string ExtInfo { get; set; }

                [NameInMap("MediaSettleDetailId")]
                [Validation(Required=false)]
                public string MediaSettleDetailId { get; set; }

                [NameInMap("ModifiedDate")]
                [Validation(Required=false)]
                public string ModifiedDate { get; set; }

                [NameInMap("SettleNo")]
                [Validation(Required=false)]
                public string SettleNo { get; set; }

                [NameInMap("SettleStatus")]
                [Validation(Required=false)]
                public string SettleStatus { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
