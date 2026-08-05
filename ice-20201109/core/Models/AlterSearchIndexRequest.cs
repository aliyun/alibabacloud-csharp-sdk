// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AlterSearchIndexRequest : TeaModel {
        /// <summary>
        /// <para>The index configuration.</para>
        /// <remarks>
        /// <para>Notice:  You must specify either IndexStatus or IndexConfig.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("IndexConfig")]
        [Validation(Required=false)]
        public string IndexConfig { get; set; }

        /// <summary>
        /// <para>The index status. Default value: Active. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Active: activated.</description></item>
        /// <item><description>Deactive: deactivated.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice:  You must specify either IndexStatus or IndexConfig.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("IndexStatus")]
        [Validation(Required=false)]
        public string IndexStatus { get; set; }

        /// <summary>
        /// <para>The index type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>mm: large model.</description></item>
        /// <item><description>face: face.</description></item>
        /// <item><description>aiLabel: intelligent tag.</description></item>
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
        /// <para>The search library name.</para>
        /// <list type="bullet">
        /// <item><description>If no search library name is specified, the search index is created in the default IMS search library. Default value: ims-default-search-lib.</description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/2584455.html">QuerySearchLib</a> operation to query existing search library information.</description></item>
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
