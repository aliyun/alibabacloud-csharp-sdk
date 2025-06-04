// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class UpdateAiCallTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CallDay")]
        [Validation(Required=false)]
        public List<string> CallDay { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("CallRetryInterval")]
        [Validation(Required=false)]
        public long? CallRetryInterval { get; set; }

        [NameInMap("CallRetryReason")]
        [Validation(Required=false)]
        public List<string> CallRetryReason { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CallRetryTimes")]
        [Validation(Required=false)]
        public long? CallRetryTimes { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CallTime")]
        [Validation(Required=false)]
        public List<string> CallTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("MissCallRetry")]
        [Validation(Required=false)]
        public bool? MissCallRetry { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IMMEDIATE</para>
        /// </summary>
        [NameInMap("StartType")]
        [Validation(Required=false)]
        public string StartType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1152311212312***</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1748923429000</para>
        /// </summary>
        [NameInMap("TaskStartTime")]
        [Validation(Required=false)]
        public long? TaskStartTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0537022*****</para>
        /// </summary>
        [NameInMap("VirtualNumber")]
        [Validation(Required=false)]
        public string VirtualNumber { get; set; }

    }

}
