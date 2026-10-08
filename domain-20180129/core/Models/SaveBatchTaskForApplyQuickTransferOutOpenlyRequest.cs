// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveBatchTaskForApplyQuickTransferOutOpenlyRequest : TeaModel {
        /// <summary>
        /// <para>The domain names to transfer out.</para>
        /// </summary>
        [NameInMap("DomainNames")]
        [Validation(Required=false)]
        public List<string> DomainNames { get; set; }

        /// <summary>
        /// <para>The language of returned error messages. Valid values: zh (Chinese) and en (English). Default value: en.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The IP address of the user\&quot;s client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
