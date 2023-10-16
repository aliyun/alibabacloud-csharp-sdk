// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class UpdateTrademarkOnsaleRequest : TeaModel {
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        [NameInMap("ClassificationCode")]
        [Validation(Required=false)]
        public string ClassificationCode { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        [NameInMap("OriginalPrice")]
        [Validation(Required=false)]
        public float? OriginalPrice { get; set; }

        [NameInMap("OwnerEnName")]
        [Validation(Required=false)]
        public string OwnerEnName { get; set; }

        [NameInMap("OwnerName")]
        [Validation(Required=false)]
        public string OwnerName { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("RegAnnDate")]
        [Validation(Required=false)]
        public long? RegAnnDate { get; set; }

        [NameInMap("SecondaryClassification")]
        [Validation(Required=false)]
        public string SecondaryClassification { get; set; }

        [NameInMap("ThirdClassification")]
        [Validation(Required=false)]
        public string ThirdClassification { get; set; }

        [NameInMap("TmIcon")]
        [Validation(Required=false)]
        public string TmIcon { get; set; }

        [NameInMap("TmName")]
        [Validation(Required=false)]
        public string TmName { get; set; }

        [NameInMap("TmNumber")]
        [Validation(Required=false)]
        public string TmNumber { get; set; }

        [NameInMap("TmType")]
        [Validation(Required=false)]
        public string TmType { get; set; }

        [NameInMap("TradeTmDetailJson")]
        [Validation(Required=false)]
        public string TradeTmDetailJson { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
