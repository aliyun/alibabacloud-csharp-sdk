// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class ListReportDefinitionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The metadata of the response struct.</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>The list of report definitions.</para>
        /// </summary>
        [NameInMap("ReportDefinitions")]
        [Validation(Required=false)]
        public List<ListReportDefinitionsResponseBodyReportDefinitions> ReportDefinitions { get; set; }
        public class ListReportDefinitionsResponseBodyReportDefinitions : TeaModel {
            /// <summary>
            /// <para>The start billing cycle for push. After the subscription is created, the system automatically pushes data from the start billing cycle to the current time. This parameter does not take effect for monthly bill PDF subscriptions, and historical data is not re-pushed. Data within the last year can be pushed at most.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05</para>
            /// </summary>
            [NameInMap("BeginBillingCycle")]
            [Validation(Required=false)]
            public string BeginBillingCycle { get; set; }

            /// <summary>
            /// <para>The name of the OSS bucket for file storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-bill</para>
            /// </summary>
            [NameInMap("OssBucketName")]
            [Validation(Required=false)]
            public string OssBucketName { get; set; }

            /// <summary>
            /// <para>The UID of the OSS owner that stores the files. If a Bid/Reseller subscription is used and data needs to be pushed to the OSS bucket of a sub-account, specify this parameter. The specified account must be a sub-account of the calling account, and the AliyunConsumeDump2OSSRole permission must be granted to this account. Regular users do not need to specify this parameter. The calling account is used by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567812345678</para>
            /// </summary>
            [NameInMap("OssBucketOwnerAccountId")]
            [Validation(Required=false)]
            public long? OssBucketOwnerAccountId { get; set; }

            /// <summary>
            /// <para>The storage path of the OSS bucket.</para>
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
            /// <para>The fields specified by the user for the subscription.</para>
            /// </summary>
            [NameInMap("SelectedFields")]
            [Validation(Required=false)]
            public List<string> SelectedFields { get; set; }

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
