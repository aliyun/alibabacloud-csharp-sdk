// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityRuleTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The source of the template. This parameter is required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>System</description></item>
        /// <item><description>UserDefined</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>System</para>
        /// </summary>
        [NameInMap("CreationSource")]
        [Validation(Required=false)]
        public string CreationSource { get; set; }

        /// <summary>
        /// <para>The directory in which the template is stored. Slashes (/) are used to separate directory levels. The name of each directory level can be up to 1,024 characters in length. It cannot contain whitespace characters or slashes (/).</para>
        /// 
        /// <b>Example:</b>
        /// <para>/ods/order_data</para>
        /// </summary>
        [NameInMap("DirectoryPath")]
        [Validation(Required=false)]
        public string DirectoryPath { get; set; }

        /// <summary>
        /// <para>The name of the template. If you want to query a system template, set this parameter to the name of the system template. Fuzzy match is supported.</para>
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
