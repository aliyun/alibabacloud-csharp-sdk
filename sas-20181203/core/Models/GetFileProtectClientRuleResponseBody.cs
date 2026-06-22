// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileProtectClientRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileProtectClientRuleResponseBodyData Data { get; set; }
        public class GetFileProtectClientRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The alert notification level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: no alert</para>
            /// </description></item>
            /// <item><description><para>1: reminder</para>
            /// </description></item>
            /// <item><description><para>2: suspicious</para>
            /// </description></item>
            /// <item><description><para>3: high-risk.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AlertLevel")]
            [Validation(Required=false)]
            public int? AlertLevel { get; set; }

            /// <summary>
            /// <para>The list of excluded users.</para>
            /// </summary>
            [NameInMap("ExcludeUsers")]
            [Validation(Required=false)]
            public List<string> ExcludeUsers { get; set; }

            /// <summary>
            /// <para>The operations performed on files.</para>
            /// </summary>
            [NameInMap("FileOps")]
            [Validation(Required=false)]
            public List<string> FileOps { get; set; }

            /// <summary>
            /// <para>The monitored file paths. Wildcards are supported.</para>
            /// </summary>
            [NameInMap("FilePaths")]
            [Validation(Required=false)]
            public List<string> FilePaths { get; set; }

            /// <summary>
            /// <para>The protected file types.</para>
            /// </summary>
            [NameInMap("FileTypes")]
            [Validation(Required=false)]
            public List<string> FileTypes { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3119</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The operating system type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>windows</b>: Windows</description></item>
            /// <item><description><b>linux</b>: Linux.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>linux</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The process paths. Wildcards are supported.</para>
            /// </summary>
            [NameInMap("ProcPaths")]
            [Validation(Required=false)]
            public List<string> ProcPaths { get; set; }

            /// <summary>
            /// <para>The action that the rule takes on the client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>monitor: alert</para>
            /// </description></item>
            /// <item><description><para>block: block</para>
            /// </description></item>
            /// <item><description><para>pass: allow.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pass</para>
            /// </summary>
            [NameInMap("RuleAction")]
            [Validation(Required=false)]
            public string RuleAction { get; set; }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The rule status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled.</description></item>
            /// <item><description><b>1</b>: enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The switch ID that corresponds to the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER-CONTAINER-RULE-SWITCH-TYPE_***</para>
            /// </summary>
            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>79CFF74D-E967-5407-8A78-EE03B925****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
