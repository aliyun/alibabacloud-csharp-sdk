// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class CreateAliPayUrlResult : TeaModel {
        /// <summary>
        /// <para>The LM account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The LM member ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>223456789</para>
        /// </summary>
        [NameInMap("memberId")]
        [Validation(Required=false)]
        public string MemberId { get; set; }

        /// <summary>
        /// <para>The Alipay auto-debit signing URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/withhold/sign">https://example.com/withhold/sign</a></para>
        /// </summary>
        [NameInMap("zftWithholdSignUrl")]
        [Validation(Required=false)]
        public string ZftWithholdSignUrl { get; set; }

    }

}
