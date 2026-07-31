// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeUserResourcePackageRequest : TeaModel {
        /// <summary>
        /// <para>The resource plan instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>_ResourcePack-cn-</b></b></para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The sorting field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>startTime: the effective period of the instance.</description></item>
        /// <item><description>endTime: the expiration time of the instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>startTime</para>
        /// </summary>
        [NameInMap("SortField")]
        [Validation(Required=false)]
        public string SortField { get; set; }

        /// <summary>
        /// <para>The sorting collation. Default value: desc. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>asc</description></item>
        /// <item><description>desc</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortRule")]
        [Validation(Required=false)]
        public string SortRule { get; set; }

        /// <summary>
        /// <para>The status of the resource plan. Default value: valid. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>valid: Valid.</description></item>
        /// <item><description>invalid: Invalid.</description></item>
        /// <item><description>exhaust: Exhausted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>valid</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
