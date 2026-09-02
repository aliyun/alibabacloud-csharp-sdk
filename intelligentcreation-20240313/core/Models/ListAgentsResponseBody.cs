// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class ListAgentsResponseBody : TeaModel {
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<ListAgentsResponseBodyList> List { get; set; }
        public class ListAgentsResponseBodyList : TeaModel {
            [NameInMap("agentIconUrl")]
            [Validation(Required=false)]
            public string AgentIconUrl { get; set; }

            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

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

            [NameInMap("charactersDescription")]
            [Validation(Required=false)]
            public string CharactersDescription { get; set; }

            [NameInMap("enableInteraction")]
            [Validation(Required=false)]
            public int? EnableInteraction { get; set; }

            [NameInMap("industry")]
            [Validation(Required=false)]
            public string Industry { get; set; }

            [NameInMap("onlineSearch")]
            [Validation(Required=false)]
            public bool? OnlineSearch { get; set; }

            [NameInMap("owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("referenceUrl")]
            [Validation(Required=false)]
            public string ReferenceUrl { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("textStyle")]
            [Validation(Required=false)]
            public string TextStyle { get; set; }

            [NameInMap("viewer")]
            [Validation(Required=false)]
            public string Viewer { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
