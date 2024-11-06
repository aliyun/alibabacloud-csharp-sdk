// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserCertificateExpireCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of domain names whose SSL certificates are about to expire within 30 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ExpireWithin30DaysCount")]
        [Validation(Required=false)]
        public int? ExpireWithin30DaysCount { get; set; }

        /// <summary>
        /// <para>The number of domain names whose SSL certificates have already expired.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("ExpiredCount")]
        [Validation(Required=false)]
        public int? ExpiredCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F5E8DF64-7175-4186-9B06-F002C0BBD0C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
