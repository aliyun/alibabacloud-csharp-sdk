// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class UpdateNodeGroupShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether file storage mounting is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("FileSystemMountEnabled")]
        [Validation(Required=false)]
        public bool? FileSystemMountEnabled { get; set; }

        /// <summary>
        /// <para>The default image ID of the node group. If this parameter is not specified, the image remains unchanged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i1232142432432</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The key pair name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The logon password of the machines in the node group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>密码</para>
        /// </summary>
        [NameInMap("LoginPassword")]
        [Validation(Required=false)]
        public string LoginPassword { get; set; }

        /// <summary>
        /// <para>The node group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-update</para>
        /// </summary>
        [NameInMap("NewNodeGroupName")]
        [Validation(Required=false)]
        public string NewNodeGroupName { get; set; }

        /// <summary>
        /// <para>The node group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i120021051733814190732</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <para>The RAM role name of the node. You can call the RAM API ListRoles to query the node RAM roles that you have created. The trusted entity of the role must be set to Lingjun AI Computing Service.
        /// Note: Clearing an existing role is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xianwen-test-ram-role</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public string SystemDiskShrink { get; set; }

        /// <summary>
        /// <para>The custom executable shell script. The script must be Base64-encoded. The maximum size of the raw data is 16 KB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZWNobyBoZWxsbyBlY3Mh</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
