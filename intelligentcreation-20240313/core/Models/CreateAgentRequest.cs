// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class CreateAgentRequest : TeaModel {
        [NameInMap("agentIconUrl")]
        [Validation(Required=false)]
        public string AgentIconUrl { get; set; }

        [NameInMap("agentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        [NameInMap("agentScene")]
        [Validation(Required=false)]
        public string AgentScene { get; set; }

        [NameInMap("characterAgeStage")]
        [Validation(Required=false)]
        public string CharacterAgeStage { get; set; }

        [NameInMap("characterGender")]
        [Validation(Required=false)]
        public string CharacterGender { get; set; }

        [NameInMap("characterName")]
        [Validation(Required=false)]
        public string CharacterName { get; set; }

        [NameInMap("extraDescription")]
        [Validation(Required=false)]
        public string ExtraDescription { get; set; }

        [NameInMap("industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

    }

}
