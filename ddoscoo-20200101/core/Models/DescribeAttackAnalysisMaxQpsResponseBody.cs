// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeAttackAnalysisMaxQpsResponseBody : TeaModel {
        /// <summary>
        /// <para>The peak queries per second (QPS) of DDoS attacks. Units: QPS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>41652</para>
        /// </summary>
        [NameInMap("Qps")]
        [Validation(Required=false)]
        public long? Qps { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8DFB602D-1AAC-46C4-90F2-C84086E7A6E4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
