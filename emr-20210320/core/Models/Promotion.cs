// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class Promotion : TeaModel {
        /// <summary>
        /// 产品码。
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// 优惠券描述。
        /// </summary>
        [NameInMap("PromotionDesc")]
        [Validation(Required=false)]
        public string PromotionDesc { get; set; }

        /// <summary>
        /// 优惠券名称。
        /// </summary>
        [NameInMap("PromotionName")]
        [Validation(Required=false)]
        public string PromotionName { get; set; }

        /// <summary>
        /// 优惠券码。
        /// </summary>
        [NameInMap("PromotionOptionCode")]
        [Validation(Required=false)]
        public string PromotionOptionCode { get; set; }

        /// <summary>
        /// 优惠券号。
        /// </summary>
        [NameInMap("PromotionOptionNo")]
        [Validation(Required=false)]
        public string PromotionOptionNo { get; set; }

    }

}
