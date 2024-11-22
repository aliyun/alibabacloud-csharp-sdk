// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetSiteCurrentNSResponseBody : TeaModel {
        /// <summary>
        /// <para>The nameservers of the website.</para>
        /// </summary>
        [NameInMap("NSList")]
        [Validation(Required=false)]
        public List<string> NSList { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2430E05E-1340-5773-B5E1-B743929F46F2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
