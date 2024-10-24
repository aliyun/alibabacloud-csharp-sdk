// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortAttackMaxFlowResponseBody : TeaModel {
        /// <summary>
        /// <para>The peak bandwidth of attack traffic. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>149559</para>
        /// </summary>
        [NameInMap("Bps")]
        [Validation(Required=false)]
        public long? Bps { get; set; }

        /// <summary>
        /// <para>The peak packet rate of attack traffic . Unit: packets per second (pps).</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("Pps")]
        [Validation(Required=false)]
        public long? Pps { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C33EB3D5-AF96-43CA-9C7E-37A81BC06A1E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
