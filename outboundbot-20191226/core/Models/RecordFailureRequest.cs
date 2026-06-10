// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class RecordFailureRequest : TeaModel {
        /// <summary>
        /// <para>Call start time</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1579055782000</para>
        /// </summary>
        [NameInMap("ActualTime")]
        [Validation(Required=false)]
        public long? ActualTime { get; set; }

        /// <summary>
        /// <para>Call ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f21446e-324e-46f2-bf62-7f341fb004ea</para>
        /// </summary>
        [NameInMap("CallId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        /// <summary>
        /// <para>Called number</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>135815****</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <para>Calling number</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10086</para>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public string CallingNumber { get; set; }

        /// <summary>
        /// <para>Failure reason.</para>
        /// <list type="bullet">
        /// <item><description><para>Nonexistent number (NotExists)</para>
        /// </description></item>
        /// <item><description><para>Busy (Busy)</para>
        /// </description></item>
        /// <item><description><para>No answer (NotAnswered)</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NotExists</para>
        /// </summary>
        [NameInMap("DispositionCode")]
        [Validation(Required=false)]
        public string DispositionCode { get; set; }

        /// <summary>
        /// <para>Error code when the outbound call fails.</para>
        /// <list type="bullet">
        /// <item><description><para>Nonexistent number (NotExists)</para>
        /// </description></item>
        /// <item><description><para>Busy (Busy)</para>
        /// </description></item>
        /// <item><description><para>No answer (NotAnswered)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NotExists</para>
        /// </summary>
        [NameInMap("ExceptionCodes")]
        [Validation(Required=false)]
        public string ExceptionCodes { get; set; }

        /// <summary>
        /// <para>Instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ab43460-c0b9-40e2-8447-48d82c97fc67</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Task ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d2295c0e-3bc3-48a5-9f56-b185db2be909</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
