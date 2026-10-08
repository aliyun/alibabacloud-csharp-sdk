// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateDBProxyEndpointAddressRequest : TeaModel {
        /// <summary>
        /// <para>The prefix of the new database proxy endpoint. Specify a custom value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1234</para>
        /// </summary>
        [NameInMap("ConnectionStringPrefix")]
        [Validation(Required=false)]
        public string ConnectionStringPrefix { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call DescribeDBInstances to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-t4n3****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The network type of the new database proxy endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Public</b>: Internet</description></item>
        /// <item><description><b>VPC</b> (default): virtual private cloud (VPC)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("DBProxyConnectStringNetType")]
        [Validation(Required=false)]
        public string DBProxyConnectStringNetType { get; set; }

        /// <summary>
        /// <para>The ID of the database proxy endpoint. You can call DescribeDBProxyEndpoint to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ta9um4****</para>
        /// </summary>
        [NameInMap("DBProxyEndpointId")]
        [Validation(Required=false)]
        public string DBProxyEndpointId { get; set; }

        /// <summary>
        /// <para>A reserved parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("DBProxyEngineType")]
        [Validation(Required=false)]
        public string DBProxyEngineType { get; set; }

        /// <summary>
        /// <para>The port of the new database proxy endpoint. Default value:</para>
        /// <list type="bullet">
        /// <item><description>MySQL: <b>3306</b></description></item>
        /// <item><description>PostgreSQL: <b>5432</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("DBProxyNewConnectStringPort")]
        [Validation(Required=false)]
        public string DBProxyNewConnectStringPort { get; set; }

        /// <summary>
        /// <para>The region ID. You can call DescribeRegions to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The VPC ID of the new database proxy endpoint. You can call DescribeDBInstanceAttribute to query the VPC ID.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>DBProxyConnectStringNetType</b> is set to <b>VPC</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the new database proxy endpoint. You can call DescribeDBInstanceAttribute to query the vSwitch ID.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>DBProxyConnectStringNetType</b> is set to <b>VPC</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
