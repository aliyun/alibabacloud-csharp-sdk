// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddClientUserDefineRuleRequest : TeaModel {
        /// <summary>
        /// <para>The action type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: allow</description></item>
        /// <item><description><b>1</b>: block</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public int? ActionType { get; set; }

        /// <summary>
        /// <para>The command line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/usr/sbin/s****</para>
        /// </summary>
        [NameInMap("Cmdline")]
        [Validation(Required=false)]
        public string Cmdline { get; set; }

        /// <summary>
        /// <para>The domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The file path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/etc/pam****</para>
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// <para>The IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.240.XX.XX</para>
        /// </summary>
        [NameInMap("IP")]
        [Validation(Required=false)]
        public string IP { get; set; }

        /// <summary>
        /// <para>The list of process hashes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c9045b5bec90f9825f1f3f64dd4****</para>
        /// </summary>
        [NameInMap("Md5List")]
        [Validation(Required=false)]
        public string Md5List { get; set; }

        /// <summary>
        /// <para>The name of the custom rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Rule1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The new file path for file rename.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/etc/pam****</para>
        /// </summary>
        [NameInMap("NewFilePath")]
        [Validation(Required=false)]
        public string NewFilePath { get; set; }

        /// <summary>
        /// <para>The parent command line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/usr/sbin/s****</para>
        /// </summary>
        [NameInMap("ParentCmdline")]
        [Validation(Required=false)]
        public string ParentCmdline { get; set; }

        /// <summary>
        /// <para>The parent process path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c:/windows/system32/i****</para>
        /// </summary>
        [NameInMap("ParentProcPath")]
        [Validation(Required=false)]
        public string ParentProcPath { get; set; }

        /// <summary>
        /// <para>The operating system type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>windows</b>: Windows</description></item>
        /// <item><description><b>linux</b>: Linux</description></item>
        /// <item><description><b>all</b>: all</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>linux</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The port number. This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The port number. Valid values: <b>1 to 65535</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("PortStr")]
        [Validation(Required=false)]
        public string PortStr { get; set; }

        /// <summary>
        /// <para>The process path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c:/windows/system32/i****</para>
        /// </summary>
        [NameInMap("ProcPath")]
        [Validation(Required=false)]
        public string ProcPath { get; set; }

        /// <summary>
        /// <para>The registry value.</para>
        /// 
        /// <b>Example:</b>
        /// <para><em>SECOH-QAD.exe</em></para>
        /// </summary>
        [NameInMap("RegistryContent")]
        [Validation(Required=false)]
        public string RegistryContent { get; set; }

        /// <summary>
        /// <para>The registry key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HKEY_DYN_****</para>
        /// </summary>
        [NameInMap("RegistryKey")]
        [Validation(Required=false)]
        public string RegistryKey { get; set; }

        /// <summary>
        /// <para>Specifies whether machines are automatically added to the rule. Default value: add. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>add</b>: Automatically added by default.</description></item>
        /// <item><description><b>del</b>: Not automatically added by default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>add</para>
        /// </summary>
        [NameInMap("TargetDefault")]
        [Validation(Required=false)]
        public string TargetDefault { get; set; }

        /// <summary>
        /// <para>The rule type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: process hash</description></item>
        /// <item><description><b>2</b>: command line</description></item>
        /// <item><description><b>3</b>: process network</description></item>
        /// <item><description><b>4</b>: file read/write</description></item>
        /// <item><description><b>5</b>: registry operation</description></item>
        /// <item><description><b>6</b>: dynamic-link library loading</description></item>
        /// <item><description><b>7</b>: file rename</description></item>
        /// <item><description><b>8</b>: network domain name</description></item>
        /// <item><description><b>9</b>: network IP</description></item>
        /// <item><description><b>10</b>: file path</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
