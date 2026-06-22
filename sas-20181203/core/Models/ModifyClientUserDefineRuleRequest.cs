// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyClientUserDefineRuleRequest : TeaModel {
        /// <summary>
        /// <para>The action type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: allow</description></item>
        /// <item><description><b>1</b>: block.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
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
        /// <para>/etc/pam.d/su****</para>
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// <para>The IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.XX.XX</para>
        /// </summary>
        [NameInMap("IP")]
        [Validation(Required=false)]
        public string IP { get; set; }

        /// <summary>
        /// <para>The ID of the custom rule.</para>
        /// <remarks>
        /// <para>Call the <a href="~~ListClientUserDefineRules~~">ListClientUserDefineRules</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The list of process hashes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aa5ee3ed4363c9d195a591a70281****,3e522d6f3bf5cf88bb77e9ff3d13****</para>
        /// </summary>
        [NameInMap("Md5List")]
        [Validation(Required=false)]
        public string Md5List { get; set; }

        /// <summary>
        /// <para>The rule name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>规则****</para>
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
        /// <para>The parent process command line.</para>
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
        /// <para>C:/Windows/System32/cmd****</para>
        /// </summary>
        [NameInMap("ParentProcPath")]
        [Validation(Required=false)]
        public string ParentProcPath { get; set; }

        /// <summary>
        /// <para>The operating system type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>windows</b>: Windows</description></item>
        /// <item><description><b>linux</b>: Linux</description></item>
        /// <item><description><b>all</b>: all.</description></item>
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
        /// <para>The port number. Valid values: 1 to 65535.</para>
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
        /// <para>/root/1111/****</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("ProcPath")]
        [Validation(Required=false)]
        public string ProcPath { get; set; }

        /// <summary>
        /// <para>The registry value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SECOH-QAD****</para>
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
        /// <para>The rule type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: process hash</description></item>
        /// <item><description><b>2</b>: command line</description></item>
        /// <item><description><b>3</b>: process network</description></item>
        /// <item><description><b>4</b>: file read/write</description></item>
        /// <item><description><b>5</b>: registry operation</description></item>
        /// <item><description><b>6</b>: dynamic-link library loading</description></item>
        /// <item><description><b>7</b>: file rename.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
