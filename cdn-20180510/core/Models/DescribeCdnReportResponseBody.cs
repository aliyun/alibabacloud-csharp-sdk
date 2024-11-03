// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The content of the operations report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;data&quot;:[{&quot;deliver&quot;:{&quot;report&quot;:{&quot;title&quot;:&quot;TopUrlByAcc&quot;,&quot;format&quot;:&quot;table&quot;,&quot;shape&quot;:&quot;&quot;,&quot;header&quot;:[&quot;url&quot;,&quot;traf&quot;,&quot;traf_rate&quot;,&quot;acc&quot;,&quot;acc_rate&quot;]}},&quot;data&quot;:[{&quot;acc&quot;:440,&quot;acc_rate&quot;:&quot;0.200%&quot;,&quot;traf&quot;:22,&quot;url&quot;:&quot;<a href="http://demo.com%22,%22traf_rate%22:%220.100%%22%7D,%7B%22acc%22:440,%22acc_rate%22:%220.200%%22,%22traf%22:22,%22url%22:%22http://demo.com%22,%22traf_rate%22:%220.100%%22%7D%5D%7D%5D%7D%7D">http://demo.com&quot;,&quot;traf_rate&quot;:&quot;0.100%&quot;},{&quot;acc&quot;:440,&quot;acc_rate&quot;:&quot;0.200%&quot;,&quot;traf&quot;:22,&quot;url&quot;:&quot;http://demo.com&quot;,&quot;traf_rate&quot;:&quot;0.100%&quot;}]}]}}</a></para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public Dictionary<string, object> Content { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
