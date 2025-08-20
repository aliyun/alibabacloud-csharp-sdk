// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class CheckThirdRightSendPlanShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cc</para>
        /// </summary>
        [NameInMap("BizGroup")]
        [Validation(Required=false)]
        public string BizGroup { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ailabs</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ExtendInfo")]
        [Validation(Required=false)]
        public string ExtendInfoShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>01000019100307010000600</para>
        /// </summary>
        [NameInMap("Sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SupplierId")]
        [Validation(Required=false)]
        public long? SupplierId { get; set; }

    }

}
