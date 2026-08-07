// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeParentInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The authorization status of the data asset instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Unauthorized.</description></item>
        /// <item><description><b>1</b>: Authorized.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AuthStatus")]
        [Validation(Required=false)]
        public int? AuthStatus { get; set; }

        /// <summary>
        /// <para>The database connection status of the instance or the database under the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-3</b>: The database is not created.</description></item>
        /// <item><description><b>-2</b>: Released.</description></item>
        /// <item><description><b>-1</b>: Not connected.</description></item>
        /// <item><description><b>2</b>: Connectivity test in progress.</description></item>
        /// <item><description><b>3</b>: Connected.</description></item>
        /// <item><description><b>4</b>: Connection failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("CheckStatus")]
        [Validation(Required=false)]
        public int? CheckStatus { get; set; }

        /// <summary>
        /// <para>The instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Running</b>: Running.</description></item>
        /// <item><description><b>Released</b>: Released.</description></item>
        /// <item><description><b>DatabaseNotCreated</b>: The database is not created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("ClusterStatus")]
        [Validation(Required=false)]
        public string ClusterStatus { get; set; }

        /// <summary>
        /// <para>The page number when paging is used. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db_**t</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The engine type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>MariaDB</b></description></item>
        /// <item><description><b>Oracle</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
        /// <item><description><b>SQLServer</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>The instance ID of the asset to which the column data in the data asset table belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-*******xx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh_cn</b>: Chinese (Simplified). This is the default value.</description></item>
        /// <item><description><b>en_us</b>: English (US).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the member accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>**********8103</para>
        /// </summary>
        [NameInMap("MemberAccount")]
        [Validation(Required=false)]
        public long? MemberAccount { get; set; }

        /// <summary>
        /// <para>The number of entries per page when paging is used. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Required. The product type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: MaxCompute</description></item>
        /// <item><description><b>2</b>: OSS</description></item>
        /// <item><description><b>3</b>: ADB-MYSQL</description></item>
        /// <item><description><b>4</b>: TableStore</description></item>
        /// <item><description><b>5</b>: RDS</description></item>
        /// <item><description><b>6</b>: SelfDB</description></item>
        /// <item><description><b>7</b>: PolarDB-X</description></item>
        /// <item><description><b>8</b>: PolarDB</description></item>
        /// <item><description><b>9</b>: ADB-PG</description></item>
        /// <item><description><b>10</b>: OceanBase</description></item>
        /// <item><description><b>11</b>: MongoDB</description></item>
        /// <item><description><b>25</b>: Redis</description></item>
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
        /// <item><description><b>cn-beijing</b>: China (Beijing).</description></item>
        /// <item><description><b>cn-zhangjiakou</b>: China (Zhangjiakou).</description></item>
        /// <item><description><b>cn-huhehaote</b>: China (Hohhot).</description></item>
        /// <item><description><b>cn-hangzhou</b>: China (Hangzhou).</description></item>
        /// <item><description><b>cn-shanghai</b>: China (Shanghai).</description></item>
        /// <item><description><b>cn-shenzhen</b>: China (Shenzhen).</description></item>
        /// <item><description><b>cn-hongkong</b>: Hong Kong (China).</description></item>
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
