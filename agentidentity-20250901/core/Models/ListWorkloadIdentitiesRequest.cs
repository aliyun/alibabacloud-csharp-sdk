// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class ListWorkloadIdentitiesRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of results to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Used to request the next page of results.</para>
        /// <list type="bullet">
        /// <item><description>Leave this parameter empty for the first request.</description></item>
        /// <item><description>Pass the NextToken value returned in the previous response for subsequent requests.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6lksg167PctRcRw0nyoPjdX</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
