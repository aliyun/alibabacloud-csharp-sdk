// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class AttachVscToFilesystemsRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests.</para>
        /// <para>The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId may differ for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID information of file systems and Virtual Storage Channels. A maximum of 10 entries can be specified per batch.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<AttachVscToFilesystemsRequestResourceIds> ResourceIds { get; set; }
        public class AttachVscToFilesystemsRequestResourceIds : TeaModel {
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
            /// <para>The Virtual Storage Channel ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsc-8vb864o3ppwfvh****</para>
            /// </summary>
            [NameInMap("VscId")]
            [Validation(Required=false)]
            public string VscId { get; set; }

        }

        /// <summary>
        /// <para>The role chain.</para>
        /// <remarks>
        /// <para>This parameter is required only for cross-account scenarios.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RoleChain")]
        [Validation(Required=false)]
        public List<AttachVscToFilesystemsRequestRoleChain> RoleChain { get; set; }
        public class AttachVscToFilesystemsRequestRoleChain : TeaModel {
            /// <summary>
            /// <para>The UID of the Alibaba Cloud account on whose behalf the service assumes the role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>176498472570****</para>
            /// </summary>
            [NameInMap("AssumeRoleFor")]
            [Validation(Required=false)]
            public string AssumeRoleFor { get; set; }

            /// <summary>
            /// <para>The resource descriptor of the specified role. Format: acs:ram::$accountID:role/$roleName.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::123472233814****:role/aliyunnasclientvsc****</para>
            /// </summary>
            [NameInMap("RoleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            /// <summary>
            /// <para>The role type. Valid values: service and user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service</para>
            /// </summary>
            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

        }

    }

}
