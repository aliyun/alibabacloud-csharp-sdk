// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class ListCouponUsageRequest : TeaModel {
        /// <summary>
        /// <para>阿里云客户账号</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:oqevfbveuadcrduzmf@ttirv.net">oqevfbveuadcrduzmf@ttirv.net</a></para>
        /// </summary>
        [NameInMap("Account")]
        [Validation(Required=false)]
        public string Account { get; set; }

        /// <summary>
        /// <para>优惠券模版id</para>
        /// 
        /// <b>Example:</b>
        /// <para>5075915</para>
        /// </summary>
        [NameInMap("CouponTemplateId")]
        [Validation(Required=false)]
        public long? CouponTemplateId { get; set; }

        /// <summary>
        /// <para>页码</br> 
        ///  默认值为1 最小值1</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>分页行数 </br>
        ///   默认值20 最大值50 最小值1</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>优惠券状态 </br>
        /// AVAILABLE 正常 </br>
        /// EXHAUSTED 已用完 </br>
        /// EXPIRED 已过期 </br>
        /// ABANDONED 已作废 </br></para>
        /// 
        /// <b>Example:</b>
        /// <para>AVAILABLE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>T2伙伴uid
        /// 如：123456789</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456768</para>
        /// </summary>
        [NameInMap("T2PartnerUid")]
        [Validation(Required=false)]
        public long? T2PartnerUid { get; set; }

        /// <summary>
        /// <para>阿里云账号uid</para>
        /// 
        /// <b>Example:</b>
        /// <para>1133166938931507</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}
