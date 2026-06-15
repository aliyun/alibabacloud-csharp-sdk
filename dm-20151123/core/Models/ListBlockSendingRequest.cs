// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class ListBlockSendingRequest : TeaModel {
        /// <summary>
        /// <para>The start of the time range to query blocked emails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1763973206</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public int? BeginTime { get; set; }

        /// <summary>
        /// <para>The recipient email address.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:xxxx@rcpt.com">xxxx@rcpt.com</a></para>
        /// </summary>
        [NameInMap("BlockEmail")]
        [Validation(Required=false)]
        public string BlockEmail { get; set; }

        /// <summary>
        /// <para>The type of block.</para>
        /// <list type="bullet">
        /// <item><description><para>UNSUB: Unsubscribe</para>
        /// </description></item>
        /// <item><description><para>REPORT: Spam report</para>
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
        /// <para>The end of the time range to query blocked emails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1764146006</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return.<br>
        /// Valid values: 1 to 500.<br></para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to start the query. If you do not specify this parameter, the query starts from the beginning of the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxyyyyyy</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sender email address.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:xxxx@sender.com">xxxx@sender.com</a></para>
        /// </summary>
        [NameInMap("SenderEmail")]
        [Validation(Required=false)]
        public string SenderEmail { get; set; }

    }

}
