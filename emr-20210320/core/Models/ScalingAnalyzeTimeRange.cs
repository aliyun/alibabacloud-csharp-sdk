// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ScalingAnalyzeTimeRange : TeaModel {
        /// <summary>
        /// <para>结束时间。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1676441972000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>起始时间。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1676441971000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>峰谷类型。 peak/valley</para>
        /// 
        /// <b>Example:</b>
        /// <para>peak</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
