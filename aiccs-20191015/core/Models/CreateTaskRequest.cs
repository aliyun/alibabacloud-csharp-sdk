// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class CreateTaskRequest : TeaModel {
        [NameInMap("CallString")]
        [Validation(Required=false)]
        public string CallString { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JSON</para>
        /// </summary>
        [NameInMap("CallStringType")]
        [Validation(Required=false)]
        public string CallStringType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0571<b><b>5678,0571</b></b>5679</para>
        /// </summary>
        [NameInMap("Caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

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
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RetryCount")]
        [Validation(Required=false)]
        public int? RetryCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RetryFlag")]
        [Validation(Required=false)]
        public int? RetryFlag { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RetryInterval")]
        [Validation(Required=false)]
        public int? RetryInterval { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200010,200011</para>
        /// </summary>
        [NameInMap("RetryStatusCode")]
        [Validation(Required=false)]
        public string RetryStatusCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("RobotId")]
        [Validation(Required=false)]
        public string RobotId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("SeatCount")]
        [Validation(Required=false)]
        public string SeatCount { get; set; }

        [NameInMap("StartNow")]
        [Validation(Required=false)]
        public bool? StartNow { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("WorkDay")]
        [Validation(Required=false)]
        public string WorkDay { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10:00-12:00,13:00-14:00</para>
        /// </summary>
        [NameInMap("WorkTimeList")]
        [Validation(Required=false)]
        public string WorkTimeList { get; set; }

    }

}
