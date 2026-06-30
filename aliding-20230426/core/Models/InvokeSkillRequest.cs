// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class InvokeSkillRequest : TeaModel {
        [NameInMap("Params")]
        [Validation(Required=false)]
        public Dictionary<string, object> Params { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SkillId")]
        [Validation(Required=false)]
        public string SkillId { get; set; }

        [NameInMap("Stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        [NameInMap("sourceIdOfAssistantId")]
        [Validation(Required=false)]
        public string SourceIdOfAssistantId { get; set; }

    }

}
