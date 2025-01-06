// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class ExportConversationDetailsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>6203fc87271a420c98eab6c2bbc2d856</para>
        /// </summary>
        [NameInMap("ExportTaskId")]
        [Validation(Required=false)]
        public string ExportTaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>75BAAB9B-40B2-5FF5-A59A-7BCF8154C6EE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
