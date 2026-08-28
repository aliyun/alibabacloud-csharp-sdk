// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class HotUpdateJobResult : TeaModel {
        /// <summary>
        /// <para>The hot update parameters.</para>
        /// </summary>
        [NameInMap("hotUpdateParams")]
        [Validation(Required=false)]
        public HotUpdateJobParams HotUpdateParams { get; set; }

        /// <summary>
        /// <para>The hot update ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123hashd****</para>
        /// </summary>
        [NameInMap("jobHotUpdateId")]
        [Validation(Required=false)]
        public string JobHotUpdateId { get; set; }

        /// <summary>
        /// <para>The job instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5af678c0-7db0-4650-94c2-d2604f0a****</para>
        /// </summary>
        [NameInMap("jobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The hot update status.</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public HotUpdateJobStatus Status { get; set; }

        /// <summary>
        /// <para>The target job resource configuration.</para>
        /// </summary>
        [NameInMap("targetResourceSetting")]
        [Validation(Required=false)]
        public BriefResourceSetting TargetResourceSetting { get; set; }

    }

}
