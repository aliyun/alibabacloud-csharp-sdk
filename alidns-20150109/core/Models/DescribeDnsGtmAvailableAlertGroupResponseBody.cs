// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAvailableAlertGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned available alert groups.</para>
        /// </summary>
        [NameInMap("AvailableAlertGroup")]
        [Validation(Required=false)]
        public string AvailableAlertGroup { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6856BCF6-11D6-4D7E-AC53-FD579933522B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
