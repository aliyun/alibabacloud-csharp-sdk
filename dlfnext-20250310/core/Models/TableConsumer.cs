// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class TableConsumer : TeaModel {
        /// <summary>
        /// <para>Consumer ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>paimon-table1-id</para>
        /// </summary>
        [NameInMap("consumerId")]
        [Validation(Required=false)]
        public string ConsumerId { get; set; }

        /// <summary>
        /// <para>The last modified time of the consumer file in Unix milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1791792221185</para>
        /// </summary>
        [NameInMap("lastModifiedTime")]
        [Validation(Required=false)]
        public long? LastModifiedTime { get; set; }

        /// <summary>
        /// <para>The ID of the next snapshot to be consumed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("nextSnapshot")]
        [Validation(Required=false)]
        public long? NextSnapshot { get; set; }

    }

}
