// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class PromotionInfo : TeaModel {
        /// <summary>
        /// <para>The fee that can be covered by the promotion.</para>
        /// </summary>
        [NameInMap("canPromFee")]
        [Validation(Required=false)]
        public string CanPromFee { get; set; }

        /// <summary>
        /// <para>Indicates whether the promotion is selected.</para>
        /// </summary>
        [NameInMap("isSelected")]
        [Validation(Required=false)]
        public bool? IsSelected { get; set; }

        /// <summary>
        /// <para>The description of the promotion.</para>
        /// </summary>
        [NameInMap("promotionDesc")]
        [Validation(Required=false)]
        public string PromotionDesc { get; set; }

        /// <summary>
        /// <para>The name of the promotion.</para>
        /// </summary>
        [NameInMap("promotionName")]
        [Validation(Required=false)]
        public string PromotionName { get; set; }

        /// <summary>
        /// <para>The code of the promotion option.</para>
        /// </summary>
        [NameInMap("promotionOptionCode")]
        [Validation(Required=false)]
        public string PromotionOptionCode { get; set; }

        /// <summary>
        /// <para>The number of the promotion option.</para>
        /// </summary>
        [NameInMap("promotionOptionNo")]
        [Validation(Required=false)]
        public string PromotionOptionNo { get; set; }

        /// <summary>
        /// <para>Indicates whether the promotion is selected.</para>
        /// </summary>
        [NameInMap("selected")]
        [Validation(Required=false)]
        public bool? Selected { get; set; }

    }

}
