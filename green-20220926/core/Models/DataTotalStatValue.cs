// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class DataTotalStatValue : TeaModel {
        /// <summary>
        /// <para>The total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        /// <summary>
        /// <para>The proportion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12.50%</para>
        /// </summary>
        [NameInMap("Share")]
        [Validation(Required=false)]
        public string Share { get; set; }

    }

}
