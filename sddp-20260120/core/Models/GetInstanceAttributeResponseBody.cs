// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class GetInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The current kernel version of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds_20220731</para>
        /// </summary>
        [NameInMap("CurrentKernelVersion")]
        [Validation(Required=false)]
        public string CurrentKernelVersion { get; set; }

        /// <summary>
        /// <para>The database engine type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The major version of the database engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The business error code for the record or operation. This value can be empty if no error occurs. Evaluate this value together with ErrorMessage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>data_masking_not_running</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The business error message for the record or operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The instance is not in the running state</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance supports column encryption by using KMS keys.</para>
        /// </summary>
        [NameInMap("KmsEncryptionSupported")]
        [Validation(Required=false)]
        public bool? KmsEncryptionSupported { get; set; }

        /// <summary>
        /// <para>The end time of the O&amp;M window. The value is a UNIX timestamp in milliseconds since 1970-01-01 00:00:00 UTC. The UTC time of the O&amp;M window is combined with the date of the query day and returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1788570000000</para>
        /// </summary>
        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public long? MaintainEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the O&amp;M window. The value is a UNIX timestamp in milliseconds since 1970-01-01 00:00:00 UTC. The UTC time of the O&amp;M window is combined with the date of the query day and returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1788566400000</para>
        /// </summary>
        [NameInMap("MaintainStartTime")]
        [Validation(Required=false)]
        public long? MaintainStartTime { get; set; }

        /// <summary>
        /// <para>The request ID. You can use this ID to locate the API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C6D8E9F-1234-5678-ABCD-0123456789AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The current running status of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
