// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class CreateReportDefinitionResponseBody : TeaModel {
        /// <summary>
        /// <para>The start billing cycle for data push. After the subscription is created, the system automatically pushes data from the start billing cycle to the current time. This parameter is invalid for monthly billing PDF subscriptions, and historical data is not pushed again. Data within the recent year can be pushed at most.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-05</para>
        /// </summary>
        [NameInMap("BeginBillingCycle")]
        [Validation(Required=false)]
        public string BeginBillingCycle { get; set; }

        /// <summary>
        /// <para>The metadata of the response structure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>The name of the OSS bucket that stores the files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sh-bill</para>
        /// </summary>
        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// <para>The UID of the OSS owner that stores the files. Specify this parameter when a BID or reseller subscription needs to push files to the OSS bucket of a RAM user. The RAM user must be a subordinate account of the calling account and must be granted the AliyunConsumeDump2OSSRole permission. Regular users do not need to specify this parameter. The default value is the calling account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567812345678</para>
        /// </summary>
        [NameInMap("OssBucketOwnerAccountId")]
        [Validation(Required=false)]
        public long? OssBucketOwnerAccountId { get; set; }

        /// <summary>
        /// <para>The storage path in the OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bill/</para>
        /// </summary>
        [NameInMap("OssBucketPath")]
        [Validation(Required=false)]
        public string OssBucketPath { get; set; }

        /// <summary>
        /// <para>The name of the subscription source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("ReportSourceName")]
        [Validation(Required=false)]
        public string ReportSourceName { get; set; }

        /// <summary>
        /// <para>The subscription source. Valid values: OSS and MC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("ReportSourceType")]
        [Validation(Required=false)]
        public string ReportSourceType { get; set; }

        /// <summary>
        /// <para>The ID of the billing subscription task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123123</para>
        /// </summary>
        [NameInMap("ReportTaskId")]
        [Validation(Required=false)]
        public long? ReportTaskId { get; set; }

        /// <summary>
        /// <para>The subscription type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>consumeDetailBillV2: consumption details (supported only by OSS and MC subscriptions).</description></item>
        /// <item><description>splitDetailBillV2: split details (supported only by OSS and MC subscriptions).</description></item>
        /// <item><description>costDetailBillV2: cost details (supported only by OSS and MC subscriptions).</description></item>
        /// <item><description>monthBillOverview: monthly bill summary (supported only by OSS and MSC_EMAIL subscriptions).</description></item>
        /// <item><description>focus: focus bills (supported only by OSS and MC subscriptions).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>consumeDetailBillV2</para>
        /// </summary>
        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>340CAB45-0637-5875-9BE4-EFD5750F6BA5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The time when the subscription was created. The time is in the YYYY-MM-DD HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-05-21 10:36:31</para>
        /// </summary>
        [NameInMap("SubscribeCreateTime")]
        [Validation(Required=false)]
        public string SubscribeCreateTime { get; set; }

    }

}
