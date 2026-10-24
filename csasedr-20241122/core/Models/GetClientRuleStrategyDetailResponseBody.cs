// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CsasEdr20241122.Models
{
    public class GetClientRuleStrategyDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The policy information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetClientRuleStrategyDetailResponseBodyData Data { get; set; }
        public class GetClientRuleStrategyDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The policy action. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Monitor mode.</description></item>
            /// <item><description><b>1</b>: Block startup.</description></item>
            /// <item><description><b>2</b>: Block mode.</description></item>
            /// </list>
            /// <para>Valid values for custom rules of proactive defense (PolicyType=2):</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Allowlist and allow.</description></item>
            /// <item><description><b>1</b>: Blocklist and block.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public int? ActionType { get; set; }

            /// <summary>
            /// <para>Specifies whether the policy takes effect for all user groups. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: No.</description></item>
            /// <item><description><b>1</b>: Yes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AllGroup")]
            [Validation(Required=false)]
            public int? AllGroup { get; set; }

            /// <summary>
            /// <para>The approval instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-9cf803604a16410c</para>
            /// </summary>
            [NameInMap("ApprovalId")]
            [Validation(Required=false)]
            public string ApprovalId { get; set; }

            /// <summary>
            /// <para>The matched process command line.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C:\Windows\System32\RuntimeBroker.exe -Embedding</para>
            /// </summary>
            [NameInMap("Cmdline")]
            [Validation(Required=false)]
            public string Cmdline { get; set; }

            /// <summary>
            /// <para>The timestamp when the policy was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1792627200000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of usernames for which the policy does not take effect.</para>
            /// </summary>
            [NameInMap("ExcludeUserNameList")]
            [Validation(Required=false)]
            public List<string> ExcludeUserNameList { get; set; }

            /// <summary>
            /// <para>The matched file path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C:\Program Files\Example\example.exe</para>
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <para>The policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The inbound network switch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("InSwitch")]
            [Validation(Required=false)]
            public bool? InSwitch { get; set; }

            /// <summary>
            /// <para>The list of targets in the effective scope.</para>
            /// </summary>
            [NameInMap("IncludeGroupIdList")]
            [Validation(Required=false)]
            public List<string> IncludeGroupIdList { get; set; }

            /// <summary>
            /// <para>The matched IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.2.1</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The configuration of the primary button in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("MainButtonTextCh")]
            [Validation(Required=false)]
            public string MainButtonTextCh { get; set; }

            /// <summary>
            /// <para>The configuration of the primary button in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("MainButtonTextEn")]
            [Validation(Required=false)]
            public string MainButtonTextEn { get; set; }

            /// <summary>
            /// <para>The effective scope mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>UserGroupAll</b>: All user groups.</description></item>
            /// <item><description><b>UserGroupNormal</b>: Specified user groups.</description></item>
            /// <item><description><b>DeviceGroupNormal</b>: Specified device groups.</description></item>
            /// <item><description><b>DevTagNormal</b>: Specified device tags.</description></item>
            /// </list>
            /// <para>The meaning of MatchTargetIds is determined by this field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UserGroupNormal</para>
            /// </summary>
            [NameInMap("MatchMode")]
            [Validation(Required=false)]
            public string MatchMode { get; set; }

            /// <summary>
            /// <para>The list of targets in the effective scope. The meaning of the targets is determined by MatchMode.</para>
            /// </summary>
            [NameInMap("MatchTargetIds")]
            [Validation(Required=false)]
            public List<string> MatchTargetIds { get; set; }

            /// <summary>
            /// <para>The MD5 match string for the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d41d8cd98f00b204e9800998ecf8427e</para>
            /// </summary>
            [NameInMap("Md5List")]
            [Validation(Required=false)]
            public string Md5List { get; set; }

            /// <summary>
            /// <para>The configuration of the secondary button in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("MinorButtonTextCh")]
            [Validation(Required=false)]
            public string MinorButtonTextCh { get; set; }

            /// <summary>
            /// <para>The configuration of the secondary button in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("MinorButtonTextEn")]
            [Validation(Required=false)]
            public string MinorButtonTextEn { get; set; }

            /// <summary>
            /// <para>The Policy Name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The matched new file path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C:\Program Files\Example\renamed.exe</para>
            /// </summary>
            [NameInMap("NewFilePath")]
            [Validation(Required=false)]
            public string NewFilePath { get; set; }

            /// <summary>
            /// <para>The outbound network switch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OutSwitch")]
            [Validation(Required=false)]
            public bool? OutSwitch { get; set; }

            /// <summary>
            /// <para>The matched parent process command line.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C:\Windows\System32\svchost.exe -k DcomLaunch -p</para>
            /// </summary>
            [NameInMap("ParentCmdline")]
            [Validation(Required=false)]
            public string ParentCmdline { get; set; }

            /// <summary>
            /// <para>The matched parent process path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C:\Windows\System32\svchost.exe</para>
            /// </summary>
            [NameInMap("ParentProcPath")]
            [Validation(Required=false)]
            public string ParentProcPath { get; set; }

            /// <summary>
            /// <para>The platform to which the rule applies. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>linux</b>: Linux.</description></item>
            /// <item><description><b>windows</b>: Windows.</description></item>
            /// <item><description><b>mac</b>: macOS.</description></item>
            /// <item><description><b>all</b>: All platforms.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>windows</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The policy type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Software hardening.</description></item>
            /// <item><description><b>1</b>: Firewall.</description></item>
            /// <item><description><b>2</b>: Proactive defense.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public int? PolicyType { get; set; }

            /// <summary>
            /// <para>The matched port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The list of enabled ports.</para>
            /// </summary>
            [NameInMap("PortOnList")]
            [Validation(Required=false)]
            public List<string> PortOnList { get; set; }

            /// <summary>
            /// <para>The policy priority. A smaller value indicates a higher priority. Valid values: greater than 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public float? Priority { get; set; }

            /// <summary>
            /// <para>The matched process path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C:\Windows\System32\RuntimeBroker.exe</para>
            /// </summary>
            [NameInMap("ProcPath")]
            [Validation(Required=false)]
            public string ProcPath { get; set; }

            /// <summary>
            /// <para>The matched registry content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ExampleValue</para>
            /// </summary>
            [NameInMap("RegistryContent")]
            [Validation(Required=false)]
            public string RegistryContent { get; set; }

            /// <summary>
            /// <para>The matched registry key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HKEY_LOCAL_MACHINE\Software\Example</para>
            /// </summary>
            [NameInMap("RegistryKey")]
            [Validation(Required=false)]
            public string RegistryKey { get; set; }

            /// <summary>
            /// <para>The type of the defense rule. Valid values: 1 to 7.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public int? RuleType { get; set; }

            /// <summary>
            /// <para>The association key of the policy configuration, which is used to associate the policy with its process or switch configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a8d64565-ab8b-41a6-bd3d-14d0fc639285</para>
            /// </summary>
            [NameInMap("SelectionKey")]
            [Validation(Required=false)]
            public string SelectionKey { get; set; }

            /// <summary>
            /// <para>The list of main process names of the software for which integrity check is enabled. The elements correspond to the Process parameter returned by GetSwitchInfoListByType.</para>
            /// </summary>
            [NameInMap("SoftWareOnList")]
            [Validation(Required=false)]
            public List<string> SoftWareOnList { get; set; }

            /// <summary>
            /// <para>The policy switch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Disabled.</description></item>
            /// <item><description><b>1</b>: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The source of the rule for proactive defense (PolicyType=2). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SYSTEM</b>: System rule.</description></item>
            /// <item><description><b>CUSTOM</b>: Custom rule.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("StrategySourceType")]
            [Validation(Required=false)]
            public string StrategySourceType { get; set; }

            /// <summary>
            /// <para>Specifies whether reporting and approval are supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Not supported.</description></item>
            /// <item><description><b>1</b>: Supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SupportsApproval")]
            [Validation(Required=false)]
            public int? SupportsApproval { get; set; }

            /// <summary>
            /// <para>The content of the pop-up prompt in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("UsContent")]
            [Validation(Required=false)]
            public string UsContent { get; set; }

            /// <summary>
            /// <para>The title of the pop-up prompt in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("UsTitle")]
            [Validation(Required=false)]
            public string UsTitle { get; set; }

            /// <summary>
            /// <para>The content of the pop-up prompt in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ZhContent")]
            [Validation(Required=false)]
            public string ZhContent { get; set; }

            /// <summary>
            /// <para>The title of the pop-up prompt in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ZhTitle")]
            [Validation(Required=false)]
            public string ZhTitle { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier generated by Alibaba Cloud for the request and can be used to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3F931C98-2116-52B4-9C7E-C3F27641C8FF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
