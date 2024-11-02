// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class GetListenerHealthStatusRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return the health check results of forwarding rules. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeRule")]
        [Validation(Required=false)]
        public bool? IncludeRule { get; set; }

        /// <summary>
        /// <para>The listener ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsr-bp1bpn0kn908w4nbw****</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: <b>1</b> to <b>30</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that determines the start point of the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If this is your first query or no next queries are to be sent, ignore this parameter.</description></item>
        /// <item><description>If a next query is to be sent, set the value to the value of <b>NextToken</b> that is returned from the last call.</description></item>
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
