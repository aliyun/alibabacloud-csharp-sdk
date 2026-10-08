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
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The internal IP addresses and hostnames of the underlying ECS instances for the ApsaraDB RDS for SQL Server instance, including the primary and secondary instances. Format: <c>ip1,hostname1;ip2,hostname2</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.xx.xx,sd<b><b>B;172.16.xx.xx,sd</b></b>A</para>
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
