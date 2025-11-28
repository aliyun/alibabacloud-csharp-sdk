// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateDBInstanceIPArrayShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the information about all AnalyticDB for PostgreSQL instances within a region, including instance IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The attribute of the IP whitelist group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>taffyFish</para>
        /// </summary>
        [NameInMap("IPArrayAttribute")]
        [Validation(Required=false)]
        public string IPArrayAttribute { get; set; }

        /// <summary>
        /// <para>The name of the IP whitelist group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testarray</para>
        /// </summary>
        [NameInMap("IPArrayName")]
        [Validation(Required=false)]
        public string IPArrayName { get; set; }

        /// <summary>
        /// <para>The IP addresses in the IP whitelist group. A maximum of 1,000 IP addresses or CIDR blocks are allowed.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPListShrink { get; set; }

    }

}
