// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateAccessPointRequest : TeaModel {
        /// <summary>
        /// <para>The name of the permission group.</para>
        /// <para>This parameter is required if the file system is a General-purpose NAS file system.</para>
        /// <para>Default permission group: DEFAULT_VPC_GROUP_NAME (the default permission group for VPCs).</para>
        /// <remarks>
        /// <para>Not supported for Agentic file systems.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT_VPC_GROUP_NAME</para>
        /// </summary>
        [NameInMap("AccessGroup")]
        [Validation(Required=false)]
        public string AccessGroup { get; set; }

        /// <summary>
        /// <para>The name of the access point.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AccessPointName")]
        [Validation(Required=false)]
        public string AccessPointName { get; set; }

        /// <summary>
        /// <para>The AgenticSpace ID.</para>
        /// <remarks>
        /// <para>This parameter is required for Agentic file systems.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>agentic-229oypxjgpau2****</para>
        /// </summary>
        [NameInMap("AgenticSpaceId")]
        [Validation(Required=false)]
        public string AgenticSpaceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable access point policy.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enabled.</description></item>
        /// <item><description>false (default): not enabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>After you enable access point policy for the access point, all Resource Access Management (RAM) users are denied access to mount and access data through the access point by default. You must grant the corresponding access permissions through authorization and then mount and access the file system through the access point. After you disable access point policy, the access point allows anonymity mounting. For more information about how to configure access point permissions, see <a href="https://help.aliyun.com/document_detail/2545998.html">Configure access point policies</a>.</para>
        /// </remarks>
        /// <remarks>
        /// <para>For Agentic file systems, this parameter must be set to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnabledRam")]
        [Validation(Required=false)]
        public bool? EnabledRam { get; set; }

        /// <summary>
        /// <para>The file system ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31a8e4****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The owner group ID.</para>
        /// <para>This parameter is required if the RootDirectory directory does not exist.</para>
        /// <remarks>
        /// <para>Not supported for Agentic file systems.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OwnerGroupId")]
        [Validation(Required=false)]
        public int? OwnerGroupId { get; set; }

        /// <summary>
        /// <para>The owner user ID.</para>
        /// <para>This parameter is required if the RootDirectory directory does not exist.</para>
        /// <remarks>
        /// <para>Not supported for Agentic file systems.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OwnerUserId")]
        [Validation(Required=false)]
        public int? OwnerUserId { get; set; }

        /// <summary>
        /// <para>The POSIX permission. Default value: &quot;0755&quot;. The value must be a four-digit octal number that starts with 0.</para>
        /// <para>This parameter takes effect only after you specify the OwnerUserId and OwnerGroupId parameters.</para>
        /// <remarks>
        /// <para>Not supported for Agentic file systems.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0755</para>
        /// </summary>
        [NameInMap("Permission")]
        [Validation(Required=false)]
        public string Permission { get; set; }

        /// <summary>
        /// <para>The POSIX group ID.</para>
        /// <remarks>
        /// <para>Not supported for Agentic file systems.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("PosixGroupId")]
        [Validation(Required=false)]
        public int? PosixGroupId { get; set; }

        /// <summary>
        /// <para>The secondary group IDs. Separate multiple group IDs with commas (,).</para>
        /// <remarks>
        /// <para>Not supported for Agentic file systems.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123,345</para>
        /// </summary>
        [NameInMap("PosixSecondaryGroupIds")]
        [Validation(Required=false)]
        public string PosixSecondaryGroupIds { get; set; }

        /// <summary>
        /// <para>The POSIX user ID.</para>
        /// <remarks>
        /// <para>Not supported for Agentic file systems.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("PosixUserId")]
        [Validation(Required=false)]
        public int? PosixUserId { get; set; }

        /// <summary>
        /// <para>The root directory of the access point.
        /// Default value: &quot;/&quot;. If the access point directory does not exist, you must also specify the OwnerUserId and OwnerGroupId parameters.</para>
        /// <remarks>
        /// <para>Supported only for Agentic file systems.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("RootDirectory")]
        [Validation(Required=false)]
        public string RootDirectory { get; set; }

        /// <summary>
        /// <para>The list of access point tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateAccessPointRequestTag> Tag { get; set; }
        public class CreateAccessPointRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.
            /// Limits:</para>
            /// <list type="bullet">
            /// <item><description>Cannot be empty or an empty string.</description></item>
            /// <item><description>Can be up to 128 characters in length.</description></item>
            /// <item><description>Cannot start with aliyun or acs:.</description></item>
            /// <item><description>Cannot contain http:// or https://.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.
            /// Limits:</para>
            /// <list type="bullet">
            /// <item><description>Cannot be empty or an empty string.</description></item>
            /// <item><description>Can be up to 128 characters in length.</description></item>
            /// <item><description>Cannot contain http:// or https://.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The virtual private cloud (VPC) ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zesj9afh3y518k9o****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2zevmwkwyztjuoffg****</para>
        /// </summary>
        [NameInMap("VswId")]
        [Validation(Required=false)]
        public string VswId { get; set; }

    }

}
