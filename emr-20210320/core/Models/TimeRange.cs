// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class TimeRange : TeaModel {
        /// <summary>
        /// <para>结束时间。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1676441972000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>起始时间。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1676441971000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
