// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetUserMaxPlanQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The plan instance ID. You can obtain this value by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esa-site-b09z4sk9pbls</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The plan name.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>Free Edition: entranceplan</description></item>
        /// <item><description>Basic: basic</description></item>
        /// <item><description>Standard: medium</description></item>
        /// <item><description>Premium Edition: high</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>Entrance: entranceplan_intl</description></item>
        /// <item><description>Pro: basicplan_intl</description></item>
        /// <item><description>Premium: vipplan_intl</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>entranceplan</para>
        /// </summary>
        [NameInMap("PlanName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// <para>The quota value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44640</para>
        /// </summary>
        [NameInMap("QuotaValue")]
        [Validation(Required=false)]
        public string QuotaValue { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C6599BB6-525D-5CFF-86BC-24068E6FB3EE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
