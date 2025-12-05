// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class CreateDatabaseRequest : TeaModel {
        /// <summary>
        /// <para>The address type of the database to add. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Public</description></item>
        /// <item><description>Private</description></item>
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
        /// <para>The remarks of the database to add. The remarks can be up to 500 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpp</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The name of the database to add. This parameter is required if Source is set to <b>Local</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Oracle</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The port of the database. This parameter is required if Source is set to <b>Local</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5433</para>
        /// </summary>
        [NameInMap("DatabasePort")]
        [Validation(Required=false)]
        public int? DatabasePort { get; set; }

        /// <summary>
        /// <para>The internal IP address of the database. Specify an IPv4 address or a domain name.</para>
        /// <remarks>
        /// <para> This parameter is required if ActiveAddressType is set to Private.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-uf6o******</para>
        /// </summary>
        [NameInMap("DatabasePrivateAddress")]
        [Validation(Required=false)]
        public string DatabasePrivateAddress { get; set; }

        /// <summary>
        /// <para>The public IP address of the database. Specify an IPv4 address or a domain name.</para>
        /// <remarks>
        /// <para> This parameter is required if ActiveAddressType is set to Public.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf65251k51******</para>
        /// </summary>
        [NameInMap("DatabasePublicAddress")]
        [Validation(Required=false)]
        public string DatabasePublicAddress { get; set; }

        /// <summary>
        /// <para>The type of the database engine. Valid values:</para>
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
        /// <para>The bastion host ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the bastion host ID.</para>
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
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InstanceMemberId")]
        [Validation(Required=false)]
        public long? InstanceMemberId { get; set; }

        /// <summary>
        /// <para>The ID of the network domain to which the database to add belongs.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2758827.html">ListNetworkDomains</a> operation to query the network domain ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NetworkDomainId")]
        [Validation(Required=false)]
        public string NetworkDomainId { get; set; }

        /// <summary>
        /// <para>The endpoint type of the PolarDB database. This parameter is required if Source is set to PolarDB. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Cluster</description></item>
        /// <item><description>Primary</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Cluster</para>
        /// </summary>
        [NameInMap("PolarDBEndpointType")]
        [Validation(Required=false)]
        public string PolarDBEndpointType { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host.</para>
        /// <remarks>
        /// <para>For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The type of the database to add. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Local: on-premises database.</description></item>
        /// <item><description>Rds: ApsaraDB RDS instance.</description></item>
        /// <item><description>PolarDB: PolarDB cluster.</description></item>
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
        /// <para>The instance ID of the database to add.</para>
        /// <remarks>
        /// <para>This parameter is required if <b>Source</b> is set to <b>Rds</b> or <b>PolarDB</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp19ienyt0yax748****</para>
        /// </summary>
        [NameInMap("SourceInstanceId")]
        [Validation(Required=false)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the database to add.</para>
        /// <remarks>
        /// <para> This parameter is required if <b>Source</b> is set to <b>Rds</b> or <b>PolarDB</b>.</para>
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
