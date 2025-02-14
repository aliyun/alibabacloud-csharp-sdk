// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListTargetByBatchRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the release batch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1371</para>
        /// </summary>
        [NameInMap("BatchId")]
        [Validation(Required=false)]
        public long? BatchId { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paginated query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Asset selection dimension. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Machine instance</description></item>
        /// <item><description><b>1</b>: Machine group</description></item>
        /// <item><description><b>2</b>: VPC instance ID</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OperationBase")]
        [Validation(Required=false)]
        public int? OperationBase { get; set; }

        /// <summary>
        /// <para>The maximum number of items to return per page in a paginated query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
