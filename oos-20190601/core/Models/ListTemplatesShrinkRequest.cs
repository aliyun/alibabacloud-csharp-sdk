// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListTemplatesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The type of the template. Valid values include TimerTrigger, EventTrigger, AlarmTrigger, and Other.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TimerTrigger</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The creator of the template.</para>
        /// <list type="bullet">
        /// <item><description>To query the template provided by Alibaba Cloud, set this parameter to <b>ACS</b>.</description></item>
        /// <item><description>To query the template created by a user, set this parameter to the <b>ID</b> of the template or the <b>name of the user</b> who creates the template.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACS</para>
        /// </summary>
        [NameInMap("CreatedBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// <para>Specifies to query the template that is created at or later than the specified time.</para>
        /// <para>The value must be in the YYYY-MM-DDThh:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-05-16T10:26:14Z</para>
        /// </summary>
        [NameInMap("CreatedDateAfter")]
        [Validation(Required=false)]
        public string CreatedDateAfter { get; set; }

        /// <summary>
        /// <para>Specifies to query the template that is created at or before the specified time.</para>
        /// <para>The value must be in the YYYY-MM-DDThh:mm::ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-05-16T10:26:14Z</para>
        /// </summary>
        [NameInMap("CreatedDateBefore")]
        [Validation(Required=false)]
        public string CreatedDateBefore { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the template that is configured with a trigger.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasTrigger")]
        [Validation(Required=false)]
        public bool? HasTrigger { get; set; }

        /// <summary>
        /// <para>Specifies whether the template is an example template</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsExample")]
        [Validation(Required=false)]
        public bool? IsExample { get; set; }

        /// <summary>
        /// <para>Specifies whether the template is added to favorites.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsFavorite")]
        [Validation(Required=false)]
        public bool? IsFavorite { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 10 to 100. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the region in which you want to query templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxsn4m4******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The share type of the template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Public</b></description></item>
        /// <item><description><b>Private</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Private</para>
        /// </summary>
        [NameInMap("ShareType")]
        [Validation(Required=false)]
        public string ShareType { get; set; }

        /// <summary>
        /// <para>The field that is used to sort the templates to be queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TotalExecutionCount</b> (default): The system sorts the returned templates based on the total number of times that the templates are used.</description></item>
        /// <item><description><b>Popularity</b>: The system sorts the returned templates based on the popularity of the templates.</description></item>
        /// <item><description><b>TemplateName</b>: The system sorts the returned templates based on the names of the templates.</description></item>
        /// <item><description><b>CreatedDate</b>: The system sorts the returned templates based on the points in time when the templates are created.</description></item>
        /// <item><description><b>UpdatedDate</b>: The system sorts the returned templates based on the points in time when the templates are updated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Popularity</para>
        /// </summary>
        [NameInMap("SortField")]
        [Validation(Required=false)]
        public string SortField { get; set; }

        /// <summary>
        /// <para>The order in which you want to sort the results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Ascending</b>: ascending order.</description></item>
        /// <item><description><b>Descending</b>: descending order. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Descending</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <para>The tag keys and values. The number of key-value pairs ranges from 1 to 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;k1&quot;:&quot;k2&quot;,&quot;k2&quot;:&quot;v2&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>The format of the template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>JSON</b></description></item>
        /// <item><description><b>YAML</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>YAML</para>
        /// </summary>
        [NameInMap("TemplateFormat")]
        [Validation(Required=false)]
        public string TemplateFormat { get; set; }

        /// <summary>
        /// <para>The name of the template. All templates whose names contain the specified template name are to be returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyTemplate</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The type of the template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Automation: the template for automated tasks.</description></item>
        /// <item><description>State: the template for configuration inventories.</description></item>
        /// <item><description>Package: the template for software packages.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>private</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
