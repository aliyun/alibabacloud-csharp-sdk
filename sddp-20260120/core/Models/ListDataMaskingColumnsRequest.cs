// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListDataMaskingColumnsRequest : TeaModel {
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
        /// <para>The current page number for the query. Pages start from 1.</para>
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
        /// <para>The type of the database engine. It must be consistent with the EngineType of the target instance, such as MySQL or PostgreSQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>The instance identity of the database. You can obtain it from Items[].InstanceId in the response of ListDataMaskingInstances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1abcdefgh****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language of the response description. Valid values: zh: Chinese; en: English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The filter for the column encryption status. Valid values: NotEncrypted: not encrypted; Success: encrypted successfully; Failed: encryption failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NotEncrypted</para>
        /// </summary>
        [NameInMap("MaskingStatus")]
        [Validation(Required=false)]
        public string MaskingStatus { get; set; }

        /// <summary>
        /// <para>The number of records to return per page. Keep other filter conditions consistent when querying the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The code of the cloud service. Column encryption supports RDS, POLARDB, and PolarDBX2. If ProductId is also provided, the two must correspond to each other.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The ID of the cloud service type. Valid values: 5: RDS; 8: POLARDB; 27: PolarDBX2. It must correspond to ProductCode if both are specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <para>The compatible parameter for the list of product IDs. For the current column query, use a single ProductId or ProductCode. Call the operation separately to query multiple products.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductIds")]
        [Validation(Required=false)]
        public string ProductIds { get; set; }

        /// <summary>
        /// <para>The ID of a single sensitivity level. You can obtain it from ListRiskLevels. The uppercase L in the parameter name must be preserved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskLeveLId")]
        [Validation(Required=false)]
        public long? RiskLeveLId { get; set; }

        /// <summary>
        /// <para>The list of sensitivity level IDs. Separate multiple values with commas. Select the values from the response of ListRiskLevels corresponding to the same TemplateId.</para>
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
        /// <para>The ID of the data classification template. You can obtain it from Items[].Id in the response of ListTemplates. It must be consistent with the selected sensitivity level and detection model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// <para>The list of detection model IDs. Separate multiple values with commas. Select the values from the response of ListIdentifyModels corresponding to the same TemplateId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001,1002</para>
        /// </summary>
        [NameInMap("TemplateRuleIds")]
        [Validation(Required=false)]
        public string TemplateRuleIds { get; set; }

    }

}
