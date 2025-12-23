// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListFunctionResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The output level.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>simple</description></item>
        /// <item><description>normal</description></item>
        /// <item><description>detail</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>detail</para>
        /// </summary>
        [NameInMap("output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The type of the resource.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>feature_generator</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>raw_file</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>feature_generator</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
