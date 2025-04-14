// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DashDeviceConsole20250408.Models
{
    public class PushPromptRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>chat</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("promptContent")]
        [Validation(Required=false)]
        public string PromptContent { get; set; }

    }

}
