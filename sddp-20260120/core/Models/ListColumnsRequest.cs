// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListColumnsRequest : TeaModel {
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
        /// <para>The cloud database instance identity. Set this parameter to the InstanceId in the instance list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1abcdefgh****</para>
        /// </summary>
        [NameInMap("DataAssetSourceId")]
        [Validation(Required=false)]
        public string DataAssetSourceId { get; set; }

        /// <summary>
        /// <para>The name of the database. Set this parameter to the DbName returned by ListDataSources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>business_db</para>
        /// </summary>
        [NameInMap("DataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// <para>The type of the database engine. This parameter must be consistent with the EngineType of the target instance, such as MySQL or PostgreSQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>The compatible parameter for the instance identity. DataAssetSourceId takes precedence. If both are specified, DataAssetSourceId is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1abcdefgh****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

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
        /// <para>The filter condition for the column name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>phone</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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
        /// <para>The code of the cloud service. Column encryption supports RDS, POLARDB, and PolarDBX2. If ProductId is also specified, the two parameters must match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The identifier of the sensitivity level. You can obtain this value from the return list of ListRiskLevels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskLevelId")]
        [Validation(Required=false)]
        public long? RiskLevelId { get; set; }

        /// <summary>
        /// <para>The identifier of the detection rule or model. Set this parameter to the ID of the corresponding detection rule in the target template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>The name of the data table. In PostgreSQL or Oracle scenarios, retain the schema.table format obtained from the table list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>customer</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The identifier of the data classification and grading template. You can obtain this value from Items[].Id returned by ListTemplates. Keep this parameter consistent with the selected sensitivity level and detection model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
