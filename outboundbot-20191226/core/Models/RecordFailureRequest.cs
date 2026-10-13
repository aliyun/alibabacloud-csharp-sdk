// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class RecordFailureRequest : TeaModel {
        /// <summary>
        /// <para>The start time of the call. The value is a UNIX timestamp in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1579055782000</para>
        /// </summary>
        [NameInMap("ActualTime")]
        [Validation(Required=false)]
        public long? ActualTime { get; set; }

        /// <summary>
        /// <para>The call ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f21446e-324e-46f2-bf62-7f341fb004ea</para>
        /// </summary>
        [NameInMap("CallId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        /// <summary>
        /// <para>The called number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>135815****</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <para>The calling number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10086</para>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public string CallingNumber { get; set; }

        /// <summary>
        /// <para>The cause of the failure. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NotExists: nonexistent number.</description></item>
        /// <item><description>Busy: busy.</description></item>
        /// <item><description>NotAnswered: not answered.</description></item>
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
        /// <para>The error codes that occur when the outbound call fails. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NotExists: nonexistent number.</description></item>
        /// <item><description>Busy: busy.</description></item>
        /// <item><description>NotAnswered: not answered.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NotExists</para>
        /// </summary>
        [NameInMap("ExceptionCodes")]
        [Validation(Required=false)]
        public string ExceptionCodes { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ab43460-c0b9-40e2-8447-48d82c97fc67</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
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
