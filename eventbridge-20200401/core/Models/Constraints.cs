// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class Constraints : TeaModel {
        /// <summary>
        /// <para>Start of the query time window (Unix milliseconds)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1717200000000</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <para>End of the query time window (Unix milliseconds)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1717200000000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

    }

}
