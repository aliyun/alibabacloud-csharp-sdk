// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyWebLockUpdateConfigRequest : TeaModel {
        /// <summary>
        /// <para>The defense mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>block</b>: Block.</description></item>
        /// <item><description><b>audit</b>: Alert.</description></item>
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
        /// <para>The full path of the directory that you want to protect.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/home/admin/tomcat</para>
        /// </summary>
        [NameInMap("Dir")]
        [Validation(Required=false)]
        public string Dir { get; set; }

        /// <summary>
        /// <para>The directory that does not require web tamper-proofing protection (excluded directory).</para>
        /// <remarks>
        /// <para>This parameter is required when the protection pattern <b>Mode</b> is set to <b>blacklist</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/home/admin/test</para>
        /// </summary>
        [NameInMap("ExclusiveDir")]
        [Validation(Required=false)]
        public string ExclusiveDir { get; set; }

        /// <summary>
        /// <para>The file that does not require web tamper-proofing protection (excluded file).</para>
        /// <remarks>
        /// <para>This parameter is required when the protection pattern <b>Mode</b> is set to <b>blacklist</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/home/admin/apache.log</para>
        /// </summary>
        [NameInMap("ExclusiveFile")]
        [Validation(Required=false)]
        public string ExclusiveFile { get; set; }

        /// <summary>
        /// <para>The file types that do not require web tamper-proofing protection (excluded file types). Separate multiple file types with semicolons (;). Valid values:</para>
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
        /// <para>This parameter is required when the protection pattern <b>Mode</b> is set to <b>blacklist</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>jpg</para>
        /// </summary>
        [NameInMap("ExclusiveFileType")]
        [Validation(Required=false)]
        public string ExclusiveFileType { get; set; }

        /// <summary>
        /// <para>The ID of the protected directory configuration that you want to modify.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeWebLockConfigList~~">DescribeWebLockConfigList</a> operation to obtain the ID of the protected directory.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>312077</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public int? Id { get; set; }

        /// <summary>
        /// <para>The file that requires protection.</para>
        /// <remarks>
        /// <para>This parameter is required when the protection pattern <b>Mode</b> is set to <b>whitelist</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/home/admin/test.log</para>
        /// </summary>
        [NameInMap("InclusiveFile")]
        [Validation(Required=false)]
        public string InclusiveFile { get; set; }

        /// <summary>
        /// <para>The file types that require web tamper-proofing protection. Separate multiple file types with semicolons (;). Valid values:</para>
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
        /// <para>This parameter is required when the protection pattern <b>Mode</b> is set to <b>whitelist</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>jpg</para>
        /// </summary>
        [NameInMap("InclusiveFileType")]
        [Validation(Required=false)]
        public string InclusiveFileType { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The local backup path for securely backing up the protected directory.<br>The format of the directory path may differ between Linux servers and Windows servers. Make sure that you enter the correct format. Refer to the following directory formats:</para>
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
        /// <para>The protection pattern. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>whitelist</b>: whitelist mode. Protects only the specified directories and file types.</description></item>
        /// <item><description><b>blacklist</b>: blacklist mode. Protects all subdirectories, file types, and files under the specified directory except those that are excluded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>blacklist</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36.112.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The UUID of the server whose protected directory you want to modify.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to obtain the UUID of the server.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4fe8e1cd-3c37-4851-b9de-124da32c****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
