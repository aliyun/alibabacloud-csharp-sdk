// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeBatchResultCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The type of the batch operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DOMAIN_ADD</para>
        /// </summary>
        [NameInMap("BatchType")]
        [Validation(Required=false)]
        public string BatchType { get; set; }

        /// <summary>
        /// <para>The total number of domain names or DNS records that failed to be processed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("FailedCount")]
        [Validation(Required=false)]
        public int? FailedCount { get; set; }

        /// <summary>
        /// <para>The reason why the task failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>No match is found for the domain name specified in the file.</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75446CC1-FC9A-4595-8D96-089D73D7A63D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>-1</b>: No task was submitted to import domain names or DNS records.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: Processing</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Completed</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Failed</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The total number of domain names or DNS records that were successfully processed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

        /// <summary>
        /// <para>The ID of the last task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1******</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>The total number of records that are processed in batches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
