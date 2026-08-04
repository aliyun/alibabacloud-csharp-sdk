// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class Metric : TeaModel {
        /// <summary>
        /// <para>The UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg17tmvwiokh****</para>
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        /// <summary>
        /// <para>The metric value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23000</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
