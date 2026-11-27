// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateFilesetRequest : TeaModel {
        /// <summary>
        /// <para>Ensures the idempotence of the request. You can generate a value on your client to ensure that this parameter is unique across different requests.</para>
        /// <para>The ClientToken can contain only ASCII characters and cannot exceed 64 characters. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
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
        /// <para>The release protection attribute of the instance. It specifies whether the instance can be released through the console or the <a href="https://help.aliyun.com/document_detail/2402263.html">DeleteFileset</a> operation.</para>
        /// <list type="bullet">
        /// <item><description>true: Enables release protection for the instance.</description></item>
        /// <item><description>false (default): Disables release protection for the instance.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This attribute limits only manual release operations and does not apply to system release operations.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>The description of the Fileset.</para>
        /// <list type="bullet">
        /// <item><description>The description must be 2 to 128 characters in length.</description></item>
        /// <item><description>The description must start with an uppercase letter, a lowercase letter, or a Chinese character. It cannot start with http:// or https://.</description></item>
        /// <item><description>The description can contain digits, colons (:), underscores (_), or hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Internal transaction directory</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run for this creation request.</para>
        /// <para>A dry run performs checks such as parameter validity and inventory. It does not actually create the instance or incur fees.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Sends a check request and does not create the instance. Check items include whether required parameters are specified, the request format, business limits, and NAS inventory. If the check fails, the corresponding error is returned. If the check succeeds, the 200 HTTP status code is returned, but FsetId is empty.</description></item>
        /// <item><description>false (default): Sends a normal request and creates the instance directly after the check succeeds.</description></item>
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
        /// <item><description><para>CPFS: The ID must start with <c>cpfs-</c>. Example: cpfs-099394bd928c****.</para>
        /// </description></item>
        /// <item><description><para>CPFS for Lingjun: The ID must start with <c>bmcpfs-</c>. Example: bmcpfs-290w65p03ok64ya****.</para>
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
        /// <para>The absolute path of the Fileset to be created.</para>
        /// <list type="bullet">
        /// <item><description>CPFS path limits.<list type="bullet">
        /// <item><description>The parent directory of the specified directory must be an existing directory in the file system.</description></item>
        /// <item><description>The length must be 2 to 1,024 characters.</description></item>
        /// <item><description>The specified directory must start and end with a forward slash (/).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>CPFS for Lingjun path limits.<list type="bullet">
        /// <item><description>The length must be 2 to 1,024 characters.</description></item>
        /// <item><description>The specified directory must start and end with a forward slash (/).</description></item>
        /// <item><description>The Fileset path must be a new path and cannot be an existing path. Fileset paths cannot be renamed and cannot be symbolic links.</description></item>
        /// <item><description>The maximum supported depth of a Fileset path is 8 levels. The root directory / is level 0. For example, if the Fileset path is /test/aaa/ccc/, the path depth is 3 levels.</description></item>
        /// <item><description>If the Fileset path contains multiple directory levels, the parent directory must be an existing directory.</description></item>
        /// <item><description>You cannot nest Filesets. If a parent directory is already specified as a Fileset, its subdirectories cannot be specified as Filesets. Each Fileset path supports only one quota.</description></item>
        /// <item><description>The total path length can be up to 990 characters.</description></item>
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
        /// <para>Only CPFS for Lingjun 2.7.0 and later support this parameter.</para>
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
            /// <para>The total capacity limit of the quota. Unit: Byte.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Minimum value: 10,737,418,240 (10 GiB).</para>
            /// </description></item>
            /// <item><description><para>Step: 1,073,741,824 (1 GiB).</para>
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
