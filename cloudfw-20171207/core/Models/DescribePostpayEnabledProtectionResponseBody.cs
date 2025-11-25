// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePostpayEnabledProtectionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("DisabledDays")]
        [Validation(Required=false)]
        public long? DisabledDays { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>nat</para>
        /// </summary>
        [NameInMap("DisabledType")]
        [Validation(Required=false)]
        public string DisabledType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsEnabledProtection")]
        [Validation(Required=false)]
        public bool? IsEnabledProtection { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsOpenButDisabled")]
        [Validation(Required=false)]
        public bool? IsOpenButDisabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>95CA5E2B-E5FB-5838-BC50-6A2C763C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
