// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CmsV1MigrationTaskView : TeaModel {
        /// <summary>
        /// <para>The migration batch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00112233-4455-4677-8899-aabbccddeeff</para>
        /// </summary>
        [NameInMap("batchId")]
        [Validation(Required=false)]
        public string BatchId { get; set; }

        /// <summary>
        /// <para>Indicates whether to provide a recovery prompt for existing frozen tasks. This field does not grant authorization. Each recovery re-verifies the original bindings. Tasks with the SUCCESS status are not retried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("canRecover")]
        [Validation(Required=false)]
        public bool? CanRecover { get; set; }

        /// <summary>
        /// <para>The task failure description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNSUPPORTED_RESOURCE: source members cannot be translated without loss</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The source application group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order-service</para>
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The target observation group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>og-0123456789abcdef</para>
        /// </summary>
        [NameInMap("observeGroupId")]
        [Validation(Required=false)]
        public string ObserveGroupId { get; set; }

        /// <summary>
        /// <para>The source CloudMonitor 1.0 application group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>247675311</para>
        /// </summary>
        [NameInMap("originGroupId")]
        [Validation(Required=false)]
        public string OriginGroupId { get; set; }

        /// <summary>
        /// <para>Indicates whether the source 1.0 group is persistently set to read-only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("sourceReadOnly")]
        [Validation(Required=false)]
        public bool? SourceReadOnly { get; set; }

        /// <summary>
        /// <para>The migration task status. Valid values: PENDING, RUNNING, SUCCESS, SKIPPED, and FAILED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FAILED</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The takeover stage. Valid values: PENDING, SOURCE_LOCKED, TARGET_CREATED, READ_ONLY, and NEEDS_REVIEW.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SOURCE_LOCKED</para>
        /// </summary>
        [NameInMap("takeoverStage")]
        [Validation(Required=false)]
        public string TakeoverStage { get; set; }

        /// <summary>
        /// <para>The target observation group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order-service</para>
        /// </summary>
        [NameInMap("targetGroupName")]
        [Validation(Required=false)]
        public string TargetGroupName { get; set; }

        /// <summary>
        /// <para>The migration task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
