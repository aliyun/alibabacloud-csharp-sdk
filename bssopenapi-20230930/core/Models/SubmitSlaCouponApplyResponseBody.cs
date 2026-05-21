// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class SubmitSlaCouponApplyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>79EE7556-0CFD-44EB-9CD6-B3B526E3A85F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6.4</para>
        /// </summary>
        [NameInMap("SumCoupon")]
        [Validation(Required=false)]
        public double? SumCoupon { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Mon Apr 27 00:00:00 CST 2026</para>
        /// </summary>
        [NameInMap("ValidEndTime")]
        [Validation(Required=false)]
        public string ValidEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Tue Oct 27 13:15:58 CST 2026</para>
        /// </summary>
        [NameInMap("ValidStartTime")]
        [Validation(Required=false)]
        public string ValidStartTime { get; set; }

    }

}
