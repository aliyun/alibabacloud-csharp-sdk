// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateFilesetRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests.</para>
        /// <para>The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-4266554*****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The release protection property of the instance. Specifies whether the instance can be released by using the console or the <a href="https://help.aliyun.com/document_detail/2402263.html">DeleteFileset</a> operation.</para>
        /// <list type="bullet">
        /// <item><description>true: Enables release protection for the instance.</description></item>
        /// <item><description>false (default): Disables release protection for the instance.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This property only restricts manual release operations and does not take effect on system-initiated release operations.</para>
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
        /// <item><description>The description must start with a letter or Chinese character and cannot start with http:// or https://.</description></item>
        /// <item><description>The description can contain digits, colons (:), underscores (_), or hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Internal affairs directory</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run for this request.</para>
        /// <para>A dry run checks parameter validity and resource availability without actually creating the instance or incurring charges.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Sends a dry run request without creating the instance. The check items include required parameters, request format, business restrictions, and NAS inventory. If the check fails, the corresponding error is returned. If the check succeeds, HTTP status code 200 is returned, but FsetId is empty.</description></item>
        /// <item><description>false (default): Sends a normal request. After the check succeeds, the instance is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The file system ID.</para>
        /// <list type="bullet">
        /// <item><description><para>CPFS: The ID must start with <c>cpfs-</c>, such as cpfs-099394bd928c\<em>\</em>\<em>\</em>.</para>
        /// </description></item>
        /// <item><description><para>CPFS for Lingjun: The ID must start with <c>bmcpfs-</c>, such as bmcpfs-290w65p03ok64ya\<em>\</em>\<em>\</em>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bmcpfs-290w65p03ok64y*****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The absolute path of the fileset to create.</para>
        /// <list type="bullet">
        /// <item><description>Path restrictions for CPFS:<list type="bullet">
        /// <item><description>The parent directory of the specified directory must be an existing directory in the file system.</description></item>
        /// <item><description>The path must be 2 to 1,024 characters in length.</description></item>
        /// <item><description>The specified directory must start and end with a forward slash (/).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Path restrictions for CPFS for Lingjun:<list type="bullet">
        /// <item><description>The path must be 2 to 1,024 characters in length.</description></item>
        /// <item><description>The specified directory must start and end with a forward slash (/).</description></item>
        /// <item><description>The fileset path must be a new path and cannot be an existing path. Renaming a fileset path is not supported, and the path cannot be a symbolic link.</description></item>
        /// <item><description>The maximum depth of a fileset path is 8 levels, with the root directory / as level 0. For example, a fileset path of /test/aaa/ccc/ has a depth of 3 levels.</description></item>
        /// <item><description>If the fileset path contains multiple directory levels, the parent directory must be an existing directory.</description></item>
        /// <item><description>Nesting filesets within a fileset is not supported. If a parent directory is already specified as a fileset, its subdirectories cannot be specified as filesets. Only one quota is supported for each fileset path.</description></item>
        /// <item><description>The total path length cannot exceed 990 characters.</description></item>
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
        /// <para>This parameter is supported only for CPFS for Lingjun 2.7.0 and later.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public CreateFilesetRequestQuota Quota { get; set; }
        public class CreateFilesetRequestQuota : TeaModel {
            /// <summary>
            /// <para>The file count limit of the quota. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Minimum value: 10,000.</para>
            /// </description></item>
            /// <item><description><para>Maximum value: 10,000,000,000.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("FileCountLimit")]
            [Validation(Required=false)]
            public long? FileCountLimit { get; set; }

            /// <summary>
            /// <para>The total capacity limit of the quota. Unit: bytes.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Minimum value: 10,737,418,240 (10 GiB).</para>
            /// </description></item>
            /// <item><description><para>Increment: 1,073,741,824 (1 GiB).</para>
            /// </description></item>
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
