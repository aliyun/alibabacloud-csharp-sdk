// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListTemplatesShrinkRequest : TeaModel {
        /// <summary>
        /// The type of the template. Valid values include TimerTrigger, EventTrigger, AlarmTrigger, and Other.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The creator of the template.
        /// 
        /// *   To query the template provided by Alibaba Cloud, set this parameter to **ACS**.
        /// *   To query the template created by a user, set this parameter to the **ID** of the template or the **name of the user** who creates the template.
        /// </summary>
        [NameInMap("CreatedBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Specifies to query the template that is created at or later than the specified time.
        /// 
        /// The value must be in the YYYY-MM-DDThh:mm:ssZ format.
        /// </summary>
        [NameInMap("CreatedDateAfter")]
        [Validation(Required=false)]
        public string CreatedDateAfter { get; set; }

        /// <summary>
        /// Specifies to query the template that is created at or before the specified time.
        /// 
        /// The value must be in the YYYY-MM-DDThh:mm::ssZ format.
        /// </summary>
        [NameInMap("CreatedDateBefore")]
        [Validation(Required=false)]
        public string CreatedDateBefore { get; set; }

        /// <summary>
        /// Specifies whether to query the template that is configured with a trigger.
        /// </summary>
        [NameInMap("HasTrigger")]
        [Validation(Required=false)]
        public bool? HasTrigger { get; set; }

        /// <summary>
        /// The template is favorite or not.
        /// </summary>
        [NameInMap("IsFavorite")]
        [Validation(Required=false)]
        public bool? IsFavorite { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 20 to 100. Default value: 50.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used to retrieve the next page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the region in which you want to query templates.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The share type of the template. Valid values:
        /// 
        /// *   **Public**
        /// *   **Private**
        /// </summary>
        [NameInMap("ShareType")]
        [Validation(Required=false)]
        public string ShareType { get; set; }

        /// <summary>
        /// The field that is used to sort the templates to be queried. Valid values:
        /// 
        /// *   **TotalExecutionCount** (default): The system sorts the returned templates based on the total number of times that the templates are used.
        /// *   **Popularity**: The system sorts the returned templates based on the popularity of the templates.
        /// *   **TemplateName**: The system sorts the returned templates based on the names of the templates.
        /// *   **CreatedDate**: The system sorts the returned templates based on the points in time when the templates are created.
        /// *   **UpdatedDate**: The system sorts the returned templates based on the points in time when the templates are updated.
        /// </summary>
        [NameInMap("SortField")]
        [Validation(Required=false)]
        public string SortField { get; set; }

        /// <summary>
        /// The order in which you want to sort the results. Valid values:
        /// 
        /// *   **Ascending**: ascending order.
        /// *   **Descending**: descending order. This is the default value.
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// The tag keys and values. The number of key-value pairs ranges from 1 to 20.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// The format of the template. Valid values:
        /// 
        /// *   **JSON**
        /// *   **YAML**
        /// </summary>
        [NameInMap("TemplateFormat")]
        [Validation(Required=false)]
        public string TemplateFormat { get; set; }

        /// <summary>
        /// The name of the template. All templates whose names contain the specified template name are to be returned.
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// The type of the template. Valid values:
        /// 
        /// *   Automation: the template for automated tasks.
        /// *   State: the template for configuration inventories.
        /// *   Package: the template for software packages.
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
