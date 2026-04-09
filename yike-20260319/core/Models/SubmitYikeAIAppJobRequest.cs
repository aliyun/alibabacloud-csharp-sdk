// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class SubmitYikeAIAppJobRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sys-ao-smith-1</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sys-ao-smith-1</para>
        /// </summary>
        [NameInMap("AppParams")]
        [Validation(Required=false)]
        public string AppParams { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fd-cReaEcVqQK</para>
        /// </summary>
        [NameInMap("FolderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ProductionId</para>
        /// </summary>
        [NameInMap("ProductionId")]
        [Validation(Required=false)]
        public string ProductionId { get; set; }

    }

}
