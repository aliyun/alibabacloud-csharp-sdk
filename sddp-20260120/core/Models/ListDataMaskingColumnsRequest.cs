// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListDataMaskingColumnsRequest : TeaModel {
        /// <summary>
        /// <para>The column name filter.</para>
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
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>business_db</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The database engine type. This value must match the EngineType of the target instance, for example, MySQL or PostgreSQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>The instance identity of the database. You can obtain this value from Items[].InstanceId in the response of the ListDataMaskingInstances operation.</para>
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
        /// <item><description>NotEncrypted: Not encrypted.</description></item>
        /// <item><description>Success: Encryption succeeded.</description></item>
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
        /// <para>The number of records per page. Keep other filter conditions consistent when querying the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The cloud product code. Column encryption supports RDS, POLARDB, and PolarDBX2. If ProductId is also specified, the two values must correspond.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The cloud product type ID. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>5: RDS.</description></item>
        /// <item><description>8: POLARDB.</description></item>
        /// <item><description>27: PolarDBX2.</description></item>
        /// </list>
        /// <para>This value must correspond to ProductCode if both are specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <para>The compatible product ID list parameter. For column queries, use a single ProductId or ProductCode. Call the operation separately for each product when querying multiple products.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductIds")]
        [Validation(Required=false)]
        public string ProductIds { get; set; }

        /// <summary>
        /// <para>The ID of a sensitivity level. You can obtain this value from the ListRiskLevels operation. The uppercase L in the parameter name must be preserved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskLeveLId")]
        [Validation(Required=false)]
        public long? RiskLeveLId { get; set; }

        /// <summary>
        /// <para>The list of sensitivity level IDs, separated by commas. Select values from the ListRiskLevels response that corresponds to the same TemplateId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2</para>
        /// </summary>
        [NameInMap("RiskLevelIds")]
        [Validation(Required=false)]
        public string RiskLevelIds { get; set; }

        /// <summary>
        /// <para>The table name. For PostgreSQL or Oracle scenarios, preserve the schema.table format obtained from the table list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>customer</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The ID of the data classification template. You can obtain this value from Items[].Id in the response of the ListTemplates operation. This value must be consistent with the selected sensitivity level and detection model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// <para>The list of detection model IDs, separated by commas. Select values from the ListIdentifyModels response that corresponds to the same TemplateId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001,1002</para>
        /// </summary>
        [NameInMap("TemplateRuleIds")]
        [Validation(Required=false)]
        public string TemplateRuleIds { get; set; }

    }

}
