// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class ListReportDefinitionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The metadata of the response structure.</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>The data list.</para>
        /// </summary>
        [NameInMap("ReportDefinitions")]
        [Validation(Required=false)]
        public List<ListReportDefinitionsResponseBodyReportDefinitions> ReportDefinitions { get; set; }
        public class ListReportDefinitionsResponseBodyReportDefinitions : TeaModel {
            /// <summary>
            /// <para>The start billing cycle for data push. After a successful subscription, the system automatically pushes data from the start billing cycle to the current time. This parameter is invalid for monthly bill PDF subscriptions and historical data is not pushed again. Data for up to the last year can be pushed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05</para>
            /// </summary>
            [NameInMap("BeginBillingCycle")]
            [Validation(Required=false)]
            public string BeginBillingCycle { get; set; }

            /// <summary>
            /// <para>The name of the OSS bucket where files are stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-bill</para>
            /// </summary>
            [NameInMap("OssBucketName")]
            [Validation(Required=false)]
            public string OssBucketName { get; set; }

            /// <summary>
            /// <para>The UID of the OSS bucket owner. Specify this parameter if the subscription is made by a bidder or reseller and data needs to be pushed to the OSS bucket of a RAM user. The target account must be a RAM user of the calling account and must be granted the AliyunConsumeDump2OSSRole permission. Regular users do not need to specify this parameter. By default, the calling account is used.</para>
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
            /// <para>The type of the subscription source, such as OSS or MC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("ReportSourceType")]
            [Validation(Required=false)]
            public string ReportSourceType { get; set; }

            /// <summary>
            /// <para>The ID of the bill subscription task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123321</para>
            /// </summary>
            [NameInMap("ReportTaskId")]
            [Validation(Required=false)]
            public long? ReportTaskId { get; set; }

            /// <summary>
            /// <para>The subscription type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BillingItemDetailForBillingPeriod: billing item consumption details</description></item>
            /// <item><description>InstanceDetailForBillingPeriod: instance consumption details</description></item>
            /// <item><description>BillingItemDetailMonthly: billing item consumption summary by billing cycle</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BillingItemDetailForBillingPeriod</para>
            /// </summary>
            [NameInMap("ReportType")]
            [Validation(Required=false)]
            public string ReportType { get; set; }

            /// <summary>
            /// <para>The time when the subscription was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-21 10:36:31</para>
            /// </summary>
            [NameInMap("SubscribeCreateTime")]
            [Validation(Required=false)]
            public string SubscribeCreateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79EE7556-0CFD-44EB-9CD6-B3B526E3A85F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
