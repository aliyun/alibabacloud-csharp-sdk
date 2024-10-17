// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ScalingAnalyzeResult : TeaModel {
        /// <summary>
        /// <para>实际资源利用率。</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.12</para>
        /// </summary>
        [NameInMap("ActualUsage")]
        [Validation(Required=false)]
        public float? ActualUsage { get; set; }

        /// <summary>
        /// <para>理想资源用量。</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.12</para>
        /// </summary>
        [NameInMap("IdealUsage")]
        [Validation(Required=false)]
        public float? IdealUsage { get; set; }

        /// <summary>
        /// <para>固定资源释放核数（非master）core。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReleaseCores")]
        [Validation(Required=false)]
        public int? ReleaseCores { get; set; }

        /// <summary>
        /// <para>固定资源保留核数（非master）core。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReservedCores")]
        [Validation(Required=false)]
        public int? ReservedCores { get; set; }

    }

}
