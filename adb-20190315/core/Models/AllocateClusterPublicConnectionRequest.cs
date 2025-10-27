// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class AllocateClusterPublicConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The prefix of the public endpoint.</para>
        /// <list type="bullet">
        /// <item><description>The prefix must contain lowercase letters, digits, and hyphens (-). It must start with a lowercase letter.</description></item>
        /// <item><description>The prefix can be up to 30 characters in length.</description></item>
        /// <item><description>By default, the cluster name is used as the prefix of the public endpoint.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp278jg9****.ads.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ConnectionStringPrefix")]
        [Validation(Required=false)]
        public string ConnectionStringPrefix { get; set; }

        /// <summary>
        /// <para>The Data Warehouse Edition Cluster ID of AnalyticDB for MySQL. You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to retrieve all Data Warehouse Edition cluster IDs within the specified region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp278jg9****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

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

    }

}
