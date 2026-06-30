// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class SubmitYikeAIAppJobRequest : TeaModel {
        /// <summary>
        /// <para>The AI application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app_test</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The runtime parameters of the AI application. The value is a string produced by JSON serialization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;testKey&quot;:&quot;testValue&quot;}</para>
        /// </summary>
        [NameInMap("AppParams")]
        [Validation(Required=false)]
        public string AppParams { get; set; }

        /// <summary>
        /// <para>The folder ID. This parameter is used to save results to the specified folder.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fd-cReaEcVqQK</para>
        /// </summary>
        [NameInMap("FolderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// <para>The project ID. This parameter is used to save results to the specified project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ProductionId</para>
        /// </summary>
        [NameInMap("ProductionId")]
        [Validation(Required=false)]
        public string ProductionId { get; set; }

    }

}
