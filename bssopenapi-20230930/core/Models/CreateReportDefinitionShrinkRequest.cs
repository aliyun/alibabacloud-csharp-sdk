// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class CreateReportDefinitionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The start billing cycle for data push. After the subscription is created, the system automatically pushes data from the start billing cycle to the current time. This parameter is invalid for monthly billing PDF subscriptions, and historical data is not pushed again. Data within the most recent year can be pushed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-05</para>
        /// </summary>
        [NameInMap("BeginBillingCycle")]
        [Validation(Required=false)]
        public string BeginBillingCycle { get; set; }

        /// <summary>
        /// <para>Specifies whether to include enterprise multi-account members in bills for email subscriptions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeMembers")]
        [Validation(Required=false)]
        public string IncludeMembers { get; set; }

        /// <summary>
        /// <para>The name of the MC project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project</para>
        /// </summary>
        [NameInMap("McProject")]
        [Validation(Required=false)]
        public string McProject { get; set; }

        /// <summary>
        /// <para>The name of the MC subscription table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table</para>
        /// </summary>
        [NameInMap("McTableName")]
        [Validation(Required=false)]
        public string McTableName { get; set; }

        /// <summary>
        /// <para>The ID of the level-1 site. If this parameter is left empty, the ID of the site to which the current user belongs is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        /// <summary>
        /// <para>Specifies whether to skip sending emails when no bills are generated for email subscriptions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NotSendOnNoData")]
        [Validation(Required=false)]
        public string NotSendOnNoData { get; set; }

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
        /// <para>The UID of the OSS owner that stores the files. Specify this parameter if the subscription is made by a bidder or reseller and the files need to be pushed to the OSS bucket of a RAM user. The RAM user must be a subordinate account of the calling account and must be granted the AliyunConsumeDump2OSSRole permission. Regular users do not need to specify this parameter. The default value is the calling account.</para>
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
        /// <item><description>consumeDetailBillV2: consumption details. Supported only for OSS and MC subscriptions.</description></item>
        /// <item><description>splitDetailBillV2: split details. Supported only for OSS and MC subscriptions.</description></item>
        /// <item><description>costDetailBillV2: cost details. Supported only for OSS and MC subscriptions.</description></item>
        /// <item><description>monthBillOverview: monthly bill overview. Supported only for OSS and MSC_EMAIL subscriptions.</description></item>
        /// <item><description>focus: focus bills. Supported only for OSS and MC subscriptions.</description></item>
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
        /// <para>The fields to which the user subscribes.</para>
        /// </summary>
        [NameInMap("SelectedFields")]
        [Validation(Required=false)]
        public string SelectedFieldsShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to include bill attachments in emails for email subscriptions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SendWithAttach")]
        [Validation(Required=false)]
        public string SendWithAttach { get; set; }

        /// <summary>
        /// <para>Specifies whether to split attachments by user ID for email subscriptions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SplitFileOnUserId")]
        [Validation(Required=false)]
        public string SplitFileOnUserId { get; set; }

    }

}
