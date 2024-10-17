// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class TimeRange : TeaModel {
        /// <summary>
        /// <para>时间范围结束时间。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1688370894339</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>时间范围开始时间。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1688370894339</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
