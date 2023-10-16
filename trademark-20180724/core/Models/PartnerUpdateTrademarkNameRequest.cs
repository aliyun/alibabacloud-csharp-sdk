// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class PartnerUpdateTrademarkNameRequest : TeaModel {
        [NameInMap("AliyunKp")]
        [Validation(Required=false)]
        public string AliyunKp { get; set; }

        [NameInMap("Bid")]
        [Validation(Required=false)]
        public string Bid { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("CallerParentId")]
        [Validation(Required=false)]
        public long? CallerParentId { get; set; }

        [NameInMap("CallerType")]
        [Validation(Required=false)]
        public string CallerType { get; set; }

        [NameInMap("EventSceneType")]
        [Validation(Required=false)]
        public long? EventSceneType { get; set; }

        [NameInMap("IntentionBizId")]
        [Validation(Required=false)]
        public string IntentionBizId { get; set; }

        [NameInMap("TmComment")]
        [Validation(Required=false)]
        public string TmComment { get; set; }

        [NameInMap("TmIcon")]
        [Validation(Required=false)]
        public string TmIcon { get; set; }

        [NameInMap("TmName")]
        [Validation(Required=false)]
        public string TmName { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
