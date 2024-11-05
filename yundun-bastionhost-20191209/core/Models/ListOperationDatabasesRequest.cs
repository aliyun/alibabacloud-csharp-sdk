// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListOperationDatabasesRequest : TeaModel {
        /// <summary>
        /// <para>The address of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.167.66.167</para>
        /// </summary>
        [NameInMap("DatabaseAddress")]
        [Validation(Required=false)]
        public string DatabaseAddress { get; set; }

        /// <summary>
        /// <para>The name of the database instance. The system supports exact search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aaa</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The type of the database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>SQLServer</b></description></item>
        /// <item><description><b>Oracle</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
        /// </list>
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
        /// <para>bastionhost-cn-tl32wloo90y</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.\
        /// Maximum value: 100. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.</para>
        /// <remarks>
        /// <para> We recommend that you do not leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host.</para>
        /// <remarks>
        /// <para> For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The source of the database instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Local</b></description></item>
        /// <item><description><b>Rds</b></description></item>
        /// <item><description><b>PolarDB</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Local</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The ID of the ApsaraDB RDS instance. The system supports exact search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp19ienyt0yax748****</para>
        /// </summary>
        [NameInMap("SourceInstanceId")]
        [Validation(Required=false)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// <para>The instance state.</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b></description></item>
        /// <item><description><b>RemoteRelease</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("SourceInstanceState")]
        [Validation(Required=false)]
        public string SourceInstanceState { get; set; }

    }

}
