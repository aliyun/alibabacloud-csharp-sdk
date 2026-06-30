// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class VoiceModerationCancelRequest : TeaModel {
        /// <summary>
        /// <para>The type of moderation service. Valid values include \<c>nickname_detection\\</c> for user nicknames. Other values are to be determined.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nickname_detection</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>The ID of the task that you want to cancel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///         &quot;taskId&quot;: &quot;xxxxx-xxxx&quot;
        ///     }</para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
