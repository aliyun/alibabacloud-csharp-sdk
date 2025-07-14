// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class UpdateNodeGroupRequest : TeaModel {
        /// <summary>
        /// <para>Whether file storage mounting is supported</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("FileSystemMountEnabled")]
        [Validation(Required=false)]
        public bool? FileSystemMountEnabled { get; set; }

        /// <summary>
        /// <para>The default image ID of the node group. If not set, it will not change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i1232142432432</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>Key pair name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>Login password for machines within the node group</para>
        /// 
        /// <b>Example:</b>
        /// <para>LoginPassword</para>
        /// </summary>
        [NameInMap("LoginPassword")]
        [Validation(Required=false)]
        public string LoginPassword { get; set; }

        /// <summary>
        /// <para>Node group name</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-update</para>
        /// </summary>
        [NameInMap("NewNodeGroupName")]
        [Validation(Required=false)]
        public string NewNodeGroupName { get; set; }

        /// <summary>
        /// <para>Node group ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>i120021051733814190732</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <para>User-defined script</para>
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
