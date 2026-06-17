// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ApplyApplicationPromptsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>An array of prompt IDs to disable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>papt-************</para>
        /// </summary>
        [NameInMap("DisabledPromptIds")]
        [Validation(Required=false)]
        public List<string> DisabledPromptIds { get; set; }

        /// <summary>
        /// <para>An array of prompt IDs to enable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>papt-************</para>
        /// </summary>
        [NameInMap("EnabledPromptIds")]
        [Validation(Required=false)]
        public List<string> EnabledPromptIds { get; set; }

    }

}
