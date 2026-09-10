// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianVoiceBot20250101.Models
{
    public class CreateVoiceAccessProfileShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The Bailian workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-xdne77rxe14ziszr</para>
        /// </summary>
        [NameInMap("BusinessUnitId")]
        [Validation(Required=false)]
        public string BusinessUnitId { get; set; }

        /// <summary>
        /// <para>The speech engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VOLC</para>
        /// </summary>
        [NameInMap("NlsEngine")]
        [Validation(Required=false)]
        public string NlsEngine { get; set; }

        /// <summary>
        /// <para>The parameter settings.</para>
        /// </summary>
        [NameInMap("Profile")]
        [Validation(Required=false)]
        public string ProfileShrink { get; set; }

    }

}
