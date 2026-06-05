// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class CreateComfyTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hive-26cd567b35c04a0a90f017388207b232</para>
        /// </summary>
        [NameInMap("HiveId")]
        [Validation(Required=false)]
        public string HiveId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;2&quot;:{&quot;text&quot;:&quot;masterpiece, best quality, beautiful cat, sunny day&quot;},&quot;3&quot;:{&quot;text&quot;:&quot;low quality, worst quality, blurry, watermark, text, signature&quot;}}</para>
        /// </summary>
        [NameInMap("UserParameters")]
        [Validation(Required=false)]
        public string UserParameters { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wf_adb32aed-ccdc-42ae-b4d4-a21181ac8a5f</para>
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

    }

}
