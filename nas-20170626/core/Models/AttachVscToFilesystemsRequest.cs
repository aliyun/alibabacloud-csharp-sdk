// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class AttachVscToFilesystemsRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can generate the value from your client and ensure that the value is unique across different requests.</para>
        /// <para>The client token can only contain ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the client token. The RequestId may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The IDs of the file systems and virtual storage channels (VSCs). You can specify up to 10 IDs per batch. This parameter must be passed in a flattened format, such as ResourceIds.1.FileSystemId=bmcpfs-xxx&amp;ResourceIds.1.VscId=vsc-xxx. JSON arrays are not supported.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<AttachVscToFilesystemsRequestResourceIds> ResourceIds { get; set; }
        public class AttachVscToFilesystemsRequestResourceIds : TeaModel {
            /// <summary>
            /// <para>The ID of the file system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bmcpfs-290t15yn4uo8lid****</para>
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// <para>The ID of the VSC. You can call the ListVscs operation of the Lingjun AI Computing Service eflo-controller/2022-12-15 API to query the ID. If no VSC is created, you can call the CreateVsc operation to create one.</para>
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
        /// <para>Required only for cross-account scenarios.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RoleChain")]
        [Validation(Required=false)]
        public List<AttachVscToFilesystemsRequestRoleChain> RoleChain { get; set; }
        public class AttachVscToFilesystemsRequestRoleChain : TeaModel {
            /// <summary>
            /// <para>The UID of the Alibaba Cloud account. This parameter specifies the Alibaba Cloud account for which the service assumes the role.</para>
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
            /// <para>The type of the role. Valid values: service and user.</para>
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
