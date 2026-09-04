// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class GetListenerHealthStatusRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to include the health check results of forwarding rules. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Include the results.</description></item>
        /// <item><description><b>false</b> (default): Do not include the results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeRule")]
        [Validation(Required=false)]
        public bool? IncludeRule { get; set; }

        /// <summary>
        /// <para>The listener ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsn-o4u54y73wq7b******</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return per page in a paginated query. Valid values: <b>1</b> to <b>30</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>Specifies whether there is a token for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>For the first query or when no next query exists, leave this parameter empty.</description></item>
        /// <item><description>If a next query exists, set this parameter to the <b>NextToken</b> value returned by the previous API call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
