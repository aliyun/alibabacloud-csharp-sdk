// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class UpdateOptimizeTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;ioVersion&quot;:2,&quot;inputs&quot;:{&quot;experienceLibrary&quot;:{&quot;type&quot;:&quot;dataset&quot;,&quot;dataset&quot;:&quot;experiences&quot;},&quot;trajectory&quot;:{&quot;type&quot;:&quot;sls&quot;,&quot;project&quot;:&quot;my-project&quot;,&quot;logstore&quot;:&quot;agent-trajectory&quot;,&quot;format&quot;:&quot;atif&quot;},&quot;prompt&quot;:{&quot;type&quot;:&quot;inline&quot;,&quot;format&quot;:&quot;markdown&quot;,&quot;content&quot;:&quot;# Guidance\\nExtract evidence-backed tool contracts.&quot;}},&quot;outputs&quot;:{&quot;changePlan&quot;:{&quot;type&quot;:&quot;dataset&quot;,&quot;dataset&quot;:&quot;experience-plans&quot;}},&quot;operators&quot;:[&quot;tool_contract&quot;],&quot;application&quot;:{&quot;mode&quot;:&quot;manual&quot;}}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public Dictionary<string, object> Config { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a1b2c3d4-1234-5678-90ab-cdef12345678</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
