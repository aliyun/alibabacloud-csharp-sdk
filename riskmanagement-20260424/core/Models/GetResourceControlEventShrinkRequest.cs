// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetResourceControlEventShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The language environment.</para>
        /// <list type="bullet">
        /// <item><description>Chinese (default): <b>zh</b></description></item>
        /// <item><description>English: <b>en</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// <para>The ID of the alert event.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09C-2PpwIzkpx2zG2fuFrAH55CpJaTK</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The list of event IDs.</para>
        /// </summary>
        [NameInMap("EventIdList")]
        [Validation(Required=false)]
        public string EventIdListShrink { get; set; }

    }

}
