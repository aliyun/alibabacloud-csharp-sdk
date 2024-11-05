// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyDatabaseRequest : TeaModel {
        /// <summary>
        /// <para>The new address type of the database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Public</b></description></item>
        /// <item><description><b>Private</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("ActiveAddressType")]
        [Validation(Required=false)]
        public string ActiveAddressType { get; set; }

        /// <summary>
        /// <para>The new remarks of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tttttttt</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The ID of the database to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("DatabaseId")]
        [Validation(Required=false)]
        public string DatabaseId { get; set; }

        /// <summary>
        /// <para>The new name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgsql</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The new port of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5433</para>
        /// </summary>
        [NameInMap("DatabasePort")]
        [Validation(Required=false)]
        public string DatabasePort { get; set; }

        /// <summary>
        /// <para>The new internal address of the database. Specify an IPv4 address or a domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp169******</para>
        /// </summary>
        [NameInMap("DatabasePrivateAddress")]
        [Validation(Required=false)]
        public string DatabasePrivateAddress { get; set; }

        /// <summary>
        /// <para>The new public address of the database. Specify an IPv4 address or a domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-uf6c******</para>
        /// </summary>
        [NameInMap("DatabasePublicAddress")]
        [Validation(Required=false)]
        public string DatabasePublicAddress { get; set; }

        /// <summary>
        /// <para>The ID of the bastion host that manages the database to modify.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the bastion host ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-72137xe5n01</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the new network domain for the database.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2758827.html">ListNetworkDomains</a> operation to query the network domain ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("NetworkDomainId")]
        [Validation(Required=false)]
        public string NetworkDomainId { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host that manages the database to modify.</para>
        /// <remarks>
        /// <para>For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the ApsaraDB for RDS instance or PolarDB cluster to modify.</para>
        /// <remarks>
        /// <para>This parameter is required if <b>Source</b> is set to <b>Rds</b> or <b>PolarDB</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>i-wz99nexqd62z3bvuvpz5</para>
        /// </summary>
        [NameInMap("SourceInstanceId")]
        [Validation(Required=false)]
        public string SourceInstanceId { get; set; }

    }

}
