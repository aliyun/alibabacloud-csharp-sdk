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
        /// <item><description>all: Queries both dn and gms nodes.</description></item>
        /// <item><description>gms: Queries only gms nodes.</description></item>
        /// <item><description>dn: Queries only dn nodes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dn</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// <para>The page number. The value must be an integer greater than 0 and less than or equal to the maximum value of the INTEGER data type. Default value: <b>1</b>.</para>
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
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp1c5w4fx****2274</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

    }

}
