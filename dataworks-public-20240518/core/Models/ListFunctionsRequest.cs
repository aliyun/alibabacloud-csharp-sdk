// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListFunctionsRequest : TeaModel {
        /// <summary>
        /// <para>Filter criteria: UDF name. Supports fuzzy search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the owner of the UDF. This parameter specifies a filter condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>110755000425XXXX</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1. Minimum value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1. Minimum value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to query the ID.</para>
        /// <para>You must configure this parameter to specify the DataWorks workspace to which the API operation is applied.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The user-defined function (UDF) type. This parameter specifies a filter condition.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Math: mathematical operation function</para>
        /// </description></item>
        /// <item><description><para>Aggregate: aggregate function</para>
        /// </description></item>
        /// <item><description><para>String: string processing function</para>
        /// </description></item>
        /// <item><description><para>Date: date function</para>
        /// </description></item>
        /// <item><description><para>Analytic: window function</para>
        /// </description></item>
        /// <item><description><para>Other: other functions</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Math</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
