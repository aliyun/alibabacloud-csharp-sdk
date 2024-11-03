// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnDeliverListResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the tracking task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;data&quot;: [{&quot;deliverId&quot;: 1,&quot;status&quot;: &quot;enable&quot;,&quot;createTime&quot;: &quot;2020-10-14T11:19:26Z&quot;,&quot;crontab&quot;: &quot;0 0 0 \* \* ?&quot;,&quot;frequency&quot;: &quot;d&quot;,&quot;name&quot;: &quot;The name of the tracking task&quot;,&quot;dmList&quot;: [&quot;<a href="http://www.example.com%22%5D,%22reports">www.example.com&quot;],&quot;reports</a>&quot;: [{&quot;reportId&quot;: 1,&quot;conditions&quot;: [{&quot;op&quot;: &quot;in&quot;,&quot;field&quot;: &quot;prov&quot;,&quot;value&quot;: [&quot;Heilongjiang&quot;,&quot;Beijing&quot;]}} },{&quot;reportId&quot;: 2}],&quot;deliver&quot;: {&quot;email&quot;: {&quot;subject&quot;: &quot;subject&quot;,&quot;to&quot;: [&quot;<a href="mailto:example@alibaba-inc.com">example@alibaba-inc.com</a>&quot;,&quot;<a href="mailto:example@alibaba-inc.com">example@alibaba-inc.com</a>&quot;]}}}]}</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
