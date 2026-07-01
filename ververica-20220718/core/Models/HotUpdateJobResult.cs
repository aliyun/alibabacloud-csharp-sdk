// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class HotUpdateJobResult : TeaModel {
        /// <summary>
        /// <para>动态更新参数。</para>
        /// </summary>
        [NameInMap("hotUpdateParams")]
        [Validation(Required=false)]
        public HotUpdateJobParams HotUpdateParams { get; set; }

        /// <summary>
        /// <para>动态更新id。</para>
        /// 
        /// <b>Example:</b>
        /// <para>123hashd****</para>
        /// </summary>
        [NameInMap("jobHotUpdateId")]
        [Validation(Required=false)]
        public string JobHotUpdateId { get; set; }

        /// <summary>
        /// <para>作业实例id。</para>
        /// 
        /// <b>Example:</b>
        /// <para>5af678c0-7db0-4650-94c2-d2604f0a****</para>
        /// </summary>
        [NameInMap("jobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>动态更新状态。</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public HotUpdateJobStatus Status { get; set; }

        /// <summary>
        /// <para>目标作业资源配置。</para>
        /// </summary>
        [NameInMap("targetResourceSetting")]
        [Validation(Required=false)]
        public BriefResourceSetting TargetResourceSetting { get; set; }

    }

}
