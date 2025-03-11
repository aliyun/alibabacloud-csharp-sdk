// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class ManagePrivateRdsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the custom ApsaraDB RDS instance at the storage layer.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/215526.html">DescribeDrdsRdsInstances</a> operation to query the details of all ApsaraDB RDS instances, including the ID of the instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-***************</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the PolarDB-X 1.0 instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/139284.html">DescribeDrdsInstances</a> operation to query the details of all PolarDB-X 1.0 instances within an Alibaba Cloud account, including the IDs of the instances.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drds*************</para>
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// <para>The JSON string that consists of request parameters and the values of the request parameters of an operation that you need to call for the custom ApsaraDB RDS instance. The value of a request parameter is of the STRING type. Example: <c>{NodeId:&quot;1797****&quot;}</c>.</para>
        /// <para>For more information about the request parameters and valid values of the request parameters of each operation, see the request parameter sections in the following topics:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/26231.html">DescribeDBInstanceAttribute</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/196546.html">DescribeAvailableClasses</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/26292.html">DescribeSQLCollectorPolicy</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/26293.html">ModifySQLCollectorPolicy</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/26285.html">DescribeParameters</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/26286.html">ModifyParameter</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/26244.html">DescribeDBInstanceHAConfig</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/26251.html">SwitchDBInstanceHA</a></description></item>
        /// </list>
        /// <remarks>
        /// <para>Among the required request parameters of the preceding operations, you do not need to specify the <c>Action</c> and <c>DBInstanceId</c> parameters. You must specify all the other required request parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{NodeId:&quot;1797****&quot;}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform on the custom ApsaraDB RDS instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DescribeDBInstanceAttribute</b>: queries the details of the custom ApsaraDB RDS instance.</description></item>
        /// <item><description><b>DescribeAvailableClasses</b>: queries the specifications that are supported for a custom ApsaraDB RDS instance. The specifications include the instance type and the storage capacity.</description></item>
        /// <item><description><b>DescribeSQLCollectorPolicy</b>: queries whether the SQL Explorer (SQL Audit) feature is enabled for custom ApsaraDB RDS instance.</description></item>
        /// <item><description><b>ModifySQLCollectorPolicy</b>: enables or disables the SQL Explorer (SQL Audit) feature for the custom ApsaraDB RDS instance.</description></item>
        /// <item><description><b>DescribeParameters</b>: queries the parameter settings of the custom ApsaraDB RDS instance.</description></item>
        /// <item><description><b>ModifyParameter</b>: modifies the parameters of the custom ApsaraDB RDS instance.</description></item>
        /// <item><description><b>DescribeDBInstanceHAConfig</b>: queries the high availability mode and data replication mode of the custom ApsaraDB RDS instance.</description></item>
        /// <item><description><b>SwitchDBInstanceHA</b>: switches workloads between the primary and secondary custom ApsaraDB RDS instances.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SwitchDBInstanceHA</para>
        /// </summary>
        [NameInMap("RdsAction")]
        [Validation(Required=false)]
        public string RdsAction { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the PolarDB-X 1.0 instance resides.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/139284.html">DescribeDrdsInstances</a> operation to query the details of all PolarDB-X 1.0 instances within an Alibaba Cloud account, including the IDs of regions in which the instances reside.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hanzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
