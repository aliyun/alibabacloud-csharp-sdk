// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GrantPromotionOfferForPartnerRequest : TeaModel {
        /// <summary>
        /// <para>The activity ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>232</para>
        /// </summary>
        [NameInMap("ActivityId")]
        [Validation(Required=false)]
        public string ActivityId { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("BelongId")]
        [Validation(Required=false)]
        public string BelongId { get; set; }

        /// <summary>
        /// <para>The channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WECHAT</para>
        /// </summary>
        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>The employee code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WB02409424</para>
        /// </summary>
        [NameInMap("EmployeeCode")]
        [Validation(Required=false)]
        public string EmployeeCode { get; set; }

        /// <summary>
        /// <para>The operation remarks (audit information).</para>
        /// 
        /// <b>Example:</b>
        /// <para>hz-maven</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
