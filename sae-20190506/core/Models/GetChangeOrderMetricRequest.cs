// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class GetChangeOrderMetricRequest : TeaModel {
        /// <summary>
        /// <para>The SAE application type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>micro_service</b></description></item>
        /// <item><description><b>web</b></description></item>
        /// <item><description><b>job</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>micro_service</para>
        /// </summary>
        [NameInMap("AppSource")]
        [Validation(Required=false)]
        public string AppSource { get; set; }

        /// <summary>
        /// <para>The CPU allocation policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>request</b>: CPU cores are allocated only when a request is initiated.</description></item>
        /// <item><description><b>always</b>: Fixed CPU cores are always allocated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>always</para>
        /// </summary>
        [NameInMap("CpuStrategy")]
        [Validation(Required=false)]
        public string CpuStrategy { get; set; }

        /// <summary>
        /// <para>The start time when the change order was created.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1661152748883</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The number of entries to return. Valid values: 0 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <para>The field based on which you want to sort the returned entries.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>errorPercent</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
