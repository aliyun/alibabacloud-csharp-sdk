// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateCreditPackageResponseBody : TeaModel {
        /// <summary>
        /// <para>The credit package ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crp-bt7e2t4anbq50****</para>
        /// </summary>
        [NameInMap("CreditPackageId")]
        [Validation(Required=false)]
        public string CreditPackageId { get; set; }

        /// <summary>
        /// <para>The time when the credit package takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-30 00:00:00</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>The time when the credit package expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-30 00:00:00</para>
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>223684716098****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F07A1DA1-E1EB-5CCA-8EED-12F85D32****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
