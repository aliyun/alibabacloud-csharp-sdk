// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class PullCashierResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned error code. <c>0</c> indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RetCode")]
        [Validation(Required=false)]
        public int? RetCode { get; set; }

        /// <summary>
        /// <para>The returned error message. No message is returned upon success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>请求成功</para>
        /// </summary>
        [NameInMap("RetMsg")]
        [Validation(Required=false)]
        public string RetMsg { get; set; }

        /// <summary>
        /// <para>The result of pulling up the checkout page. true indicates success, and false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RetValue")]
        [Validation(Required=false)]
        public bool? RetValue { get; set; }

    }

}
