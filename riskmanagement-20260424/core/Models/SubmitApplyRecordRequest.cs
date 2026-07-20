// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class SubmitApplyRecordRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AR01</para>
        /// </summary>
        [NameInMap("ApplyRequest")]
        [Validation(Required=false)]
        public string ApplyRequest { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{\&quot;fileName\&quot;:\&quot;5a4b4xxxxd0b6.png\&quot;,\&quot;filePath\&quot;:\&quot;xxx/1cxxx7d0202.png\&quot;,\&quot;name\&quot;:\&quot;5axxxc1d0b6.png\&quot;}]</para>
        /// </summary>
        [NameInMap("CommitmentLetter")]
        [Validation(Required=false)]
        public string CommitmentLetter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>已经整改，关掉相关网站。</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>43029423</para>
        /// </summary>
        [NameInMap("EventIdList")]
        [Validation(Required=false)]
        public List<string> EventIdList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{\&quot;fileName\&quot;:\&quot;5a4b4xxxxd0b6.png\&quot;,\&quot;filePath\&quot;:\&quot;xxx/1cxxx7d0202.png\&quot;,\&quot;name\&quot;:\&quot;5axxxc1d0b6.png\&quot;}]</para>
        /// </summary>
        [NameInMap("QualificationProof")]
        [Validation(Required=false)]
        public string QualificationProof { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Trial")]
        [Validation(Required=false)]
        public bool? Trial { get; set; }

    }

}
