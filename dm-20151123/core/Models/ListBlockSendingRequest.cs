// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class ListBlockSendingRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1731463398242</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public int? BeginTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:xxxx@rcpt.com">xxxx@rcpt.com</a></para>
        /// </summary>
        [NameInMap("BlockEmail")]
        [Validation(Required=false)]
        public string BlockEmail { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNSUB</para>
        /// </summary>
        [NameInMap("BlockType")]
        [Validation(Required=false)]
        public string BlockType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1732463398242</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxxyyyyyy</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:xxxx@sender.com">xxxx@sender.com</a></para>
        /// </summary>
        [NameInMap("SenderEmail")]
        [Validation(Required=false)]
        public string SenderEmail { get; set; }

    }

}
