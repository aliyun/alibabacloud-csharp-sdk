// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class CreateAgentRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://img.com">http://img.com</a></para>
        /// </summary>
        [NameInMap("agentIconUrl")]
        [Validation(Required=false)]
        public string AgentIconUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AgentAlpha</para>
        /// </summary>
        [NameInMap("agentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aiCoachPractice</para>
        /// </summary>
        [NameInMap("agentScene")]
        [Validation(Required=false)]
        public string AgentScene { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>18-22</para>
        /// </summary>
        [NameInMap("characterAgeStage")]
        [Validation(Required=false)]
        public string CharacterAgeStage { get; set; }

        [NameInMap("characterGender")]
        [Validation(Required=false)]
        public string CharacterGender { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Tom</para>
        /// </summary>
        [NameInMap("characterName")]
        [Validation(Required=false)]
        public string CharacterName { get; set; }

        [NameInMap("extraDescription")]
        [Validation(Required=false)]
        public string ExtraDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Common</para>
        /// </summary>
        [NameInMap("industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

    }

}
