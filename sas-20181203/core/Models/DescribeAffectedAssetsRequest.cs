// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAffectedAssetsRequest : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Current")]
        [Validation(Required=false)]
        public string Current { get; set; }

        /// <summary>
        /// <para>The severity level. Separate multiple values with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>serious: urgent</description></item>
        /// <item><description>suspicious: suspicious</description></item>
        /// <item><description>remind: reminder.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>serious,suspicious,remind</para>
        /// </summary>
        [NameInMap("Levels")]
        [Validation(Required=false)]
        public string Levels { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page in a paginated query. Default value: 20. If this parameter is left empty, 20 entries are returned.</para>
        /// <remarks>
        /// <para>Do not leave PageSize empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

    }

}
