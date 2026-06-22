// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyWebLockStartRequest : TeaModel {
        /// <summary>
        /// <para>The defense mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>block</b>: block</description></item>
        /// <item><description><b>audit</b>: alert.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>block</para>
        /// </summary>
        [NameInMap("DefenceMode")]
        [Validation(Required=false)]
        public string DefenceMode { get; set; }

        /// <summary>
        /// <para>The protection directories. Separate multiple directories with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/home/admin/tomcat</para>
        /// </summary>
        [NameInMap("Dir")]
        [Validation(Required=false)]
        public string Dir { get; set; }

        /// <summary>
        /// <para>The folder that does not require web tamper proofing protection (excluded folder).</para>
        /// <remarks>
        /// <para>This parameter is required when the Defense mode <b>Mode</b> is set to the <b>blacklist</b> pattern.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/home/admin/java</para>
        /// </summary>
        [NameInMap("ExclusiveDir")]
        [Validation(Required=false)]
        public string ExclusiveDir { get; set; }

        /// <summary>
        /// <para>The files that do not require web tamper proofing protection (excluded files).</para>
        /// <remarks>
        /// <para>This parameter is required when the Defense mode <b>Mode</b> is set to the <b>blacklist</b> pattern.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/home/admin/tomcat/localhost.log</para>
        /// </summary>
        [NameInMap("ExclusiveFile")]
        [Validation(Required=false)]
        public string ExclusiveFile { get; set; }

        /// <summary>
        /// <para>The file types that do not require web tamper proofing protection (excluded file types). Separate multiple file types with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>php</description></item>
        /// <item><description>jsp</description></item>
        /// <item><description>asp</description></item>
        /// <item><description>aspx</description></item>
        /// <item><description>js</description></item>
        /// <item><description>cgi</description></item>
        /// <item><description>html</description></item>
        /// <item><description>htm</description></item>
        /// <item><description>xml</description></item>
        /// <item><description>shtml</description></item>
        /// <item><description>shtm</description></item>
        /// <item><description>jpg</description></item>
        /// <item><description>gif</description></item>
        /// <item><description>png</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when the Defense mode <b>Mode</b> is set to the <b>blacklist</b> pattern.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>jpg</para>
        /// </summary>
        [NameInMap("ExclusiveFileType")]
        [Validation(Required=false)]
        public string ExclusiveFileType { get; set; }

        /// <summary>
        /// <para>The file types that require web tamper proofing protection. Separate multiple file types with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>php</description></item>
        /// <item><description>jsp</description></item>
        /// <item><description>asp</description></item>
        /// <item><description>aspx</description></item>
        /// <item><description>js</description></item>
        /// <item><description>cgi</description></item>
        /// <item><description>html</description></item>
        /// <item><description>htm</description></item>
        /// <item><description>xml</description></item>
        /// <item><description>shtml</description></item>
        /// <item><description>shtm</description></item>
        /// <item><description>jpg</description></item>
        /// <item><description>gif</description></item>
        /// <item><description>png</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when the Defense mode <b>Mode</b> is set to the <b>whitelist</b> pattern.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>php</para>
        /// </summary>
        [NameInMap("InclusiveFileType")]
        [Validation(Required=false)]
        public string InclusiveFileType { get; set; }

        /// <summary>
        /// <para>The local backup path used to back up the protection directories. The format of the protection directory path may differ between Linux servers and Windows servers. Make sure that you enter the path in the correct format. The following examples show the directory formats:</para>
        /// <list type="bullet">
        /// <item><description>Linux server: /usr/local/aegis/bak</description></item>
        /// <item><description>Windows server: C:\Program Files (x86)\Alibaba\Aegis\bak.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/usr/local/backup</para>
        /// </summary>
        [NameInMap("LocalBackupDir")]
        [Validation(Required=false)]
        public string LocalBackupDir { get; set; }

        /// <summary>
        /// <para>The protection type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>whitelist</b>: whitelist mode. Protects the specified protection directories and file types.</description></item>
        /// <item><description><b>blacklist</b>: blacklist mode. Protects all subdirectories, file types, and specified files in the protection directories that are not excluded.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>whitelist</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The UUID of the server that you want to protect.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80d2f7d6-31a9-4d7f-8ff4-7ecc42f89ca****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
