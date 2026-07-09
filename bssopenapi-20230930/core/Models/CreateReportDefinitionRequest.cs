// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class CreateReportDefinitionRequest : TeaModel {
        /// <summary>
        /// <para>The start billing cycle for push. After the subscription succeeds, the system automatically pushes data from the start billing cycle to the current time. This parameter is invalid for monthly bill PDF subscriptions, and historical data will not be re-pushed. You can push data within the last year.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-05</para>
        /// </summary>
        [NameInMap("BeginBillingCycle")]
        [Validation(Required=false)]
        public string BeginBillingCycle { get; set; }

        /// <summary>
        /// <para>The email subscription configuration that specifies whether to include multi-account members of the organization in bills.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeMembers")]
        [Validation(Required=false)]
        public string IncludeMembers { get; set; }

        /// <summary>
        /// <para>The name of the MaxCompute project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project</para>
        /// </summary>
        [NameInMap("McProject")]
        [Validation(Required=false)]
        public string McProject { get; set; }

        /// <summary>
        /// <para>The name of the MaxCompute subscription table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table</para>
        /// </summary>
        [NameInMap("McTableName")]
        [Validation(Required=false)]
        public string McTableName { get; set; }

        /// <summary>
        /// <para>The first-level site ID. If this parameter is left empty, the site ID of the current user is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        /// <summary>
        /// <para>The email subscription configuration that specifies whether to skip sending emails when no bills are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NotSendOnNoData")]
        [Validation(Required=false)]
        public string NotSendOnNoData { get; set; }

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
        /// <para>The UID of the OSS bucket owner that stores the files. If this is a Bid/Reseller subscription and you need to push data to a sub-account\&quot;s OSS, specify this parameter. The account must be a sub-account of the calling account, and the AliyunConsumeDump2OSSRole permission must be granted to this account. Regular users do not need to specify this parameter. The default value is the calling account.</para>
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
        /// <para>The subscription source. Valid values: OSS, MC, and MSC_EMAIL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("ReportSourceType")]
        [Validation(Required=false)]
        public string ReportSourceType { get; set; }

        /// <summary>
        /// <para>The subscription type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>consumeDetailBillV2: consumption details. This value is supported only by OSS/MC subscriptions.</description></item>
        /// <item><description>splitDetailBillV2: split details. This value is supported only by OSS/MC subscriptions.</description></item>
        /// <item><description>costDetailBillV2: cost details. This value is supported only by OSS/MC subscriptions.</description></item>
        /// <item><description>monthBillOverview: monthly bill overview. This value is supported only by OSS/MSC_EMAIL subscriptions.</description></item>
        /// <item><description>focus: FOCUS bill. This value is supported only by OSS/MC subscriptions.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>consumeDetailBillV2</para>
        /// </summary>
        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

        /// <summary>
        /// <para>The email subscription configuration that specifies whether to send emails with bill attachments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SendWithAttach")]
        [Validation(Required=false)]
        public string SendWithAttach { get; set; }

        /// <summary>
        /// <para>The email subscription configuration that specifies whether to split attachments by user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SplitFileOnUserId")]
        [Validation(Required=false)]
        public string SplitFileOnUserId { get; set; }

    }

}
