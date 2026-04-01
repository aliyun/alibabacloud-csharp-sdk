// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceIpHostnameResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The internal IP addresses and hostnames of the ECS instance on which a primary ApsaraDB RDS for SQL Server instance and its secondary RDS instance reside. Format: <c>IP address 1, Hostname 1; IP address 2, Hostname 2</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.xx.xx,sdxxxxxxxxB;172.16.xx.xx,sdxxxxxxxxA</para>
        /// </summary>
        [NameInMap("IpHostnameInfos")]
        [Validation(Required=false)]
        public string IpHostnameInfos { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67CD4719-51E3-4A76-A38C-02F45FAE7E36</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
