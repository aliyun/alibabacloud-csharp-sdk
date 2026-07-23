// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListFeatureConsistencyCheckJobsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. To obtain the instance ID, see <a href="https://help.aliyun.com/document_detail/2411819.html">ListInstances</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-********</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ASC</c>: Ascending order.</para>
        /// </description></item>
        /// <item><description><para><c>DESC</c>: Descending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The field to sort the results by. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>GmtCreateTime</c>: Sorts by creation time.</para>
        /// </description></item>
        /// <item><description><para><c>GmtModifiedTime</c>: Sorts by modification time.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The status of the job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ToRun</c>: Waiting to run.</para>
        /// </description></item>
        /// <item><description><para><c>Running</c>: In progress.</para>
        /// </description></item>
        /// <item><description><para><c>Success</c>: Successful.</para>
        /// </description></item>
        /// <item><description><para><c>Failure</c>: Failed.</para>
        /// </description></item>
        /// <item><description><para><c>Stopped</c>: Stopped or canceled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
