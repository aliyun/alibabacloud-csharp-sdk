// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class TimeConstraint : TeaModel {
        /// <summary>
        /// <para>The end time. Valid values: 00:00 to 23:59.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23:59</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The start time. Valid values: 00:00 to 23:59.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
