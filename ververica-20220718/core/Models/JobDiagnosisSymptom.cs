// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class JobDiagnosisSymptom : TeaModel {
        /// <summary>
        /// <para>The diagnostic result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JM资源配置过低导致作业启动慢</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The diagnostic task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>启动速度分析</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The fixing suggestions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>将 JOBManager 内存从 1Gi 改为 4Gi</para>
        /// </summary>
        [NameInMap("recommendation")]
        [Validation(Required=false)]
        public string Recommendation { get; set; }

    }

}
