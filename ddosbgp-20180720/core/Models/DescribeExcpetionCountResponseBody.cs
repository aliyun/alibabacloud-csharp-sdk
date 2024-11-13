// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeExcpetionCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of assets that are in an abnormal state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ExceptionIpCount")]
        [Validation(Required=false)]
        public int? ExceptionIpCount { get; set; }

        /// <summary>
        /// <para>The number of Anti-DDoS Origin instances that are about to expire.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ExpireTimeCount")]
        [Validation(Required=false)]
        public int? ExpireTimeCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4B45279A-B1BE-5EEE-87CA-58AF4183EA58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
