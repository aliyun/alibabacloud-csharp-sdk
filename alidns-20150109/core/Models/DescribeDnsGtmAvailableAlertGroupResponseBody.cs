// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAvailableAlertGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The available alert contact groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;测试报警组\&quot;,\&quot;研发报警组\&quot;]</para>
        /// </summary>
        [NameInMap("AvailableAlertGroup")]
        [Validation(Required=false)]
        public string AvailableAlertGroup { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6856BCF6-11D6-4D7E-AC53-FD579933522B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
