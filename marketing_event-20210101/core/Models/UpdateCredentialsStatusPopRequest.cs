// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Marketing_event20210101.Models
{
    public class UpdateCredentialsStatusPopRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>4546-100000</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("ProxyRecipientName")]
        [Validation(Required=false)]
        public string ProxyRecipientName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>14787627188</para>
        /// </summary>
        [NameInMap("ProxyRecipientPhoneNumber")]
        [Validation(Required=false)]
        public string ProxyRecipientPhoneNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Z30</para>
        /// </summary>
        [NameInMap("ReceiptLocation")]
        [Validation(Required=false)]
        public string ReceiptLocation { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>429005111100000</para>
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
