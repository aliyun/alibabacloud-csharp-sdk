// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyWebLockCreateConfigRequest : TeaModel {
        /// <summary>
        /// <para>The defense mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>block</b>: Block mode.</description></item>
        /// <item><description><b>audit</b>: Alert mode.</description></item>
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
        /// <para>The protected directory.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/home/admin/tomcat</para>
        /// </summary>
        [NameInMap("Dir")]
        [Validation(Required=false)]
        public string Dir { get; set; }

        /// <summary>
        /// <para>The folder to exclude from web tamper proofing protection.</para>
        /// <remarks>
        /// <para>This parameter is required when the Defense mode <b>Mode</b> is set to <b>blacklist</b> pattern.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/home/admin/test</para>
        /// </summary>
        [NameInMap("ExclusiveDir")]
        [Validation(Required=false)]
        public string ExclusiveDir { get; set; }

        /// <summary>
        /// <para>The file to exclude from web tamper proofing protection.</para>
        /// <remarks>
        /// <para>This parameter is required when the Defense mode <b>Mode</b> is set to <b>blacklist</b> pattern.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/home/admin/apache.log</para>
        /// </summary>
        [NameInMap("ExclusiveFile")]
        [Validation(Required=false)]
        public string ExclusiveFile { get; set; }

        /// <summary>
        /// <para>The file types to exclude from web tamper proofing protection. Separate multiple file types with semicolons (;). Valid values:</para>
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
        /// <para>This parameter is required when the Defense mode <b>Mode</b> is set to <b>blacklist</b> pattern.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>jpg</para>
        /// </summary>
        [NameInMap("ExclusiveFileType")]
        [Validation(Required=false)]
        public string ExclusiveFileType { get; set; }

        /// <summary>
        /// <para>The file to protect.</para>
        /// <remarks>
        /// <para>This parameter is required when the Defense mode <b>Mode</b> is set to <b>whitelist</b> pattern.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/home/admin/test.log</para>
        /// </summary>
        [NameInMap("InclusiveFile")]
        [Validation(Required=false)]
        public string InclusiveFile { get; set; }

        /// <summary>
        /// <para>The file types to protect with web tamper proofing. Separate multiple file types with semicolons (;). Valid values:</para>
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
        /// <para>This parameter is required when the Defense mode <b>Mode</b> is set to <b>whitelist</b> pattern.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>jpg</para>
        /// </summary>
        [NameInMap("InclusiveFileType")]
        [Validation(Required=false)]
        public string InclusiveFileType { get; set; }

        /// <summary>
        /// <para>The language type of the request and response. Valid values:</para>
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
        /// <para>The local backup path used for secure backup of the protected directory.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/usr/local/backup</para>
        /// </summary>
        [NameInMap("LocalBackupDir")]
        [Validation(Required=false)]
        public string LocalBackupDir { get; set; }

        /// <summary>
        /// <para>The protection directory mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>whitelist</b>: whitelist mode. Protects only the specified directories and file types.</description></item>
        /// <item><description><b>blacklist</b>: blacklist mode. Protects all subdirectories, file types, and specified files under the protected directory that are not excluded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>whitelist</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39.170.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The UUID of the server for which you want to add a protected directory.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to obtain the UUID of the server.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>inet-12345****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
