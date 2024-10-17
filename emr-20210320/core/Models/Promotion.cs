// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class Promotion : TeaModel {
        /// <summary>
        /// <para>产品码。</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>优惠券描述。</para>
        /// 
        /// <b>Example:</b>
        /// <para>5元优惠券（有效期至23年8月11日）</para>
        /// </summary>
        [NameInMap("PromotionDesc")]
        [Validation(Required=false)]
        public string PromotionDesc { get; set; }

        /// <summary>
        /// <para>优惠券名称。</para>
        /// 
        /// <b>Example:</b>
        /// <para>5元优惠券</para>
        /// </summary>
        [NameInMap("PromotionName")]
        [Validation(Required=false)]
        public string PromotionName { get; set; }

        /// <summary>
        /// <para>优惠券码。</para>
        /// 
        /// <b>Example:</b>
        /// <para>youhui_quan</para>
        /// </summary>
        [NameInMap("PromotionOptionCode")]
        [Validation(Required=false)]
        public string PromotionOptionCode { get; set; }

        /// <summary>
        /// <para>优惠券号。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABC123</para>
        /// </summary>
        [NameInMap("PromotionOptionNo")]
        [Validation(Required=false)]
        public string PromotionOptionNo { get; set; }

    }

}
