// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListRegionsRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. The default value is zh-CN. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh-CN (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para>en-US: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page.</para>
        /// <para>Valid values: 1 to 100.</para>
        /// <para>Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0axxxx</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The product name. The default value is Next. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Next: The E-HPC Cluster product, formerly known as E-HPC NEXT.</para>
        /// </description></item>
        /// <item><description><para>Instant: The E-HPC Instant product.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Next</para>
        /// </summary>
        [NameInMap("SpecCode")]
        [Validation(Required=false)]
        public string SpecCode { get; set; }

    }

}
