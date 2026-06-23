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
        /// <item><description><para>Public: a public endpoint</para>
        /// </description></item>
        /// <item><description><para>Private: a private endpoint</para>
        /// </description></item>
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
        /// <para>The comments on the new database. The comments can be up to 500 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpp</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The name of the new database instance. This parameter is required if you set Source to <b>Local</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test01</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The port used to connect to the database. This parameter is required if you set Source to <b>Local</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5433</para>
        /// </summary>
        [NameInMap("DatabasePort")]
        [Validation(Required=false)]
        public int? DatabasePort { get; set; }

        /// <summary>
        /// <para>The private endpoint of the database. You can use an IPv4 address or a domain name.</para>
        /// <remarks>
        /// <para>This parameter is required if you set ActiveAddressType to Private.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("DatabasePrivateAddress")]
        [Validation(Required=false)]
        public string DatabasePrivateAddress { get; set; }

        /// <summary>
        /// <para>The public endpoint of the database. You can use an IPv4 address or a domain name.</para>
        /// <remarks>
        /// <para>This parameter is required if you set ActiveAddressType to Public.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("DatabasePublicAddress")]
        [Validation(Required=false)]
        public string DatabasePublicAddress { get; set; }

        /// <summary>
        /// <para>The type of the database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>MySQL</b></para>
        /// </description></item>
        /// <item><description><para><b>Oracle</b></para>
        /// </description></item>
        /// <item><description><para><b>PostgreSQL</b></para>
        /// </description></item>
        /// <item><description><para><b>SQLServer</b></para>
        /// </description></item>
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
        /// <para>The ID of the Bastionhost instance.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to obtain this parameter.</para>
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
        /// <para>The ID of the Alibaba Cloud account to which the new RDS or PolarDB database instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1605494xxxx</para>
        /// </summary>
        [NameInMap("InstanceMemberId")]
        [Validation(Required=false)]
        public long? InstanceMemberId { get; set; }

        /// <summary>
        /// <para>The ID of the network domain for the new database.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/2758827.html">ListNetworkDomains</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NetworkDomainId")]
        [Validation(Required=false)]
        public string NetworkDomainId { get; set; }

        /// <summary>
        /// <para>This parameter is required if you set Source to PolarDB. This parameter specifies the endpoint type of the PolarDB database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Cluster: a cluster endpoint</para>
        /// </description></item>
        /// <item><description><para>Primary: a primary endpoint</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Cluster</para>
        /// </summary>
        [NameInMap("PolarDBEndpointType")]
        [Validation(Required=false)]
        public string PolarDBEndpointType { get; set; }

        /// <summary>
        /// <para>The region ID of the Bastionhost instance.</para>
        /// <remarks>
        /// <para>For a list of region IDs and their corresponding region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
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
        /// <item><description><para>Local: a local database instance</para>
        /// </description></item>
        /// <item><description><para>Rds: an RDS database instance</para>
        /// </description></item>
        /// <item><description><para>PolarDB: a PolarDB database instance</para>
        /// </description></item>
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
        /// <para>The ID of the database instance.</para>
        /// <remarks>
        /// <para>This parameter is required if you set <b>Source</b> to <b>Rds</b> or <b>PolarDB</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp19ienyt0yax748****</para>
        /// </summary>
        [NameInMap("SourceInstanceId")]
        [Validation(Required=false)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the database instance.</para>
        /// <remarks>
        /// <para>This parameter is required if <b>Source</b> is set to <b>Rds</b> or <b>PolarDB</b>.</para>
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
