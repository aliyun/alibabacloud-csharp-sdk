// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeAttackAnalysisMaxQpsRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. The value is a UNIX timestamp. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1619798400</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is a UNIX timestamp. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1622476799</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
