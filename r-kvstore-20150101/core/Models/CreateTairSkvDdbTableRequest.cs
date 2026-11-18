// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateTairSkvDdbTableRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster backup set. Some new cluster architectures support cluster backup set IDs. You can call the <a href="https://www.alibabacloud.com/help/en/redis/developer-reference/api-r-kvstore-2015-01-01-describeclusterbackuplist-redis">DescribeClusterBackupList</a> operation to query the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cb-hyxdof5x9kqb**</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The value is case-sensitive and can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz**</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance type. Set the value to tair_skv_ddb_table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tair_skv_ddb_table</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/61012.htm">DescribeRegions</a> operation to query the most recent region list. Set this parameter to the ID of the region where you want to create the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The table schema configuration information in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AttributeDefinitions&quot;:[{&quot;AttributeType&quot;:&quot;S&quot;,&quot;AttributeName&quot;:&quot;pk&quot;},{&quot;AttributeType&quot;:&quot;S&quot;,&quot;AttributeName&quot;:&quot;sk&quot;}],&quot;KeySchema&quot;:[{&quot;KeyType&quot;:&quot;HASH&quot;,&quot;AttributeName&quot;:&quot;pk&quot;},{&quot;KeyType&quot;:&quot;RANGE&quot;,&quot;AttributeName&quot;:&quot;sk&quot;}]}</para>
        /// </summary>
        [NameInMap("Schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The ID of the source instance. If you want to create an instance based on the backup set of a specific instance, specify the ID of the source instance in this parameter.</para>
        /// <para>Note</para>
        /// <para>This parameter must be used in combination with BackupId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx**</para>
        /// </summary>
        [NameInMap("SrcDBInstanceId")]
        [Validation(Required=false)]
        public string SrcDBInstanceId { get; set; }

        /// <summary>
        /// <para>The table name. The name must be 2 to 128 characters in length and start with a letter or a Chinese character. The name cannot contain the following special characters: @, /, :, =, &lt;, &gt;, {, }, [, ], and spaces.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apitest</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The parameter settings in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;attributeName&quot;:&quot;Expiretime&quot;,&quot;enabled&quot;:true}</para>
        /// </summary>
        [NameInMap("TtlSpec")]
        [Validation(Required=false)]
        public string TtlSpec { get; set; }

        /// <summary>
        /// <para>The workspace instance ID. You can call the <a href="https://www.alibabacloud.com/help/en/redis/developer-reference/api-r-kvstore-2015-01-01-describeinstances-redis">DescribeInstances</a> operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tt-bp1zxszhcgatnx**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
