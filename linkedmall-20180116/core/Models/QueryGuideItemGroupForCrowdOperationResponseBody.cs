// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryGuideItemGroupForCrowdOperationResponseBody : TeaModel {
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
        public List<QueryGuideItemGroupForCrowdOperationResponseBodyModel> Model { get; set; }
        public class QueryGuideItemGroupForCrowdOperationResponseBodyModel : TeaModel {
            [NameInMap("AtmospherePicUrl")]
            [Validation(Required=false)]
            public string AtmospherePicUrl { get; set; }

            [NameInMap("CanSell")]
            [Validation(Required=false)]
            public bool? CanSell { get; set; }

            [NameInMap("CustomizedAttributeMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> CustomizedAttributeMap { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            [NameInMap("ItemTitle")]
            [Validation(Required=false)]
            public string ItemTitle { get; set; }

            [NameInMap("ItemUrl")]
            [Validation(Required=false)]
            public string ItemUrl { get; set; }

            [NameInMap("LmItemId")]
            [Validation(Required=false)]
            public string LmItemId { get; set; }

            [NameInMap("MainPicUrl")]
            [Validation(Required=false)]
            public string MainPicUrl { get; set; }

            [NameInMap("PointPrice")]
            [Validation(Required=false)]
            public long? PointPrice { get; set; }

            [NameInMap("Points")]
            [Validation(Required=false)]
            public long? Points { get; set; }

            [NameInMap("PointsAmount")]
            [Validation(Required=false)]
            public long? PointsAmount { get; set; }

            [NameInMap("PriceCent")]
            [Validation(Required=false)]
            public long? PriceCent { get; set; }

            [NameInMap("ReservePrice")]
            [Validation(Required=false)]
            public string ReservePrice { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<int?> Tags { get; set; }

            [NameInMap("WhitePicUrl")]
            [Validation(Required=false)]
            public string WhitePicUrl { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// pageSize
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

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
