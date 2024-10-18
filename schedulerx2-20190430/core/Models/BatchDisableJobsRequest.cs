// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class BatchDisableJobsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. You can obtain the application ID on the <b>Application Management</b> page in the SchedulerX console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testSchedulerx.defaultGroup</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The job IDs. Separate multiple job IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99341</para>
        /// </summary>
        [NameInMap("JobIdList")]
        [Validation(Required=false)]
        public List<long?> JobIdList { get; set; }

        /// <summary>
        /// <para>The ID of the namespace to which the job belongs. You can obtain the ID of the namespace on the <b>Namespace</b> page in the SchedulerX console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adcfc35d-e2fe-4fe9-bbaa-20e90ffc****</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The source of the namespace. This parameter is required only for a special third party.</para>
        /// 
        /// <b>Example:</b>
        /// <para>schedulerx</para>
        /// </summary>
        [NameInMap("NamespaceSource")]
        [Validation(Required=false)]
        public string NamespaceSource { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the job belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
