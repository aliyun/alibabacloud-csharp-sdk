// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeNodeMetricsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("NodeMetrics")]
        [Validation(Required=false)]
        public string NodeMetrics { get; set; }

        /// <summary>
        /// <para>You can call this operation to query the detailed metrics information of an OceanBase Database node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <pre><c>http(s)://[Endpoint]/?Action=DescribeNodeMetrics
        /// &amp;InstanceId=ob317v4uif****
        /// &amp;PageSize=10
        /// &amp;PageNumber=1
        /// &amp;TenantId=ob2mr3oae0****
        /// &amp;StartTime=2021-06-13 15:40:43
        /// &amp;EndTime=2021-09-13 15:40:43
        /// &amp;Metrics=tps
        /// &amp;NodeName=i-bp16niirq4zdmgvm****
        /// &amp;NodeIdList=[&quot;i-bp19y05uq6xpacyqnlrc&quot;,&quot;i-bp1blcr3htr3g3u2vqvu&quot;,&quot;i-bp1392ikhayhr3hi4fli&quot;]
        /// &amp;Common request parameters
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
