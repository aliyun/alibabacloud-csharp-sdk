// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class UnblockSendingRequest : TeaModel {
        /// <summary>
        /// <para>Blacklisted recipient\&quot;s email address</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:recipient@example.com">recipient@example.com</a></para>
        /// </summary>
        [NameInMap("BlockEmail")]
        [Validation(Required=false)]
        public string BlockEmail { get; set; }

        /// <summary>
        /// <para>Blacklist type</para>
        /// <list type="bullet">
        /// <item><description>UNSUB: Unsubscribe</description></item>
        /// <item><description>REPORT: Report</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNSUB</para>
        /// </summary>
        [NameInMap("BlockType")]
        [Validation(Required=false)]
        public string BlockType { get; set; }

        /// <summary>
        /// <para>Sender\&quot;s email address</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:sender@example.com">sender@example.com</a></para>
        /// </summary>
        [NameInMap("SenderEmail")]
        [Validation(Required=false)]
        public string SenderEmail { get; set; }

    }

}
