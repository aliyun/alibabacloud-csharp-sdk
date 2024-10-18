// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class ExecuteJobRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to check the job status. Valid values: -<b>true</b>: The job can be run only if the job is enabled. -<b>false</b>: The job can be run even if the job is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CheckJobStatus")]
        [Validation(Required=false)]
        public bool? CheckJobStatus { get; set; }

        /// <summary>
        /// <para>The type of the designated machine. Valid values: -<b>1</b>: worker. -<b>2</b>: label.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DesignateType")]
        [Validation(Required=false)]
        public int? DesignateType { get; set; }

        /// <summary>
        /// <para>The application ID. You can obtain the application ID on the Application Management page in the SchedulerX console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testSchedulerx.defaultGroup</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The parameters that are passed to trigger the job to run. The input value can be a random string. The parameters that are passed are obtained by calling the <c>context.getInstanceParameters()</c> class in the <c>processor</c> code. The parameters are different from custom parameters for creating jobs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("InstanceParameters")]
        [Validation(Required=false)]
        public string InstanceParameters { get; set; }

        /// <summary>
        /// <para>The job ID. You can obtain the job ID on the Task Management page in the SchedulerX console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>92583</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// <para>The label of the worker.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gray</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>The namespace ID. You can obtain the namespace ID on the Namespace page in the SchedulerX console.</para>
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
        /// <para>The worker address of the application. To query the worker address, call the GetWokerList operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:xxxxxxx@127.0.0.1">xxxxxxx@127.0.0.1</a>:222</para>
        /// </summary>
        [NameInMap("Worker")]
        [Validation(Required=false)]
        public string Worker { get; set; }

    }

}
