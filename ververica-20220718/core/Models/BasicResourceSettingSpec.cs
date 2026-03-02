// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class BasicResourceSettingSpec : TeaModel {
        /// <summary>
        /// <para>The number of CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public double? Cpu { get; set; }

        /// <summary>
        /// <para>The capacity of the memory. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4 GiB</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public string Memory { get; set; }

    }

}
