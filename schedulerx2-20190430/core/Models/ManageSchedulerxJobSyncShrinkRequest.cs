// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class ManageSchedulerxJobSyncShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of task IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("JobIdList")]
        [Validation(Required=false)]
        public string JobIdListShrink { get; set; }

        /// <summary>
        /// <para>The source of the namespace. Required only for specific third-party cases.</para>
        /// 
        /// <b>Example:</b>
        /// <para>schedulerx</para>
        /// </summary>
        [NameInMap("NamespaceSource")]
        [Validation(Required=false)]
        public string NamespaceSource { get; set; }

        /// <summary>
        /// <para>The source application group to which the task belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testSchedulerx.defaultGroup</para>
        /// </summary>
        [NameInMap("OriginalGroupId")]
        [Validation(Required=false)]
        public string OriginalGroupId { get; set; }

        /// <summary>
        /// <para>The source namespace where the task resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adcfc35d-e2fe-4fe9-bbaa-20e90ffc****</para>
        /// </summary>
        [NameInMap("OriginalNamespace")]
        [Validation(Required=false)]
        public string OriginalNamespace { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the destination application group to which the task will be synchronized.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testSyncJobGroup</para>
        /// </summary>
        [NameInMap("TargetGroupId")]
        [Validation(Required=false)]
        public string TargetGroupId { get; set; }

        /// <summary>
        /// <para>The destination namespace to which the task will be synchronized.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5f56ef65-b836-493d-b40b-c4db6425****</para>
        /// </summary>
        [NameInMap("TargetNamespace")]
        [Validation(Required=false)]
        public string TargetNamespace { get; set; }

    }

}
