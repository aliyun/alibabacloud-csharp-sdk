// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
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
        /// <para>The AI application runtime parameters, as a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;testKey&quot;:&quot;testValue&quot;}</para>
        /// </summary>
        [NameInMap("AppParams")]
        [Validation(Required=false)]
        public string AppParams { get; set; }

        /// <summary>
        /// <para>The ID of the folder. If provided, the output is saved to this folder.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fd-cReaEcVqQK</para>
        /// </summary>
        [NameInMap("FolderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// <para>The ID of the project. If provided, the output is saved to this project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ProductionId</para>
        /// </summary>
        [NameInMap("ProductionId")]
        [Validation(Required=false)]
        public string ProductionId { get; set; }

    }

}
