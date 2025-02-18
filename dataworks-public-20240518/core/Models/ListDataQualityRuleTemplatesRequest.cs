// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityRuleTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The source of the rule template. Required.</para>
        /// <list type="bullet">
        /// <item><description>System: System Template</description></item>
        /// <item><description>UserDefined: user-defined Template</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>System</para>
        /// </summary>
        [NameInMap("CreationSource")]
        [Validation(Required=false)]
        public string CreationSource { get; set; }

        /// <summary>
        /// <para>The category directory where the custom template is stored, slash/divider level. Each level name can be up to 1024 characters in length and cannot contain white space characters or backslashes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/ods/order_data</para>
        /// </summary>
        [NameInMap("DirectoryPath")]
        [Validation(Required=false)]
        public string DirectoryPath { get; set; }

        /// <summary>
        /// <para>Fuzzy matching of template rule names. If it is a system template, the internationalized name of the system template will be fuzzy matching based on the language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Table rows</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>DataWorks workspace ID.</para>
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
