// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWebLockConfigListResponseBody : TeaModel {
        /// <summary>
        /// <para>The configurations of web tamper proofing.</para>
        /// </summary>
        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public List<DescribeWebLockConfigListResponseBodyConfigList> ConfigList { get; set; }
        public class DescribeWebLockConfigListResponseBodyConfigList : TeaModel {
            /// <summary>
            /// <para>The prevention mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>block</b>: Interception Mode</description></item>
            /// <item><description><b>audit</b>: Alert Mode</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>audit</para>
            /// </summary>
            [NameInMap("DefenceMode")]
            [Validation(Required=false)]
            public string DefenceMode { get; set; }

            /// <summary>
            /// <para>The directory that has web tamper proofing enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/www/tmp/</para>
            /// </summary>
            [NameInMap("Dir")]
            [Validation(Required=false)]
            public string Dir { get; set; }

            /// <summary>
            /// <para>The directory that has web tamper proofing disabled.</para>
            /// <remarks>
            /// <para>If the value of <b>Mode</b> is <b>blacklist</b>, this parameter is returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>/home/admin/tomcat</para>
            /// </summary>
            [NameInMap("ExclusiveDir")]
            [Validation(Required=false)]
            public string ExclusiveDir { get; set; }

            /// <summary>
            /// <para>The file that has web tamper proofing disabled.</para>
            /// <remarks>
            /// <para>If the value of <b>Mode</b> is <b>blacklist</b>, this parameter is returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>/home/admin/tomcat/localhost.log</para>
            /// </summary>
            [NameInMap("ExclusiveFile")]
            [Validation(Required=false)]
            public string ExclusiveFile { get; set; }

            /// <summary>
            /// <para>The type of the file that has web tamper proofing disabled.</para>
            /// <remarks>
            /// <para>If the value of <b>Mode</b> is <b>blacklist</b>, this parameter is returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>*.jpg</para>
            /// </summary>
            [NameInMap("ExclusiveFileType")]
            [Validation(Required=false)]
            public string ExclusiveFileType { get; set; }

            /// <summary>
            /// <para>The configuration ID of the protected directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The file that has web tamper proofing enabled.</para>
            /// <remarks>
            /// <para>If the value of <b>Mode</b> is <b>whitelist</b>, this parameter is returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>/home/admin/tomcat/aaa.log</para>
            /// </summary>
            [NameInMap("InclusiveFile")]
            [Validation(Required=false)]
            public string InclusiveFile { get; set; }

            /// <summary>
            /// <para>The type of the file that has web tamper proofing enabled.</para>
            /// <remarks>
            /// <para>If the value of <b>Mode</b> is <b>whitelist</b>, this parameter is returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>jpg</para>
            /// </summary>
            [NameInMap("InclusiveFileType")]
            [Validation(Required=false)]
            public string InclusiveFileType { get; set; }

            /// <summary>
            /// <para>The local path to the backup files of the protected directory.</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>blacklist</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The UUID of the server that has web tamper proofing enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80d2f7d6-31a9-4d7f-8ff4-7ecc42f8****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9354C1A-D709-4873-9AAE-41513327B247</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of directories that have web tamper proofing enabled on the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
