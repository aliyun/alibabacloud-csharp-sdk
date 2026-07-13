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
        /// <item><description><para><b>DOMAIN_ADD</b>: Batch add domain names.</para>
        /// </description></item>
        /// <item><description><para><b>DOMAIN_DEL</b>: Batch delete domain names.</para>
        /// </description></item>
        /// <item><description><para><b>RR_ADD</b>: Batch add DNS records.</para>
        /// </description></item>
        /// <item><description><para><b>RR_DEL</b>: Batch delete DNS records.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you leave this parameter empty, no filter is applied.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DOMAIN_ADD</para>
        /// </summary>
        [NameInMap("BatchType")]
        [Validation(Required=false)]
        public string BatchType { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
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
        /// <para>The task ID.</para>
        /// <remarks>
        /// <para>If you specify a task ID, the results of that task are returned. If you leave this parameter empty, the results of the most recent task are returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
