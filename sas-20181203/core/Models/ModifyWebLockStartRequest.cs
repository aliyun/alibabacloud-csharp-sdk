// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyWebLockStartRequest : TeaModel {
        /// <summary>
        /// <para>The prevention mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>block</b>: Interception Mode</description></item>
        /// <item><description><b>audit</b>: Alert Mode</description></item>
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
        /// <para>The directory for which you want to enable web tamper proofing. Separate multiple directories with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/home/admin/tomcat</para>
        /// </summary>
        [NameInMap("Dir")]
        [Validation(Required=false)]
        public string Dir { get; set; }

        /// <summary>
        /// <para>The directory for which you want to disable web tamper proofing.</para>
        /// <remarks>
        /// <para>If you set <b>Mode</b> to <b>blacklist</b>, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/home/admin/java</para>
        /// </summary>
        [NameInMap("ExclusiveDir")]
        [Validation(Required=false)]
        public string ExclusiveDir { get; set; }

        /// <summary>
        /// <para>The file for which you want to disable web tamper proofing.</para>
        /// <remarks>
        /// <para>If you set <b>Mode</b> to <b>blacklist</b>, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/home/admin/tomcat/localhost.log</para>
        /// </summary>
        [NameInMap("ExclusiveFile")]
        [Validation(Required=false)]
        public string ExclusiveFile { get; set; }

        /// <summary>
        /// <para>The type of the file for which you want to disable web tamper proofing. Separate multiple types with semicolons (;). Valid values:</para>
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
        /// <para>If you set <b>Mode</b> to <b>blacklist</b>, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>jpg</para>
        /// </summary>
        [NameInMap("ExclusiveFileType")]
        [Validation(Required=false)]
        public string ExclusiveFileType { get; set; }

        /// <summary>
        /// <para>The type of the file for which you want to enable web tamper proofing. Separate multiple types with semicolons (;). Valid values:</para>
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
        /// <para>If you set <b>Mode</b> to <b>whitelist</b>, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>php</para>
        /// </summary>
        [NameInMap("InclusiveFileType")]
        [Validation(Required=false)]
        public string InclusiveFileType { get; set; }

        /// <summary>
        /// <para>The local path to the backup files of the protected directory.\
        /// The directory format of a Linux server is different from that of a Windows server. You must enter the directory in the required format based on your operating system. Examples:</para>
        /// <list type="bullet">
        /// <item><description>Linux server: /usr/local/aegis/bak</description></item>
        /// <item><description>Windows server: C:\Program Files (x86)\Alibaba\Aegis\bak</description></item>
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
        /// <para>The protection mode of web tamper proofing. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>whitelist</b>: In this mode, web tamper proofing is enabled for the specified directories and file types.</description></item>
        /// <item><description><b>blacklist</b>: In this mode, web tamper proofing is enabled for the unspecified subdirectories, file types, and files in the protected directory.</description></item>
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
        /// <para>The UUID of the server for which you want to enable web tamper proofing.</para>
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
