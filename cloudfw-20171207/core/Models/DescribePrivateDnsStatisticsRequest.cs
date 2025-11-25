// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePrivateDnsStatisticsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1726305596</para>
        /// </summary>
        [NameInMap("DomainNameCreatedEndTime")]
        [Validation(Required=false)]
        public long? DomainNameCreatedEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1725864531</para>
        /// </summary>
        [NameInMap("DomainNameCreatedStartTime")]
        [Validation(Required=false)]
        public long? DomainNameCreatedStartTime { get; set; }

    }

}
