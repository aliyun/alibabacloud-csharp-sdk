// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class CreateCouponTemplateResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateCouponTemplateResponseBodyData Data { get; set; }
        public class CreateCouponTemplateResponseBodyData : TeaModel {
            [NameInMap("ApplicableProducts")]
            [Validation(Required=false)]
            public string ApplicableProducts { get; set; }

            [NameInMap("CostBearer")]
            [Validation(Required=false)]
            public string CostBearer { get; set; }

            [NameInMap("CouponTemplateID")]
            [Validation(Required=false)]
            public long? CouponTemplateID { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Expireddate")]
            [Validation(Required=false)]
            public string Expireddate { get; set; }

            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public List<string> ProductType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            [NameInMap("Vailddate")]
            [Validation(Required=false)]
            public string Vailddate { get; set; }

            [NameInMap("Vaildperioddays")]
            [Validation(Required=false)]
            public string Vaildperioddays { get; set; }

            [NameInMap("ValidUntil")]
            [Validation(Required=false)]
            public string ValidUntil { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
