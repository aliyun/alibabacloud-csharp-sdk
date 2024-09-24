// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileProtectDashboardResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileProtectDashboardResponseBodyData Data { get; set; }
        public class GetFileProtectDashboardResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The total number of enabled rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("EnableRuleCount")]
            [Validation(Required=false)]
            public int? EnableRuleCount { get; set; }

            /// <summary>
            /// <para>The total number of servers on which the Security Center agent is installed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("PluginCount")]
            [Validation(Required=false)]
            public int? PluginCount { get; set; }

            /// <summary>
            /// <para>The total number of servers on which the Security Center agent is offline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PluginOfflineCount")]
            [Validation(Required=false)]
            public int? PluginOfflineCount { get; set; }

            /// <summary>
            /// <para>The total number of servers on which the Security Center agent is online.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("PluginOnlineCount")]
            [Validation(Required=false)]
            public int? PluginOnlineCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6673D49C-A9AB-40DD-B4A2-B92306701AE7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
