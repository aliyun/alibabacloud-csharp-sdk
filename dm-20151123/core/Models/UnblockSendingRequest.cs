// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class UnblockSendingRequest : TeaModel {
        /// <summary>
        /// <para>The blacklisted recipient address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:recipient@yyy.com">recipient@yyy.com</a></para>
        /// </summary>
        [NameInMap("BlockEmail")]
        [Validation(Required=false)]
        public string BlockEmail { get; set; }

        /// <summary>
        /// <para>The blacklist type.</para>
        /// <list type="bullet">
        /// <item><description><para>UNSUB: Unsubscribe</para>
        /// </description></item>
        /// <item><description><para>REPORT: Complaint</para>
        /// </description></item>
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
        /// <para>The sender address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:sender@xxx.com">sender@xxx.com</a></para>
        /// </summary>
        [NameInMap("SenderEmail")]
        [Validation(Required=false)]
        public string SenderEmail { get; set; }

    }

}
