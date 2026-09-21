// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ModifyFileSystemRequest : TeaModel {
        /// <summary>
        /// <para>The auto-scaling configuration.</para>
        /// </summary>
        [NameInMap("AutoUpgradeConfig")]
        [Validation(Required=false)]
        public ModifyFileSystemRequestAutoUpgradeConfig AutoUpgradeConfig { get; set; }
        public class ModifyFileSystemRequestAutoUpgradeConfig : TeaModel {
            /// <summary>
            /// <para>The capacity usage threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("capacityUsedRatio")]
            [Validation(Required=false)]
            public int? CapacityUsedRatio { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable auto-scaling.</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The scaling increment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("step")]
            [Validation(Required=false)]
            public int? Step { get; set; }

            /// <summary>
            /// <para>The duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("time")]
            [Validation(Required=false)]
            public int? Time { get; set; }

        }

        /// <summary>
        /// <para>The description of the file system.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The description must be 2 to 128 characters in length.</description></item>
        /// <item><description>The description must start with a letter. It cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>The description can contain digits, colons (:), underscores (_), or hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NAS-test-1</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The file system ID.</para>
        /// <list type="bullet">
        /// <item><description><para>General-purpose NAS: <c>31a8e4****</c>.</para>
        /// </description></item>
        /// <item><description><para>Extreme NAS: The ID must start with <c>extreme-</c>, for example, <c>extreme-0015****</c>.</para>
        /// </description></item>
        /// <item><description><para>Cloud Parallel File Storage (CPFS): The ID must start with <c>cpfs-</c>, for example, <c>cpfs-125487****</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ca404****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The options.</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public ModifyFileSystemRequestOptions Options { get; set; }
        public class ModifyFileSystemRequestOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the SMB Access-Based Enumeration (ABE) feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableABE")]
            [Validation(Required=false)]
            public bool? EnableABE { get; set; }

            /// <summary>
            /// <para>Specifies whether the OpLock feature is enabled.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Not enabled.<remarks>
            /// <para>Only file systems of the SMB Protocol Type are supported.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableOplock")]
            [Validation(Required=false)]
            public bool? EnableOplock { get; set; }

            /// <summary>
            /// <para>Specifies whether the Lingjun VSC mount target supports only access point-based access.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("VscAccessPointAccessOnly")]
            [Validation(Required=false)]
            public bool? VscAccessPointAccessOnly { get; set; }

        }

    }

}
