// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class TimeConstraint : TeaModel {
        /// <summary>
        /// <para>结束时间。取值范围：00:00:00至23:59:59</para>
        /// 
        /// <b>Example:</b>
        /// <para>23:59:59</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>开始时间。取值范围：00:00:00至23:59:59</para>
        /// 
        /// <b>Example:</b>
        /// <para>06:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
