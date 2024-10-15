// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CostCenterModifyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:a@alipay.com">a@alipay.com</a></para>
        /// </summary>
        [NameInMap("alipay_no")]
        [Validation(Required=false)]
        public string AlipayNo { get; set; }

        [NameInMap("disable")]
        [Validation(Required=false)]
        public long? Disable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("number")]
        [Validation(Required=false)]
        public string Number { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public long? Scope { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>340049</para>
        /// </summary>
        [NameInMap("thirdpart_id")]
        [Validation(Required=false)]
        public string ThirdpartId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
