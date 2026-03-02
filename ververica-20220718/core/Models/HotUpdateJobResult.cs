// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class HotUpdateJobResult : TeaModel {
        [NameInMap("hotUpdateParams")]
        [Validation(Required=false)]
        public HotUpdateJobParams HotUpdateParams { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123hashd****</para>
        /// </summary>
        [NameInMap("jobHotUpdateId")]
        [Validation(Required=false)]
        public string JobHotUpdateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5af678c0-7db0-4650-94c2-d2604f0a****</para>
        /// </summary>
        [NameInMap("jobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public HotUpdateJobStatus Status { get; set; }

        [NameInMap("targetResourceSetting")]
        [Validation(Required=false)]
        public BriefResourceSetting TargetResourceSetting { get; set; }

    }

}
