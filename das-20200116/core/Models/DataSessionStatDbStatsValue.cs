// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DataSessionStatDbStatsValue : TeaModel {
        /// <summary>
        /// <para>The number of active namespaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ActiveCount")]
        [Validation(Required=false)]
        public long? ActiveCount { get; set; }

        /// <summary>
        /// <para>The total number of namespaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
