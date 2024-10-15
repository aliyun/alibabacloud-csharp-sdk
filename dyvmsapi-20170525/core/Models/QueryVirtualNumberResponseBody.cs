// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryVirtualNumberResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The value 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the numbers associated with the virtual numbers. The following fields are returned:</para>
        /// <list type="bullet">
        /// <item><description>createTime: the time when the number was activated.</description></item>
        /// <item><description>qualificationCount: the number of qualifications.</description></item>
        /// <item><description>cityCount: the number of cities.</description></item>
        /// <item><description>phoneNumCount: the number of virtual numbers.</description></item>
        /// <item><description>remark: the additional information.</description></item>
        /// <item><description>phoneNum: the virtual number.</description></item>
        /// <item><description>routeType: the route type.</description></item>
        /// <item><description>canCancel: indicates whether the number can be deactivated.</description></item>
        /// <item><description>specCount: the number of Internet service providers (ISPs).</description></item>
        /// <item><description>status: the number state. Valid values: <b>1</b>, <b>0</b>, and <b>-1</b>. The value 1 indicates that the number is valid. The value 0 indicates that the number is invalid. The value -1 indicates that the number was deactivated.</description></item>
        /// <item><description>pageNo: the page number.</description></item>
        /// <item><description>pageSize: the number of entries per page.</description></item>
        /// <item><description>total: the total number of virtual numbers.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;data&quot;:[{&quot;createTime&quot;:&quot;2020-07-15 04:00:00&quot;,&quot;qualificationCount&quot;:0,&quot;cityCount&quot;:0,&quot;phoneNumCount&quot;:1,&quot;remark&quot;:&quot;20200715Unicom CTD shut down&quot;,&quot;phoneNum&quot;:&quot;05516214****&quot;,&quot;routeType&quot;:1,&quot;canCancel&quot;:true,&quot;specCount&quot;:0,&quot;status&quot;:&quot;1&quot;}],&quot;pageSize&quot;:1,&quot;total&quot;:17,&quot;pageNo&quot;:1}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9FF70B74-1B3C-44C1-ACDF-8DF962988F0E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
