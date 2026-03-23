// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ApplyApplicationPromptsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>papt-************</para>
        /// </summary>
        [NameInMap("DisabledPromptIds")]
        [Validation(Required=false)]
        public string DisabledPromptIdsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>papt-************</para>
        /// </summary>
        [NameInMap("EnabledPromptIds")]
        [Validation(Required=false)]
        public string EnabledPromptIdsShrink { get; set; }

    }

}
