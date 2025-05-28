// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class CreateReportDefinitionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-05</para>
        /// </summary>
        [NameInMap("BeginBillingCycle")]
        [Validation(Required=false)]
        public string BeginBillingCycle { get; set; }

        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sh-bill</para>
        /// </summary>
        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234567812345678</para>
        /// </summary>
        [NameInMap("OssBucketOwnerAccountId")]
        [Validation(Required=false)]
        public long? OssBucketOwnerAccountId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bill/</para>
        /// </summary>
        [NameInMap("OssBucketPath")]
        [Validation(Required=false)]
        public string OssBucketPath { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("ReportSourceName")]
        [Validation(Required=false)]
        public string ReportSourceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("ReportSourceType")]
        [Validation(Required=false)]
        public string ReportSourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123123</para>
        /// </summary>
        [NameInMap("ReportTaskId")]
        [Validation(Required=false)]
        public long? ReportTaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BillingItemDetailForBillingPeriod</para>
        /// </summary>
        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>340CAB45-0637-5875-9BE4-EFD5750F6BA5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-05-21 10:36:31</para>
        /// </summary>
        [NameInMap("SubscribeCreateTime")]
        [Validation(Required=false)]
        public string SubscribeCreateTime { get; set; }

    }

}
