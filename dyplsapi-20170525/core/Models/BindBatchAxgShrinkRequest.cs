// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BindBatchAxgShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of AXG bindings.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AxgBindList")]
        [Validation(Required=false)]
        public string AxgBindListShrink { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The key of the number pool.</para>
        /// <para>You can log on to the Phone Number Protection console and obtain the key on the <a href="https://dyplsnext.console.aliyun.com/number-pool">Number Pool Management</a> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC2235****</para>
        /// </summary>
        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
