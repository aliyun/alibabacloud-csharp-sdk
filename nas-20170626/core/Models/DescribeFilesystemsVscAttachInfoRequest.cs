// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeFilesystemsVscAttachInfoRequest : TeaModel {
        /// <summary>
        /// <para>The number of results for each query.</para>
        /// <para>Valid values: 10 to 100.
        /// Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token. Set the value to the NextToken value returned in the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cmNlU****mVzJjE1MTI2NjY4NzY5MTAzOTEmMiZORnI4NDhVeEtrUT0=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID information of file systems and virtual storage channels. A maximum of 10 entries can be specified per batch.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<DescribeFilesystemsVscAttachInfoRequestResourceIds> ResourceIds { get; set; }
        public class DescribeFilesystemsVscAttachInfoRequestResourceIds : TeaModel {
            /// <summary>
            /// <para>The file system ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bmcpfs-290t15yn4uo8lid****</para>
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// <para>The virtual storage channel ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsc-8vb864o3ppwfvh****</para>
            /// </summary>
            [NameInMap("VscId")]
            [Validation(Required=false)]
            public string VscId { get; set; }

        }

        [NameInMap("RoleChain")]
        [Validation(Required=false)]
        public List<DescribeFilesystemsVscAttachInfoRequestRoleChain> RoleChain { get; set; }
        public class DescribeFilesystemsVscAttachInfoRequestRoleChain : TeaModel {
            [NameInMap("AssumeRoleFor")]
            [Validation(Required=false)]
            public string AssumeRoleFor { get; set; }

            [NameInMap("RoleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

        }

    }

}
