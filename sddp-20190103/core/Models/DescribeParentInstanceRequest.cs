// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeParentInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The authorization status of the data asset instance.</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Unauthorized.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Authorized.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AuthStatus")]
        [Validation(Required=false)]
        public int? AuthStatus { get; set; }

        /// <summary>
        /// <para>The connection status of the instance or a database in the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>-3</b>: The database is not created.</para>
        /// </description></item>
        /// <item><description><para><b>-2</b>: Released.</para>
        /// </description></item>
        /// <item><description><para><b>-1</b>: Not connected.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Testing connectivity.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: Connected.</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: Connection failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("CheckStatus")]
        [Validation(Required=false)]
        public int? CheckStatus { get; set; }

        /// <summary>
        /// <para>The instance status.</para>
        /// <list type="bullet">
        /// <item><description><para><b>Running</b>: Running.</para>
        /// </description></item>
        /// <item><description><para><b>Released</b>: Released.</para>
        /// </description></item>
        /// <item><description><para><b>DatabaseNotCreated</b>: Database not created.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("ClusterStatus")]
        [Validation(Required=false)]
        public string ClusterStatus { get; set; }

        /// <summary>
        /// <para>The number of the page to return for a paged query. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db_**t</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The type of the database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>MySQL</b>.</para>
        /// </description></item>
        /// <item><description><para><b>MariaDB</b>.</para>
        /// </description></item>
        /// <item><description><para><b>Oracle</b>.</para>
        /// </description></item>
        /// <item><description><para><b>PostgreSQL</b>.</para>
        /// </description></item>
        /// <item><description><para><b>SQLServer</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>The ID of the data asset instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-*******xx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh_cn</b>: Simplified Chinese. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>en_us</b>: U.S. English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the member account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>**********8103</para>
        /// </summary>
        [NameInMap("MemberAccount")]
        [Validation(Required=false)]
        public long? MemberAccount { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page for a paged query. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>This parameter is required. The type of the product. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: MaxCompute</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: OSS</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: ADB-MYSQL</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: TableStore</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: RDS</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: Self-managed database</para>
        /// </description></item>
        /// <item><description><para><b>7</b>: PolarDB-X</para>
        /// </description></item>
        /// <item><description><para><b>8</b>: PolarDB</para>
        /// </description></item>
        /// <item><description><para><b>9</b>: ADB-PG</para>
        /// </description></item>
        /// <item><description><para><b>10</b>: OceanBase</para>
        /// </description></item>
        /// <item><description><para><b>11</b>: MongoDB</para>
        /// </description></item>
        /// <item><description><para><b>25</b>: Redis</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public long? ResourceType { get; set; }

        /// <summary>
        /// <para>The region where the asset resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-beijing</b>: China (Beijing).</para>
        /// </description></item>
        /// <item><description><para><b>cn-zhangjiakou</b>: China (Zhangjiakou).</para>
        /// </description></item>
        /// <item><description><para><b>cn-huhehaote</b>: China (Hohhot).</para>
        /// </description></item>
        /// <item><description><para><b>cn-hangzhou</b>: China (Hangzhou).</para>
        /// </description></item>
        /// <item><description><para><b>cn-shanghai</b>: China (Shanghai).</para>
        /// </description></item>
        /// <item><description><para><b>cn-shenzhen</b>: China (Shenzhen).</para>
        /// </description></item>
        /// <item><description><para><b>cn-hongkong</b>: China (Hong Kong).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

    }

}
