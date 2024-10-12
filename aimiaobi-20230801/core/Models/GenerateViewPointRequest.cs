// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GenerateViewPointRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c160c841c8e54295bf2f441432785944_p_efm</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("ReferenceData")]
        [Validation(Required=false)]
        public GenerateViewPointRequestReferenceData ReferenceData { get; set; }
        public class GenerateViewPointRequestReferenceData : TeaModel {
            [NameInMap("MiniDoc")]
            [Validation(Required=false)]
            public List<string> MiniDoc { get; set; }

        }

    }

}
