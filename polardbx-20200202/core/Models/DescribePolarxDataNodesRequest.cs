// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribePolarxDataNodesRequest : TeaModel {
        /// <summary>
        /// <para>The type of nodes to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>all: queries both dn and gms nodes.</description></item>
        /// <item><description>gms: queries only gms nodes.</description></item>
        /// <item><description>dn: queries only dn nodes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dn</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// <para>The page number. The value must be a positive integer that does not exceed the maximum value of the integer data type. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region in which the instance resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The keyword for filtering query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp1c5w4fx****2274</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

    }

}
