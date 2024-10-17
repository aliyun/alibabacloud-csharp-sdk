// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DropSearchIndexRequest : TeaModel {
        /// <summary>
        /// <para>The category of the index. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>mm: large visual model.</description></item>
        /// <item><description>face: face recognition.</description></item>
        /// <item><description>aiLabel: smart tagging.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mm</para>
        /// </summary>
        [NameInMap("IndexType")]
        [Validation(Required=false)]
        public string IndexType { get; set; }

        /// <summary>
        /// <para>The name of the search library.</para>
        /// <list type="bullet">
        /// <item><description>If you leave this parameter empty, the search index is created in the default search library of Intelligent Media Service (IMS). Default value: ims-default-search-lib.</description></item>
        /// <item><description>To query information about an existing search library, call the <a href="https://help.aliyun.com/document_detail/2584455.html">QuerySearchLib</a> API operation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("SearchLibName")]
        [Validation(Required=false)]
        public string SearchLibName { get; set; }

    }

}
