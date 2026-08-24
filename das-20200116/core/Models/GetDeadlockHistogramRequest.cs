// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetDeadlockHistogramRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. The format is a UNIX timestamp in milliseconds.</para>
        /// <remarks>
        /// <para>Notice: The value is of the Long type. Precision loss may occur during the serialization/deserialization procedure. The value must not be greater than 9007199254740991.</notice></para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1732069466000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp1u5mas9exx7****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// <remarks>
        /// <para>For PolarDB for MySQL instances, you must specify the node ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pi-bp16v3824rt73****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The format is a UNIX timestamp in milliseconds.</para>
        /// <remarks>
        /// <para>The start time can be at most 7 days earlier than the end time.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Notice: The value is of the Long type. Precision loss may occur during the serialization/deserialization procedure. The value must not be greater than 9007199254740991.</notice></para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1731983066000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The analysis status of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
