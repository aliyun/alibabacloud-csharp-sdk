// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CsasEdr20241122.Models
{
    public class UpdateClientRuleStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The policy action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: monitor mode</description></item>
        /// <item><description><b>1</b>: prevent startup</description></item>
        /// <item><description><b>2</b>: block mode</description></item>
        /// </list>
        /// <para>Valid values for custom rules of proactive defense (PolicyType=2):</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: whitelist and allow</description></item>
        /// <item><description><b>1</b>: blacklist and block</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public int? ActionType { get; set; }

        /// <summary>
        /// <para>Specifies whether the policy takes effect for all user groups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: no</description></item>
        /// <item><description><b>1</b>: yes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AllGroup")]
        [Validation(Required=false)]
        public int? AllGroup { get; set; }

        /// <summary>
        /// <para>The ID of the approval process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>approval-165e6738ad9d5c46</para>
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
        /// <para>The policy description.</para>
        /// <remarks>
        /// <para>The maximum length is 128 characters.</para>
        /// </remarks>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4072</para>
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
        /// <para>The list of IDs of the user groups for which the policy takes effect.</para>
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
        /// <para>The text of the primary button in the Chinese button configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("MainButtonTextCh")]
        [Validation(Required=false)]
        public string MainButtonTextCh { get; set; }

        /// <summary>
        /// <para>The text of the primary button in the English button configuration.</para>
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
        /// <item><description><b>UserGroupAll</b>: all user groups</description></item>
        /// <item><description><b>UserGroupNormal</b>: specified user groups</description></item>
        /// <item><description><b>DeviceGroupNormal</b>: specified device groups</description></item>
        /// <item><description><b>DevTagNormal</b>: specified device tags</description></item>
        /// </list>
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
        /// <para>The text of the secondary button in the Chinese button configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("MinorButtonTextCh")]
        [Validation(Required=false)]
        public string MinorButtonTextCh { get; set; }

        /// <summary>
        /// <para>The text of the secondary button in the English button configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("MinorButtonTextEn")]
        [Validation(Required=false)]
        public string MinorButtonTextEn { get; set; }

        /// <summary>
        /// <para>The policy name.</para>
        /// <remarks>
        /// <para>The maximum length is 128 characters.</para>
        /// </remarks>
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
        /// <item><description><b>linux</b></description></item>
        /// <item><description><b>windows</b></description></item>
        /// <item><description><b>mac</b></description></item>
        /// <item><description><b>all</b>: all platforms</description></item>
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
        /// <item><description><b>0</b>: software hardening</description></item>
        /// <item><description><b>1</b>: firewall</description></item>
        /// <item><description><b>2</b>: proactive defense</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
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
        /// <remarks>
        /// <para>This parameter is valid only when the policy type is firewall.</para>
        /// </remarks>
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
        public int? Priority { get; set; }

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
        /// <para>The defense rule type. Valid values: 1 to 7.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        /// <summary>
        /// <para>The list of main process names of the software for which integrity check is enabled. The elements correspond to the Process returned by GetSwitchInfoListByType.</para>
        /// </summary>
        [NameInMap("SoftWareOnList")]
        [Validation(Required=false)]
        public List<string> SoftWareOnList { get; set; }

        /// <summary>
        /// <para>The policy status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disabled</description></item>
        /// <item><description><b>1</b>: enabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The rule source for proactive defense (PolicyType=2). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SYSTEM</b>: system rules</description></item>
        /// <item><description><b>CUSTOM</b>: custom rules</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM</para>
        /// </summary>
        [NameInMap("StrategySourceType")]
        [Validation(Required=false)]
        public string StrategySourceType { get; set; }

        /// <summary>
        /// <para>Specifies whether approval requests are supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: not supported</description></item>
        /// <item><description><b>1</b>: supported</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SupportsApproval")]
        [Validation(Required=false)]
        public int? SupportsApproval { get; set; }

        /// <summary>
        /// <para>The English content in the pop-up prompt configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("UsContent")]
        [Validation(Required=false)]
        public string UsContent { get; set; }

        /// <summary>
        /// <para>The English title in the pop-up prompt configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("UsTitle")]
        [Validation(Required=false)]
        public string UsTitle { get; set; }

        /// <summary>
        /// <para>The Chinese content in the pop-up prompt configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ZhContent")]
        [Validation(Required=false)]
        public string ZhContent { get; set; }

        /// <summary>
        /// <para>The Chinese title in the pop-up prompt configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ZhTitle")]
        [Validation(Required=false)]
        public string ZhTitle { get; set; }

    }

}
