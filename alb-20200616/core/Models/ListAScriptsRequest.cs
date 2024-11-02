// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListAScriptsRequest : TeaModel {
        /// <summary>
        /// <para>The AScript rule IDs. You can specify at most 20 IDs in each call.</para>
        /// </summary>
        [NameInMap("AScriptIds")]
        [Validation(Required=false)]
        public List<string> AScriptIds { get; set; }

        /// <summary>
        /// <para>The AScript rule names. You can specify at most 10 names in each call.</para>
        /// </summary>
        [NameInMap("AScriptNames")]
        [Validation(Required=false)]
        public List<string> AScriptNames { get; set; }

        /// <summary>
        /// <para>The listener IDs. You can specify at most 20 listener IDs in each call.</para>
        /// </summary>
        [NameInMap("ListenerIds")]
        [Validation(Required=false)]
        public List<string> ListenerIds { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return.</para>
        /// <para>Valid values: <b>1</b> to <b>100</b>.</para>
        /// <para>Default value: <b>20</b>. If you do not specify this parameter, the default value is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>You do not need to specify this parameter for the first request.****</description></item>
        /// <item><description>You must specify the token that is obtained from the previous query as the value of <b>NextToken</b>.</description></item>
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
