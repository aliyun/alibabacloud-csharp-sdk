// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetSensitiveDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned sensitive data information, including totalCount (the total number of sensitive data entries) and sensDatas (the sensitive data list).
        /// The sensDatas list includes:</para>
        /// <list type="bullet">
        /// <item><description>guid: The unique ID of the tenant metadata. For example, the GUID of ODPS data consists of project.table.column.</description></item>
        /// <item><description>sensType: The sensitivity type.</description></item>
        /// <item><description>sensLevel: The sensitivity level.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{      &quot;sensDatas&quot;: [       {         &quot;sensLevel&quot;: &quot;L1&quot;,         &quot;guid&quot;: &quot;dsg_demo.animal.dog&quot;,         &quot;sensType&quot;: &quot; Name&quot;       }      ],     &quot;totalCount&quot;: 2171 }</para>
        /// </summary>
        [NameInMap("SensitiveData")]
        [Validation(Required=false)]
        public Dictionary<string, object> SensitiveData { get; set; }

    }

}
