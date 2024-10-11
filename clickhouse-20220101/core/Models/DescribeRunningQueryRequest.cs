// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20220101.Models
{
    public class DescribeRunningQueryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cc-bp1qx68m06981****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("QueryDurationMs")]
        [Validation(Required=false)]
        public long? QueryDurationMs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c8cbcbaf-d4ab-4e74-900d-90d7c0aecaae</para>
        /// </summary>
        [NameInMap("QueryId")]
        [Validation(Required=false)]
        public string QueryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>order by</para>
        /// </summary>
        [NameInMap("QueryKeyWord")]
        [Validation(Required=false)]
        public string QueryKeyWord { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("QueryUser")]
        [Validation(Required=false)]
        public string QueryUser { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vw-uf62965t8lt50****</para>
        /// </summary>
        [NameInMap("VirtualWareHouseId")]
        [Validation(Required=false)]
        public string VirtualWareHouseId { get; set; }

    }

}
