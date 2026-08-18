// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class SubmitApplyRecordShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The request reason.</para>
        /// <list type="bullet">
        /// <item><description><b>AR01</b>: Rectified. Request to unblock.</description></item>
        /// <item><description><b>AR02</b>: No violation found after investigation.</description></item>
        /// <item><description><b>AR03</b>: The instance or service has been shut down and cannot be operated. Request to unblock and then clear the violation information.</description></item>
        /// <item><description><b>AR04</b>: Files deleted. Request to unblock.</description></item>
        /// <item><description><b>AR05</b>: The instance has been released.</description></item>
        /// <item><description><b>AR00</b>: Other. Provide a description.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AR01</para>
        /// </summary>
        [NameInMap("ApplyRequest")]
        [Validation(Required=false)]
        public string ApplyRequest { get; set; }

        /// <summary>
        /// <para>The commitment letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;fileName\&quot;:\&quot;5a4b4xxxxd0b6.png\&quot;,\&quot;filePath\&quot;:\&quot;xxx/1cxxx7d0202.png\&quot;,\&quot;name\&quot;:\&quot;5axxxc1d0b6.png\&quot;}]</para>
        /// </summary>
        [NameInMap("CommitmentLetter")]
        [Validation(Required=false)]
        public string CommitmentLetter { get; set; }

        /// <summary>
        /// <para>The description of the situation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Rectification completed. Related websites have been shut down.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of specified event IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>43029423</para>
        /// </summary>
        [NameInMap("EventIdList")]
        [Validation(Required=false)]
        public string EventIdListShrink { get; set; }

        /// <summary>
        /// <para>The qualification proof.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;fileName\&quot;:\&quot;5a4b4xxxxd0b6.png\&quot;,\&quot;filePath\&quot;:\&quot;xxx/1cxxx7d0202.png\&quot;,\&quot;name\&quot;:\&quot;5axxxc1d0b6.png\&quot;}]</para>
        /// </summary>
        [NameInMap("QualificationProof")]
        [Validation(Required=false)]
        public string QualificationProof { get; set; }

        /// <summary>
        /// <para>Specifies whether manual review is required.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Manual review is required.</description></item>
        /// <item><description><b>false</b>: Manual review is not required.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: manual review is not required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Trial")]
        [Validation(Required=false)]
        public bool? Trial { get; set; }

    }

}
