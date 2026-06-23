// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityRuleTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The creation source of the rule template. This parameter is required.</para>
        /// <list type="bullet">
        /// <item><description>System: system template</description></item>
        /// <item><description>UserDefined: user-defined template</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>System</para>
        /// </summary>
        [NameInMap("CreationSource")]
        [Validation(Required=false)]
        public string CreationSource { get; set; }

        /// <summary>
        /// <para>The category directory in which the custom template is stored. Levels are separated by forward slashes (/). Each level name can be up to 1,024 characters in length and cannot contain whitespace characters or backslashes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/ods/order_data</para>
        /// </summary>
        [NameInMap("DirectoryPath")]
        [Validation(Required=false)]
        public string DirectoryPath { get; set; }

        /// <summary>
        /// <para>The fuzzy match of the template rule name. For a system template, the internationalized name of the system template is fuzzy matched based on the language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Table rows</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paginated query. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page number of a paginated query. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
