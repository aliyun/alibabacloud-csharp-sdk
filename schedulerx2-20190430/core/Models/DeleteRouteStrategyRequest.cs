// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class DeleteRouteStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can obtain the application ID on the <b>Application Management</b> page in the SchedulerX console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testSchedulerx.defaultGroup</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The job ID. You can obtain the job ID on the <b>Task Management</b> page in the SchedulerX console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>92583</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// <para>The namespace ID. You can obtain the ID of the namespace on the <b>Namespace</b> page in the SchedulerX console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adcfc35d-e2fe-4fe9-bbaa-20e90ffc****</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

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

    }

}
