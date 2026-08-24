// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class CreateReportDefinitionResponseBody : TeaModel {
        /// <summary>
        /// <para>The start billing cycle for push. After successful subscription, the system automatically pushes data from the start billing cycle to the current time. This parameter is invalid for monthly bill PDF subscriptions and does not re-push historical data. Data within the last year can be pushed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-05</para>
        /// </summary>
        [NameInMap("BeginBillingCycle")]
        [Validation(Required=false)]
        public string BeginBillingCycle { get; set; }

        /// <summary>
        /// <para>The response struct metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>The name of the OSS bucket for file storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sh-bill</para>
        /// </summary>
        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// <para>The UID of the OSS owner that stores the files. If this is a Bid/Reseller subscription and you need to push to a sub-account\&quot;s OSS, specify this parameter. The account must be a sub-account of the calling account, and the AliyunConsumeDump2OSSRole permission must be granted to this account. Regular users do not need to specify this parameter. The default value is the calling account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567812345678</para>
        /// </summary>
        [NameInMap("OssBucketOwnerAccountId")]
        [Validation(Required=false)]
        public long? OssBucketOwnerAccountId { get; set; }

        /// <summary>
        /// <para>The OSS bucket storage path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bill/</para>
        /// </summary>
        [NameInMap("OssBucketPath")]
        [Validation(Required=false)]
        public string OssBucketPath { get; set; }

        /// <summary>
        /// <para>The subscription source name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("ReportSourceName")]
        [Validation(Required=false)]
        public string ReportSourceName { get; set; }

        /// <summary>
        /// <para>The subscription source. Valid values: OSS or MC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("ReportSourceType")]
        [Validation(Required=false)]
        public string ReportSourceType { get; set; }

        /// <summary>
        /// <para>The bill subscription task ID.</para>
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
        /// <item><description>consumeDetailBillV2: consumption details (supported only for OSS/MC subscriptions).</description></item>
        /// <item><description>splitDetailBillV2: split details (supported only for OSS/MC subscriptions).</description></item>
        /// <item><description>costDetailBillV2: cost details (supported only for OSS/MC subscriptions).</description></item>
        /// <item><description>monthBillOverview: monthly bill summary (supported only for OSS/MSC_EMAIL subscriptions).</description></item>
        /// <item><description>focus: FOCUS bill (supported only for OSS/MC subscriptions).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>consumeDetailBillV2</para>
        /// </summary>
        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>340CAB45-0637-5875-9BE4-EFD5750F6BA5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The subscription creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-05-21 10:36:31</para>
        /// </summary>
        [NameInMap("SubscribeCreateTime")]
        [Validation(Required=false)]
        public string SubscribeCreateTime { get; set; }

    }

}
