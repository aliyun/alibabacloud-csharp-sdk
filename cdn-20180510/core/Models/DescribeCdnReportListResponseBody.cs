// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnReportListResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the report that is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;data&quot;:[{&quot;reportId&quot;:1,&quot;deliver&quot;:{&quot;report&quot;:{&quot;title&quot;:&quot;DomainPvUv&quot;,&quot;format&quot;:&quot;chart&quot;,&quot;shape&quot;:&quot;line&quot;,&quot;xAxis&quot;:&quot;ds&quot;,&quot;yAxis&quot;:&quot;cnt&quot;,&quot;legend&quot;:&quot;cnt_type&quot;,&quot;header&quot;:[&quot;ds&quot;,&quot;cnt_type&quot;,&quot;cnt&quot;]}}}</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

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
