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
        /// <para>This parameter is required when the target file system is a General-purpose NAS file system.</para>
        /// <para>Default permission group: DEFAULT_VPC_GROUP_NAME (the default permission group for VPCs).</para>
        /// <remarks>
        /// <para>Not supported by Agentic file systems.</para>
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
        /// <para>The ID of the Agentic space.</para>
        /// <remarks>
        /// <para>Required for Agentic file systems.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>agentic-229oypxjgpau2****</para>
        /// </summary>
        [NameInMap("AgenticSpaceId")]
        [Validation(Required=false)]
        public string AgenticSpaceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the RAM policy.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <para>After you enable the access point RAM policy, all Resource Access Management (RAM) users are denied by default from using the access point to mount and access data. You must grant authorization to the accounts to enable the corresponding access permissions, and mount the file system through the access point. If this feature is disabled, the access point allows anonymous mounting. For more information about how to configure access point permissions, see <a href="https://help.aliyun.com/document_detail/2545998.html">Configure access point policy</a>.</para>
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
        /// <para>The ID of the file system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31a8e4****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The ID of the owner user group.</para>
        /// <para>This parameter is required when the RootDirectory directory does not exist.</para>
        /// <remarks>
        /// <para>Not supported by Agentic file systems.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OwnerGroupId")]
        [Validation(Required=false)]
        public int? OwnerGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the owner user.</para>
        /// <para>This parameter is required when the RootDirectory directory does not exist.</para>
        /// <remarks>
        /// <para>Not supported by Agentic file systems.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OwnerUserId")]
        [Validation(Required=false)]
        public int? OwnerUserId { get; set; }

        /// <summary>
        /// <para>The POSIX permissions. Default value: 0755. The value must be a four-digit octal number starting with 0.</para>
        /// <para>This parameter takes effect only after you specify the OwnerUserId and OwnerGroupId parameters.</para>
        /// <remarks>
        /// <para>Not supported by Agentic file systems.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0755</para>
        /// </summary>
        [NameInMap("Permission")]
        [Validation(Required=false)]
        public string Permission { get; set; }

        /// <summary>
        /// <para>The POSIX user group ID.</para>
        /// <remarks>
        /// <para>Not supported by Agentic file systems.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("PosixGroupId")]
        [Validation(Required=false)]
        public int? PosixGroupId { get; set; }

        /// <summary>
        /// <para>The secondary user groups. Separate multiple user group IDs with commas (,).</para>
        /// <remarks>
        /// <para>Not supported by Agentic file systems.</para>
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
        /// <para>Not supported by Agentic file systems.</para>
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
        /// Default value: /. If the access point directory does not exist, you must also specify the OwnerUserId and OwnerGroupId parameters.</para>
        /// <remarks>
        /// <para>Not supported by Agentic file systems.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("RootDirectory")]
        [Validation(Required=false)]
        public string RootDirectory { get; set; }

        /// <summary>
        /// <para>The list of tags for the access point.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateAccessPointRequestTag> Tag { get; set; }
        public class CreateAccessPointRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.
            /// Limits:</para>
            /// <list type="bullet">
            /// <item><description>The tag key cannot be empty or an empty string.</description></item>
            /// <item><description>The tag key can be up to 128 characters in length.</description></item>
            /// <item><description>The tag key cannot start with aliyun or acs:.</description></item>
            /// <item><description>The tag key cannot contain http:// or https://.</description></item>
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
            /// <item><description>The tag value cannot be empty or an empty string.</description></item>
            /// <item><description>The tag value can be up to 128 characters in length.</description></item>
            /// <item><description>The tag value cannot contain http:// or https://.</description></item>
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
        /// <para>The ID of the VPC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zesj9afh3y518k9o****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
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
