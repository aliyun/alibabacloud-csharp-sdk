// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Companyreg20200306.Models
{
    public class DescribePartnerConfigResponseBody : TeaModel {
        [NameInMap("Contact")]
        [Validation(Required=false)]
        public string Contact { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>jinsan</para>
        /// </summary>
        [NameInMap("PartnerCode")]
        [Validation(Required=false)]
        public string PartnerCode { get; set; }

        [NameInMap("PartnerName")]
        [Validation(Required=false)]
        public string PartnerName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8179A0B3-A5D3-52F4-8845-F0ABC3CC6783</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
