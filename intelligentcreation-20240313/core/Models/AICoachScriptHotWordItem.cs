// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class AICoachScriptHotWordItem : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>849843</para>
        /// </summary>
        [NameInMap("creatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>username</para>
        /// </summary>
        [NameInMap("creatorName")]
        [Validation(Required=false)]
        public string CreatorName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-11-13 12:01:12</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-11-13 12:01:12</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("hotWord")]
        [Validation(Required=false)]
        public string HotWord { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>34532</para>
        /// </summary>
        [NameInMap("hotWordId")]
        [Validation(Required=false)]
        public string HotWordId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>892340</para>
        /// </summary>
        [NameInMap("modifierId")]
        [Validation(Required=false)]
        public string ModifierId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>username</para>
        /// </summary>
        [NameInMap("modifierName")]
        [Validation(Required=false)]
        public string ModifierName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8491340</para>
        /// </summary>
        [NameInMap("scriptRecordId")]
        [Validation(Required=false)]
        public string ScriptRecordId { get; set; }

    }

}
