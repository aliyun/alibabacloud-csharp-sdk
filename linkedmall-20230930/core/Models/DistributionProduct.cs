// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class DistributionProduct : TeaModel {
        [NameInMap("categoryChain")]
        [Validation(Required=false)]
        public string CategoryChain { get; set; }

        [NameInMap("categoryLeafId")]
        [Validation(Required=false)]
        public long? CategoryLeafId { get; set; }

        [NameInMap("categoryLeafName")]
        [Validation(Required=false)]
        public string CategoryLeafName { get; set; }

        [NameInMap("channelCode")]
        [Validation(Required=false)]
        public string ChannelCode { get; set; }

        [NameInMap("distributeStatus")]
        [Validation(Required=false)]
        public string DistributeStatus { get; set; }

        [NameInMap("picUrl")]
        [Validation(Required=false)]
        public string PicUrl { get; set; }

        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        [NameInMap("sellerId")]
        [Validation(Required=false)]
        public string SellerId { get; set; }

        [NameInMap("shortTitle")]
        [Validation(Required=false)]
        public string ShortTitle { get; set; }

        [NameInMap("skus")]
        [Validation(Required=false)]
        public List<DistributionSku> Skus { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("whiteBackgroundPicUrl")]
        [Validation(Required=false)]
        public string WhiteBackgroundPicUrl { get; set; }

    }

}
