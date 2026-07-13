// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeBatchResultDetailRequest : TeaModel {
        /// <summary>
        /// <para>The type of the batch operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>DOMAIN_ADD</b>: Add domain names in batches.</para>
        /// </description></item>
        /// <item><description><para><b>DOMAIN_DEL</b>: Delete domain names in batches.</para>
        /// </description></item>
        /// <item><description><para><b>RR_ADD</b>: Add DNS records in batches.</para>
        /// </description></item>
        /// <item><description><para><b>RR_DEL</b>: Delete DNS records in batches.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you leave this parameter empty, the results are not filtered by operation type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DOMAIN_ADD</para>
        /// </summary>
        [NameInMap("BatchType")]
        [Validation(Required=false)]
        public string BatchType { get; set; }

        /// <summary>
        /// <para>The language of the request and response. The default value is <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The current page number. The default value is <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The status of the task. If you do not specify this parameter, the details of tasks in all states are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8*******</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
