// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeEncryptRoutineUidResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned ciphertext, which contains the Alibaba Cloud account ID, timestamp, and time to live (TTL).</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXXXXj20p4UB/xgdOH5LtXXXXXX</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4DBA68F5-04A9-406B-B1E4-F2CB635E103F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
