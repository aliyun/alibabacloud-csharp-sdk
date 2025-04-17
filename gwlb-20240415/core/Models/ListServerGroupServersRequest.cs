// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gwlb20240415.Models
{
    public class ListServerGroupServersRequest : TeaModel {
        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Valid values: 1 to 1000.</para>
        /// <para>Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If a value of <b>NextToken</b> is returned, the value indicates the token that is used for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The server group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sgp-atstuj3rtoptyui****</para>
        /// </summary>
        [NameInMap("ServerGroupId")]
        [Validation(Required=false)]
        public string ServerGroupId { get; set; }

        /// <summary>
        /// <para>The server IDs.</para>
        /// <para>You can specify at most 200 servers in each call.</para>
        /// </summary>
        [NameInMap("ServerIds")]
        [Validation(Required=false)]
        public List<string> ServerIds { get; set; }

        /// <summary>
        /// <para>The server IP addresses.</para>
        /// <para>You can specify at most 200 servers in each call.</para>
        /// </summary>
        [NameInMap("ServerIps")]
        [Validation(Required=false)]
        public List<string> ServerIps { get; set; }

        /// <summary>
        /// <para>The number of entries to be skipped in the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Skip")]
        [Validation(Required=false)]
        public int? Skip { get; set; }

    }

}
