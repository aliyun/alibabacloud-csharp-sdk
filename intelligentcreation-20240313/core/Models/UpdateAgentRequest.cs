// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class UpdateAgentRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://abc/1.jpg">http://abc/1.jpg</a></para>
        /// </summary>
        [NameInMap("agentIconUrl")]
        [Validation(Required=false)]
        public string AgentIconUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>agent</para>
        /// </summary>
        [NameInMap("agentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>18-20</para>
        /// </summary>
        [NameInMap("characterAgeStage")]
        [Validation(Required=false)]
        public string CharacterAgeStage { get; set; }

        [NameInMap("characterGender")]
        [Validation(Required=false)]
        public string CharacterGender { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ZhangSan</para>
        /// </summary>
        [NameInMap("characterName")]
        [Validation(Required=false)]
        public string CharacterName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>He is a doctor.</para>
        /// </summary>
        [NameInMap("extraDescription")]
        [Validation(Required=false)]
        public string ExtraDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Medical</para>
        /// </summary>
        [NameInMap("industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

    }

}
