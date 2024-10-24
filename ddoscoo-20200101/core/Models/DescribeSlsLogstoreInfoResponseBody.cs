// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeSlsLogstoreInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The Logstore of the Anti-DDoS Pro or Anti-DDoS Premium instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-logstore</para>
        /// </summary>
        [NameInMap("LogStore")]
        [Validation(Required=false)]
        public string LogStore { get; set; }

        /// <summary>
        /// <para>The Logstore project of the Anti-DDoS Pro or Anti-DDoS Premium instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-project-181071506993****-cn-hangzhou</para>
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// <para>The available log storage capacity. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3298534883328</para>
        /// </summary>
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public long? Quota { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The log storage duration. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// <para>The used log storage capacity. Unit: bytes.</para>
        /// <remarks>
        /// <para>The statistics on Log Service are delayed for about two hours.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Used")]
        [Validation(Required=false)]
        public long? Used { get; set; }

    }

}
