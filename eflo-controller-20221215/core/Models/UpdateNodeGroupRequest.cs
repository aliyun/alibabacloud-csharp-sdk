// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class UpdateNodeGroupRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to mount file storage on nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("FileSystemMountEnabled")]
        [Validation(Required=false)]
        public bool? FileSystemMountEnabled { get; set; }

        /// <summary>
        /// <para>The ID of the image for the node group. If you omit this parameter, the image remains unchanged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i1232142432432</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The name of the key pair.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The login password for the nodes in the node group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Password</para>
        /// </summary>
        [NameInMap("LoginPassword")]
        [Validation(Required=false)]
        public string LoginPassword { get; set; }

        /// <summary>
        /// <para>The new name of the node group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-update</para>
        /// </summary>
        [NameInMap("NewNodeGroupName")]
        [Validation(Required=false)]
        public string NewNodeGroupName { get; set; }

        /// <summary>
        /// <para>The ID of the node group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i120021051733814190732</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <para>To query the RAM roles that you have created, call the ListRoles operation in the RAM API. The trust policy for the role must specify Intelligent Computing Lingjun as the trusted entity. Note: You cannot remove a role by clearing this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xianwen-test-ram-role</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The user data. This script runs at node startup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>#!/bin/bash
        /// uptime
        /// echo &quot;aaaaaaa&quot; &gt;&gt; /tmp/ttttt20250110141010.sh</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
