// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class UpdateAppChatMessageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("AddedMetaData")]
        [Validation(Required=false)]
        public string AddedMetaData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FormatVersion: OOS-2019-06-01nTasks:n  - Name: runCommandn    Action: \&quot;ACS::ECS::RunCommand\&quot;n    Properties:n      commandContent: \&quot; echo Hksqj@@883289</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>81bc5a34-1d8d-4ef7-a208-7401c51b054b</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7baf7d67-1897-42ed-a380-f6ae825d6907</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

    }

}
