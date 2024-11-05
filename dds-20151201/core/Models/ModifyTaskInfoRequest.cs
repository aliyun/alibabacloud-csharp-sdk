// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyTaskInfoRequest : TeaModel {
        /// <summary>
        /// <para>A action-related parameter. This parameter can be extended based on your business requirements. This parameter value varies with the value of the TaskAction parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;recoverMode\&quot;:\&quot;immediate\&quot;}</para>
        /// </summary>
        [NameInMap("ActionParams")]
        [Validation(Required=false)]
        public string ActionParams { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The name of the step visible to the user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exec_task</para>
        /// </summary>
        [NameInMap("StepName")]
        [Validation(Required=false)]
        public string StepName { get; set; }

        /// <summary>
        /// <para>The action name that corresponds to the state described in the actionInfo parameter of the <a href="https://help.aliyun.com/document_detail/2639186.html">DescribeHistoryTasks</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>modifySwitchTime</para>
        /// </summary>
        [NameInMap("TaskAction")]
        [Validation(Required=false)]
        public string TaskAction { get; set; }

        /// <summary>
        /// <para>The task ID. Separate multiple IDs with commas (,). You can specify up to 10 task IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-83br18hlpdrw3uxxxx</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
