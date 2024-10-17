// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QuerySearchIndexResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The state of the index. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>active: the index is enabled.</description></item>
        /// <item><description>Deactive: the index is not enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("IndexStatus")]
        [Validation(Required=false)]
        public string IndexStatus { get; set; }

        /// <summary>
        /// <para>The category of the index. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>mm: large visual model.</description></item>
        /// <item><description>face: face recognition.</description></item>
        /// <item><description>aiLabel: smart tagging.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mm</para>
        /// </summary>
        [NameInMap("IndexType")]
        [Validation(Required=false)]
        public string IndexType { get; set; }

        /// <summary>
        /// <para>The total number of media assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("MediaTotal")]
        [Validation(Required=false)]
        public string MediaTotal { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E84BE44-58A7-<b><b>-</b></b>-FBEBEA16EF94</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The name of the search library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("SearchLibName")]
        [Validation(Required=false)]
        public string SearchLibName { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
