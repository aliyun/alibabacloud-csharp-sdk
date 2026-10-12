// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListParametersRequest : TeaModel {
        /// <summary>
        /// <para>The list of parameter IDs.</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public List<long?> Ids { get; set; }

        /// <summary>
        /// <para>The list of parameter names.</para>
        /// </summary>
        [NameInMap("Names")]
        [Validation(Required=false)]
        public List<string> Names { get; set; }

        /// <summary>
        /// <para>The account ID of the owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the workspace. You can call the ListProjects operation to obtain the workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The scope of the parameter. Default value: Project. Other types are not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Project</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The list of fields by which to sort the results. Supported fields include modification time and creation time. The format is &quot;SortField+SortOrder(Desc/Asc)&quot;. You can omit Asc. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ModifyTime (Desc/Asc)</description></item>
        /// <item><description>CreateTime (Desc/Asc)</description></item>
        /// <item><description>Name (Desc/Asc)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ModifyTime Desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The parameter type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PlainConstant: plaintext constant.</description></item>
        /// <item><description>SecretConstant: ciphertext constant.</description></item>
        /// <item><description>Variable: variable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PlainConstant</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
