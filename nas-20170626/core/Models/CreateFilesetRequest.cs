// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateFilesetRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.</para>
        /// <para>The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the request ID as the client token. The request ID may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable deletion protection to allow you to release the fileset by using the console or by calling the <a href="https://help.aliyun.com/document_detail/2402263.html">DeleteFileset</a> operation.</para>
        /// <list type="bullet">
        /// <item><description>true: enables release protection.</description></item>
        /// <item><description>false (default): disables release protection.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter can protect filesets only against manual releases, but not against automatic releases.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>The description of the fileset.</para>
        /// <list type="bullet">
        /// <item><description>The description must be 2 to 128 characters in length.</description></item>
        /// <item><description>The name must start with a letter and cannot start with http:// or https://.</description></item>
        /// <item><description>The description can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run.</para>
        /// <para>During the dry run, the system checks whether the request parameters are valid and whether the requested resources are available. During the dry run, no fileset is created and no fee is incurred.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>true: performs a dry run. The system checks the required parameters, request syntax, service limits, and available Apsara File Storage NAS (NAS) resources. Otherwise, an error message is returned. If the request passes the dry run, the HTTP status code 200 is returned. No value is returned for the FsetId parameter.</description></item>
        /// <item><description>false (default): performs a dry run and sends the request. If the request passes the dry run, a fileset is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <list type="bullet">
        /// <item><description>The IDs of CPFS file systems must start with <c>cpfs-</c>. Example: cpfs-099394bd928c\<em>\</em>\<em>\</em>.</description></item>
        /// <item><description>The IDs of CPFS for Lingjun file systems must start with <c>bmcpfs-</c>. Example: bmcpfs-290w65p03ok64ya\<em>\</em>\<em>\</em>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bmcpfs-290w65p03ok64ya****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The absolute path of the fileset.</para>
        /// <list type="bullet">
        /// <item><description><para>CPFS path limits.</para>
        /// <list type="bullet">
        /// <item><description>The parent directory of the path that you specify must be an existing directory in the file system.</description></item>
        /// <item><description>The path must be 2 to 1024 characters in length.</description></item>
        /// <item><description>The path must start and end with a forward slash (/).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Path limit of CPFS for Lingjun</para>
        /// <list type="bullet">
        /// <item><description>The path must be 2 to 1024 characters in length.</description></item>
        /// <item><description>The path must start and end with a forward slash (/).</description></item>
        /// <item><description>The fileset path must be a new path and cannot be an existing path. Fileset paths cannot be renamed and cannot be symbolic links.</description></item>
        /// <item><description>The maximum depth supported by a fileset path is eight levels. The depth of the root directory / is 0 levels. For example, the fileset path /test/aaa/ccc/ has three levels.</description></item>
        /// <item><description>If the fileset path is a multi-level path, the parent directory must be an existing directory.</description></item>
        /// <item><description>Nested filesets are not supported. If a fileset is specified as a parent directory, its subdirectory cannot be a fileset. A fileset path supports only one quota.</description></item>
        /// <item><description>The path cannot exceed 990 characters in length.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test/</para>
        /// </summary>
        [NameInMap("FileSystemPath")]
        [Validation(Required=false)]
        public string FileSystemPath { get; set; }

        /// <summary>
        /// <para>The quota information.</para>
        /// <remarks>
        /// <para> Only CPFS for Lingjun V2.7.0 and later support this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public CreateFilesetRequestQuota Quota { get; set; }
        public class CreateFilesetRequestQuota : TeaModel {
            /// <summary>
            /// <para>The file quantity quota. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Minimum value: 100000.</description></item>
            /// <item><description>Maximum value: 10000000000.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("FileCountLimit")]
            [Validation(Required=false)]
            public long? FileCountLimit { get; set; }

            /// <summary>
            /// <para>The total quota capacity limit. Unit: bytes.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Minimum value: 10,737,418,240 (10 GiB).</description></item>
            /// <item><description>Step size: 1073741824 (1 GiB).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10737418240</para>
            /// </summary>
            [NameInMap("SizeLimit")]
            [Validation(Required=false)]
            public long? SizeLimit { get; set; }

        }

    }

}
