// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListSoftwarelibSoftwareRequest : TeaModel {
        /// <summary>
        /// <para>The software classification ID. You can obtain the value from <a href="~~ListSoftwarelibClassify~~">ListSoftwarelibClassify</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>softwarelib-classify-61b7ccc63cae****</para>
        /// </summary>
        [NameInMap("ClassifyId")]
        [Validation(Required=false)]
        public string ClassifyId { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paging query. Valid values: 1 to 10000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page. This parameter is not supported by this operation. Use CurrentPage and PageSize for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. This parameter is not supported by this operation. Use CurrentPage and PageSize for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAARbaCuN6hiD08qrLdwJ9Fh27/Jy4SXvlU9WgqeV7az+t</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The operating system to which the software package applies. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Windows</b>: Windows.</description></item>
        /// <item><description><b>Mac(Apple)</b>: macOS with Apple silicon.</description></item>
        /// <item><description><b>Mac(Intel)</b>: macOS with Intel processors.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Windows</para>
        /// </summary>
        [NameInMap("Os")]
        [Validation(Required=false)]
        public string Os { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paging query. Valid values: 1 to 500.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The software name. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Thunder</para>
        /// </summary>
        [NameInMap("SoftwareName")]
        [Validation(Required=false)]
        public string SoftwareName { get; set; }

        /// <summary>
        /// <para>The software source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>custom</b>: custom software.</description></item>
        /// <item><description><b>builtin</b>: built-in software library.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>builtin</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
