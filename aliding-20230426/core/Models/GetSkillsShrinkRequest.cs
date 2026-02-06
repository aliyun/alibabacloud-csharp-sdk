// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetSkillsShrinkRequest : TeaModel {
        [NameInMap("GroupIds")]
        [Validation(Required=false)]
        public string GroupIdsShrink { get; set; }

        [NameInMap("SkillIds")]
        [Validation(Required=false)]
        public string SkillIdsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("SourceIdOfAssistantId")]
        [Validation(Required=false)]
        public string SourceIdOfAssistantId { get; set; }

    }

}
