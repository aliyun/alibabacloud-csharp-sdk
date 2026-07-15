// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstanceSpecInfoRequest : TeaModel {
        /// <summary>
        /// <para>The instance type. You can query this parameter by calling the <a href="https://next.api.aliyun.com/api/Dds/2015-12-01/DescribeDBInstanceAttribute">DescribeDBInstanceAttribute</a> operation.</para>
        /// <para>For instance types of different instance categories, see the following topics:</para>
        /// <list type="bullet">
        /// <item><description><para><a href="https://help.aliyun.com/document_detail/311407.html">Specifications of standalone instances</a></para>
        /// </description></item>
        /// <item><description><para><a href="https://help.aliyun.com/document_detail/311410.html">Specifications of replica set instances</a></para>
        /// </description></item>
        /// <item><description><para><a href="https://help.aliyun.com/document_detail/311414.html">Specifications of sharded cluster instances</a></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mdb.shard.4x.large.d</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
