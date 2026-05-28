// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ExternalStore : TeaModel {
        /// <summary>
        /// <para>The name of the external store. The name must be unique in a project and must be different from Logstore names.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds_store</para>
        /// </summary>
        [NameInMap("externalStoreName")]
        [Validation(Required=false)]
        public string ExternalStoreName { get; set; }

        /// <summary>
        /// <para>The parameters that are configured for the external store.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ 		&quot;vpc-id&quot;: &quot;vpc-bp1aevy8sofi8mh1q****&quot;, 		&quot;instance-id&quot;: &quot;i-bp1b6c719dfa08exf****&quot;, 		&quot;host&quot;: &quot;192.168.XX.XX&quot;, 		&quot;port&quot;: &quot;3306&quot;, 		&quot;username&quot;: &quot;root&quot;, 		&quot;password&quot;: &quot;sfdsfldsfksfls****&quot;, 		&quot;db&quot;: &quot;meta&quot;, 		&quot;table&quot;: &quot;join_meta&quot;, 		&quot;region&quot;: &quot;cn-qingdao&quot; 	}</para>
        /// </summary>
        [NameInMap("parameter")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameter { get; set; }

        /// <summary>
        /// <para>The storage type. Set the value to rds-vpc, which indicates a database on an ApsaraDB RDS for MySQL instance in a virtual private cloud (VPC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds-vpc</para>
        /// </summary>
        [NameInMap("storeType")]
        [Validation(Required=false)]
        public string StoreType { get; set; }

    }

}
