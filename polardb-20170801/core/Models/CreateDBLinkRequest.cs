// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateDBLinkRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length. The token is case-sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f54a343f1a4233c1e7d1c5c******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the source cluster that the database link connects.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/173433.html">DescribeDBClusters</a> operation to query PolarDB clusters.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-a************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The name of the database link.</para>
        /// <list type="bullet">
        /// <item><description>The name must contain lowercase letters and can also contain digits and underscores (_).</description></item>
        /// <item><description>The name must start with a letter and end with a letter or digit.</description></item>
        /// <item><description>The name must be 1 to 64 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dblink_test</para>
        /// </summary>
        [NameInMap("DBLinkName")]
        [Validation(Required=false)]
        public string DBLinkName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to query information about regions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-************</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The name of the source database.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/173558.html">DescribeDatabases</a> operation to query information about databases in a PolarDB cluster.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdb1</para>
        /// </summary>
        [NameInMap("SourceDBName")]
        [Validation(Required=false)]
        public string SourceDBName { get; set; }

        /// <summary>
        /// <para>The account of the destination database.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/173549.html">DescribeAccounts</a> operation to query the account of a PolarDB cluster.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testacc</para>
        /// </summary>
        [NameInMap("TargetDBAccount")]
        [Validation(Required=false)]
        public string TargetDBAccount { get; set; }

        /// <summary>
        /// <para>The ID of the destination cluster that the database link connects.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the destination cluster is a user-created Oracle database on an ECS instance, set the value to <c>null</c>.</description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/173433.html">DescribeDBClusters</a> operation to query PolarDB clusters.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pc-b************</para>
        /// </summary>
        [NameInMap("TargetDBInstanceName")]
        [Validation(Required=false)]
        public string TargetDBInstanceName { get; set; }

        /// <summary>
        /// <para>The name of the destination database.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/173558.html">DescribeDatabases</a> operation to query information about databases in a PolarDB cluster.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdb2</para>
        /// </summary>
        [NameInMap("TargetDBName")]
        [Validation(Required=false)]
        public string TargetDBName { get; set; }

        /// <summary>
        /// <para>The account password of the destination database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test1111</para>
        /// </summary>
        [NameInMap("TargetDBPasswd")]
        [Validation(Required=false)]
        public string TargetDBPasswd { get; set; }

        /// <summary>
        /// <para>The IP address of the user-created Oracle database on an ECS instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.<b>.</b>.46</para>
        /// </summary>
        [NameInMap("TargetIp")]
        [Validation(Required=false)]
        public string TargetIp { get; set; }

        /// <summary>
        /// <para>The port number of the user-created Oracle database on an ECS instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1521</para>
        /// </summary>
        [NameInMap("TargetPort")]
        [Validation(Required=false)]
        public string TargetPort { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC).</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/35739.html">DescribeVpcs</a> operation to query information about VPCs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1qpo0kug3a20qqe****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
