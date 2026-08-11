// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class CreateDatabaseRequest : TeaModel {
        /// <summary>
        /// <para>The address type of the new database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Public: public address</description></item>
        /// <item><description>Private: private network address</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("ActiveAddressType")]
        [Validation(Required=false)]
        public string ActiveAddressType { get; set; }

        /// <summary>
        /// <para>The remarks of the new database. The value can be up to 500 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpp</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The name of the new database instance. This parameter is required when the database source is <b>Local</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test01</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The port used to access the database. This parameter is required when the database source is <b>Local</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5433</para>
        /// </summary>
        [NameInMap("DatabasePort")]
        [Validation(Required=false)]
        public int? DatabasePort { get; set; }

        /// <summary>
        /// <para>The private network address. IPv4 addresses and domain name formats are supported.</para>
        /// <remarks>
        /// <para>This parameter is required when ActiveAddressType is set to Private.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("DatabasePrivateAddress")]
        [Validation(Required=false)]
        public string DatabasePrivateAddress { get; set; }

        /// <summary>
        /// <para>The public address. IPv4 addresses and domain name formats are supported.</para>
        /// <remarks>
        /// <para>This parameter is required when ActiveAddressType is set to Public.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("DatabasePublicAddress")]
        [Validation(Required=false)]
        public string DatabasePublicAddress { get; set; }

        /// <summary>
        /// <para>The database type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>Oracle</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
        /// <item><description><b>SQLServer</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DatabaseType")]
        [Validation(Required=false)]
        public string DatabaseType { get; set; }

        /// <summary>
        /// <para>The ID of the bastion host instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-7mz2g5hu20e</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the new ApsaraDB RDS or PolarDB database instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1605494xxxx</para>
        /// </summary>
        [NameInMap("InstanceMemberId")]
        [Validation(Required=false)]
        public long? InstanceMemberId { get; set; }

        /// <summary>
        /// <para>The ID of the network domain to which the new database belongs.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2758827.html">ListNetworkDomains</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NetworkDomainId")]
        [Validation(Required=false)]
        public string NetworkDomainId { get; set; }

        /// <summary>
        /// <para>The endpoint type of the PolarDB cluster. This parameter is required when Source is set to PolarDB. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Cluster: cluster endpoint</description></item>
        /// <item><description>Primary: primary endpoint</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Cluster</para>
        /// </summary>
        [NameInMap("PolarDBEndpointType")]
        [Validation(Required=false)]
        public string PolarDBEndpointType { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host.</para>
        /// <remarks>
        /// <para>For the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The source of the new database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Local: self-managed database instance</description></item>
        /// <item><description>Rds: ApsaraDB RDS instance</description></item>
        /// <item><description>PolarDB: PolarDB cluster</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Local</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The instance ID of the new database.  </para>
        /// <remarks>
        /// <para>This parameter is required when <b>Source</b> is set to <b>Rds</b> or <b>PolarDB</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp19ienyt0yax748****</para>
        /// </summary>
        [NameInMap("SourceInstanceId")]
        [Validation(Required=false)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the new database instance.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>Source</b> is set to <b>Rds</b> or <b>PolarDB</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("SourceInstanceRegionId")]
        [Validation(Required=false)]
        public string SourceInstanceRegionId { get; set; }

    }

}
