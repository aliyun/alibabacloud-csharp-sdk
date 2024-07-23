// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DataSessionStatClientStatsValue : TeaModel {
        /// <summary>
        /// <para>The number of clients whose IP addresses are active.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ActiveCount")]
        [Validation(Required=false)]
        public long? ActiveCount { get; set; }

        /// <summary>
        /// <para>The total number of IP addresses of clients.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
