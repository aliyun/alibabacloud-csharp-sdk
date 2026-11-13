// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListDataMaskingInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The filter condition for the column name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>phone</para>
        /// </summary>
        [NameInMap("ColumnName")]
        [Validation(Required=false)]
        public string ColumnName { get; set; }

        /// <summary>
        /// <para>The page number of the current query. Pages start from 1.</para>
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
        /// <para>business_db</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The type of the database engine. The value must be consistent with the EngineType of the target instance, such as MySQL or PostgreSQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>The database instance identity. You can obtain the value from the Items[].InstanceId parameter in the response of the ListDataMaskingInstances operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1abcdefgh****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language of the response description. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese.</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The column encryption status filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NotEncrypted: Unencrypted.</description></item>
        /// <item><description>Success: Encrypted successfully.</description></item>
        /// <item><description>Failed: Encryption failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NotEncrypted</para>
        /// </summary>
        [NameInMap("MaskingStatus")]
        [Validation(Required=false)]
        public string MaskingStatus { get; set; }

        /// <summary>
        /// <para>The ID of the model tag. This parameter is used to limit the data that matches the corresponding model tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("ModelTagId")]
        [Validation(Required=false)]
        public string ModelTagId { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Keep other filter conditions consistent when querying the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The code of the cloud service. Column encryption supports RDS, PolarDB, and PolarDB-X 2.0. If this parameter is specified together with ProductId, the values must correspond to each other.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The ID of the cloud service type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>5: RDS.</description></item>
        /// <item><description>8: PolarDB.</description></item>
        /// <item><description>27: PolarDB-X 2.0.
        /// If this parameter is specified together with ProductCode, the values must correspond to each other.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <para>The list of cloud service type IDs. Separate multiple values with commas (,). In column encryption scenarios, the valid values are 5 (RDS), 8 (PolarDB), and 27 (PolarDB-X 2.0).</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductIds")]
        [Validation(Required=false)]
        public string ProductIds { get; set; }

        /// <summary>
        /// <para>The ID of the sensitivity level. You can obtain the value from the response list of the ListRiskLevels operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskLevelId")]
        [Validation(Required=false)]
        public long? RiskLevelId { get; set; }

        /// <summary>
        /// <para>The list of sensitivity level IDs. Separate multiple values with commas (,). Select the values from the response of the ListRiskLevels operation corresponding to the same TemplateId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2</para>
        /// </summary>
        [NameInMap("RiskLevelIds")]
        [Validation(Required=false)]
        public string RiskLevelIds { get; set; }

        /// <summary>
        /// <para>The name of the table. In PostgreSQL or Oracle scenarios, retain the schema.table format obtained from the table list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>customer</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The ID of the data classification template. You can obtain the value from the Items[].Id parameter in the response of the ListTemplates operation. The value must be consistent with the selected sensitivity level and identification model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// <para>The list of identification model IDs. Separate multiple values with commas (,). Select the values from the response of the ListIdentifyModels operation corresponding to the same TemplateId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001,1002</para>
        /// </summary>
        [NameInMap("TemplateRuleIds")]
        [Validation(Required=false)]
        public string TemplateRuleIds { get; set; }

    }

}
