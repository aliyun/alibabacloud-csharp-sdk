// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeSlsLogstoreInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The log store that is associated with Anti-DDoS Pro and Anti-DDoS Premium.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-logstore</para>
        /// </summary>
        [NameInMap("LogStore")]
        [Validation(Required=false)]
        public string LogStore { get; set; }

        /// <summary>
        /// <para>The log project that is associated with Anti-DDoS Pro and Anti-DDoS Premium.</para>
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
        /// <para>The storage duration of logs. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// <para>The used storage capacity. Unit: bytes.</para>
        /// <remarks>
        /// <para>The statistics from Simple Log Service have a delay of approximately two hours.</para>
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
