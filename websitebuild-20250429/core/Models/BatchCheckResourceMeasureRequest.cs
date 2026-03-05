// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class BatchCheckResourceMeasureRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("BelongId")]
        [Validation(Required=false)]
        public string BelongId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("BelongIdType")]
        [Validation(Required=false)]
        public string BelongIdType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>p20202933455</para>
        /// </summary>
        [NameInMap("EspBizId")]
        [Validation(Required=false)]
        public string EspBizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;siteversion&quot;:&quot;test&quot;}</para>
        /// </summary>
        [NameInMap("OrderComponentParams")]
        [Validation(Required=false)]
        public string OrderComponentParams { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[
        ///                   {
        ///                     &quot;resourceCode&quot;: &quot;InspirationTokens&quot;,
        ///                     &quot;resourceValue&quot;: &quot;0&quot;
        ///                   }
        ///                 ]</para>
        /// </summary>
        [NameInMap("ResourceCheckItems")]
        [Validation(Required=false)]
        public string ResourceCheckItems { get; set; }

    }

}
