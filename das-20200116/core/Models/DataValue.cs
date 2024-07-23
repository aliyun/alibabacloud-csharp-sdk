// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DataValue : TeaModel {
        /// <summary>
        /// <para>The timestamp. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1681975870000</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public string Timestamp { get; set; }

        /// <summary>
        /// <para>The value of the metric.</para>
        /// 
        /// <b>Example:</b>
        /// <para>478.28</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public object Value { get; set; }

    }

}
