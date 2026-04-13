// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAICopilot20250731.Models
{
    public class CreateChatRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;solutionDetail&quot;:{&quot;formValues&quot;:{&quot;params&quot;:{&quot;InstanceId&quot;:&quot;dsw-g54******qg9&quot;},&quot;content&quot;:{&quot;EcsSpec&quot;:&quot;ecs.gn6i-c8g1.2xlarge&quot;}},&quot;success&quot;:true}}</para>
        /// </summary>
        [NameInMap("ExtraData")]
        [Validation(Required=false)]
        public string ExtraData { get; set; }

        [NameInMap("Payload")]
        [Validation(Required=false)]
        public Dictionary<string, object> Payload { get; set; }

        [NameInMap("Question")]
        [Validation(Required=false)]
        public ChatDetail Question { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
