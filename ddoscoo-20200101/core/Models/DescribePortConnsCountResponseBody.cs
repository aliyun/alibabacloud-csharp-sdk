// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortConnsCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of active connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>159</para>
        /// </summary>
        [NameInMap("ActConns")]
        [Validation(Required=false)]
        public long? ActConns { get; set; }

        /// <summary>
        /// <para>The number of concurrent connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46340</para>
        /// </summary>
        [NameInMap("Conns")]
        [Validation(Required=false)]
        public long? Conns { get; set; }

        /// <summary>
        /// <para>The number of new connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Cps")]
        [Validation(Required=false)]
        public long? Cps { get; set; }

        /// <summary>
        /// <para>The number of inactive connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>121</para>
        /// </summary>
        [NameInMap("InActConns")]
        [Validation(Required=false)]
        public long? InActConns { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>48859E14-A9FB-4100-99FF-AAB75CA46776</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
