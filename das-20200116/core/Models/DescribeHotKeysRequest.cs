// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeHotKeysRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ApsaraDB for Redis instance. You can call the <a href="https://help.aliyun.com/document_detail/60933.html">DescribeInstances</a> operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp18ff4a195d****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the data shard on the ApsaraDB for Redis instance. You can call the <a href="https://help.aliyun.com/document_detail/190794.html">DescribeRoleZoneInfo</a> operation to query the data shard ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-x****-db-0</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

    }

}
