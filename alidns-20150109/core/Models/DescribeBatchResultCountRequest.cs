// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeBatchResultCountRequest : TeaModel {
        /// <summary>
        /// <para>The type of the batch operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DOMAIN_ADD</b>: adds domain names in batches.</description></item>
        /// <item><description><b>DOMAIN_DEL</b>: deletes domain names in batches.</description></item>
        /// <item><description><b>RR_ADD</b>: adds Domain Name System (DNS) records in batches.</description></item>
        /// <item><description><b>RR_DEL</b>: deletes DNS records in batches.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DOMAIN_ADD</para>
        /// </summary>
        [NameInMap("BatchType")]
        [Validation(Required=false)]
        public string BatchType { get; set; }

        /// <summary>
        /// <para>The language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// <para>If you specify TaskId, the execution result of the specified task is returned. If you do not specify TaskId, the execution result of the last task is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
