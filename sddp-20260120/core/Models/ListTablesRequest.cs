// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListTablesRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page. Pages start from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The instance identity of the cloud database instance. Set the value to the InstanceId value in the instance list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1abcdefgh****</para>
        /// </summary>
        [NameInMap("DataAssetSourceId")]
        [Validation(Required=false)]
        public string DataAssetSourceId { get; set; }

        /// <summary>
        /// <para>The name of the database. Set the value to the DbName value returned by the ListDataSources operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>business_db</para>
        /// </summary>
        [NameInMap("DataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values: zh: Chinese. en: English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The start position of the cursor-based pagination. Use the NextMarker value returned in the previous request for subsequent requests. Keep the value consistent with the original filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public long? Marker { get; set; }

        /// <summary>
        /// <para>The name filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>customer</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Keep other filter conditions consistent when you query the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The code of the cloud service. Column encryption supports ApsaraDB RDS, PolarDB, and PolarDB-X 2.0. If you specify this parameter and ProductId at the same time, the values must match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The ID of the cloud service type. Valid values: 5: ApsaraDB RDS. 8: PolarDB. 27: PolarDB-X 2.0. If you specify this parameter and ProductCode at the same time, the values must match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <para>The ID of the sensitivity level. You can obtain the ID from the response of the ListRiskLevels operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskLevelId")]
        [Validation(Required=false)]
        public long? RiskLevelId { get; set; }

        /// <summary>
        /// <para>The ID of the detection rule or model. Set the value to the ID of the corresponding detection rule in the target template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>The ID of the data classification template. You can obtain the ID from the Items[].Id parameter in the response of the ListTemplates operation. The value must be consistent with the selected sensitivity level and detection model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
