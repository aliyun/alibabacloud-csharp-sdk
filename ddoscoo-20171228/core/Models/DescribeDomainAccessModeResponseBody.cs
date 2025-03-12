// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeDomainAccessModeResponseBody : TeaModel {
        [NameInMap("DomainModeList")]
        [Validation(Required=false)]
        public List<DescribeDomainAccessModeResponseBodyDomainModeList> DomainModeList { get; set; }
        public class DescribeDomainAccessModeResponseBodyDomainModeList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AccessMode")]
            [Validation(Required=false)]
            public int? AccessMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
