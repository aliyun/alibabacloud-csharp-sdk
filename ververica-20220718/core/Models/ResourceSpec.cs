// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ResourceSpec : TeaModel {
        /// <summary>
        /// <para>The CPU size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public double? Cpu { get; set; }

        /// <summary>
        /// <para>The memory size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4Gi</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public string Memory { get; set; }

    }

}
