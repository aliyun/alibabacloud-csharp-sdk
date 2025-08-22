// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class CreateReportDefinitionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-05</para>
        /// </summary>
        [NameInMap("BeginBillingCycle")]
        [Validation(Required=false)]
        public string BeginBillingCycle { get; set; }

        [NameInMap("IncludeMembers")]
        [Validation(Required=false)]
        public string IncludeMembers { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>project</para>
        /// </summary>
        [NameInMap("McProject")]
        [Validation(Required=false)]
        public string McProject { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>table</para>
        /// </summary>
        [NameInMap("McTableName")]
        [Validation(Required=false)]
        public string McTableName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        [NameInMap("NotSendOnNoData")]
        [Validation(Required=false)]
        public string NotSendOnNoData { get; set; }

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
        [NameInMap("ReportSourceType")]
        [Validation(Required=false)]
        public string ReportSourceType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BillingItemDetailForBillingPeriod</para>
        /// </summary>
        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

        [NameInMap("SendWithAttach")]
        [Validation(Required=false)]
        public string SendWithAttach { get; set; }

        [NameInMap("SplitFileOnUserId")]
        [Validation(Required=false)]
        public string SplitFileOnUserId { get; set; }

    }

}
