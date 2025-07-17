// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListDashboardsByNameResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. The HTTP 200 status code indicates a successful request, while others indicate error conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned struct.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;Edas Ingress Url Analysis&quot;,&quot;type&quot;:&quot;edas-ingress-url-analysis&quot;,&quot;url&quot;:&quot;<a href="https://g.console.aliyun.com/d/1036052989950239-11040375-66-3/edas-ingress-url-analysis?var-clusterId=29ksa&var-regionId=cn-hangzhou%22%7D%5D">https://g.console.aliyun.com/d/1036052989950239-11040375-66-3/edas-ingress-url-analysis?var-clusterId=29ksa&amp;var-regionId=cn-hangzhou&quot;}]</a></para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request, You can use the ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2983BEF7-4A0D-47A2-94A2-8E9C5E63****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
