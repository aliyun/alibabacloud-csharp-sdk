// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListAScriptsResponseBody : TeaModel {
        /// <summary>
        /// <para>The AScript rules.</para>
        /// </summary>
        [NameInMap("AScripts")]
        [Validation(Required=false)]
        public List<ListAScriptsResponseBodyAScripts> AScripts { get; set; }
        public class ListAScriptsResponseBodyAScripts : TeaModel {
            /// <summary>
            /// <para>The AScript rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>as-aznwocxofkakf7****</para>
            /// </summary>
            [NameInMap("AScriptId")]
            [Validation(Required=false)]
            public string AScriptId { get; set; }

            /// <summary>
            /// <para>The name of the AScript rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AScriptName")]
            [Validation(Required=false)]
            public string AScriptName { get; set; }

            /// <summary>
            /// <para>The status of the AScript rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b></description></item>
            /// <item><description><b>Available</b></description></item>
            /// <item><description><b>Configuring</b></description></item>
            /// <item><description><b>Deleting</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("AScriptStatus")]
            [Validation(Required=false)]
            public string AScriptStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the AScript rule is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The listener ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lsn-t0w1m9r6suiwmc****</para>
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// <para>The Application Load Balancer (ALB) instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alb-vv9rg2ub31tyec****</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <para>The content of the AScript rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{test}</para>
            /// </summary>
            [NameInMap("ScriptContent")]
            [Validation(Required=false)]
            public string ScriptContent { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value is the token that determines the start point of the next query.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2CA81429-F160-593A-8AB5-A2A9617845B9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// <remarks>
        /// <para>This parameter is optional. By default, this parameter is not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
