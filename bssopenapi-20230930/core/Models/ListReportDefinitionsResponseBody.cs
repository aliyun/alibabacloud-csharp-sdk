// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class ListReportDefinitionsResponseBody : TeaModel {
        /// <summary>
        /// <para>Response structure metadata</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>Report definition list</para>
        /// </summary>
        [NameInMap("ReportDefinitions")]
        [Validation(Required=false)]
        public List<ListReportDefinitionsResponseBodyReportDefinitions> ReportDefinitions { get; set; }
        public class ListReportDefinitionsResponseBodyReportDefinitions : TeaModel {
            /// <summary>
            /// <para>Whether to enable tag fields</para>
            /// </summary>
            [NameInMap("AutoTagFields")]
            [Validation(Required=false)]
            public bool? AutoTagFields { get; set; }

            /// <summary>
            /// <para>Push start billing cycle. After the subscription is successfully created, the system automatically pushes data from the start billing cycle to the current time. This parameter is invalid for monthly billing PDF subscriptions and does not re-push historical data. A maximum of data from the last 1 year can be pushed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05</para>
            /// </summary>
            [NameInMap("BeginBillingCycle")]
            [Validation(Required=false)]
            public string BeginBillingCycle { get; set; }

            /// <summary>
            /// <para>Name of the OSS bucket where files are stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-bill</para>
            /// </summary>
            [NameInMap("OssBucketName")]
            [Validation(Required=false)]
            public string OssBucketName { get; set; }

            /// <summary>
            /// <para>UID of the OSS owner that stores the files. Specify this parameter if you subscribe as a BID/ReSeller and want to push data to the OSS of a sub-account. The specified account must be a sub-account of the calling account and must be granted the AliyunConsumeDump2OSSRole permission. Regular users do not need to specify this parameter. The default value is the calling account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567812345678</para>
            /// </summary>
            [NameInMap("OssBucketOwnerAccountId")]
            [Validation(Required=false)]
            public long? OssBucketOwnerAccountId { get; set; }

            /// <summary>
            /// <para>OSS bucket storage path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bill/</para>
            /// </summary>
            [NameInMap("OssBucketPath")]
            [Validation(Required=false)]
            public string OssBucketPath { get; set; }

            /// <summary>
            /// <para>Name of the subscription source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("ReportSourceName")]
            [Validation(Required=false)]
            public string ReportSourceName { get; set; }

            /// <summary>
            /// <para>Type of the subscription source. Valid values: OSS and MC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("ReportSourceType")]
            [Validation(Required=false)]
            public string ReportSourceType { get; set; }

            /// <summary>
            /// <para>Billing subscription task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123321</para>
            /// </summary>
            [NameInMap("ReportTaskId")]
            [Validation(Required=false)]
            public long? ReportTaskId { get; set; }

            /// <summary>
            /// <para>Subscription type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BillingItemDetailForBillingPeriod: billing item consumption details.</description></item>
            /// <item><description>InstanceDetailForBillingPeriod: instance consumption details.</description></item>
            /// <item><description>BillingItemDetailMonthly: billing item consumption summary by billing cycle.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BillingItemDetailForBillingPeriod</para>
            /// </summary>
            [NameInMap("ReportType")]
            [Validation(Required=false)]
            public string ReportType { get; set; }

            /// <summary>
            /// <para>Specified subscribed fields</para>
            /// </summary>
            [NameInMap("SelectedFields")]
            [Validation(Required=false)]
            public List<string> SelectedFields { get; set; }

            /// <summary>
            /// <para>Time when the subscription was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-21 10:36:31</para>
            /// </summary>
            [NameInMap("SubscribeCreateTime")]
            [Validation(Required=false)]
            public string SubscribeCreateTime { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79EE7556-0CFD-44EB-9CD6-B3B526E3A85F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
