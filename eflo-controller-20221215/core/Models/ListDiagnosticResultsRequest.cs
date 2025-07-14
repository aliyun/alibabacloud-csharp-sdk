// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListDiagnosticResultsRequest : TeaModel {
        /// <summary>
        /// <para>Type of diagnosis, indicating which diagnostic rules are hit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NetDiag</para>
        /// </summary>
        [NameInMap("DiagType")]
        [Validation(Required=false)]
        public string DiagType { get; set; }

        /// <summary>
        /// <para>Number of items per page in a paginated query. The maximum value is 100.</para>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description>If no value is set or the set value is less than 20, the default value is 20.</description></item>
        /// <item><description>If the set value is greater than 100, the default value is 100.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>NextToken for the next page. Include this value when requesting the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a3f2224a5ec7224116c4f5246120abe4</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmywpvugkh7kq</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
