// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetDeadlockHistogramRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the UNIX timestamp format. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This field is of the Long type. During serialization/deserialization, precision loss may occur. Make sure that the value does not exceed 9007199254740991.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1732069466000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the database instance.</para>
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
        /// <para>Required for PolarDB for MySQL cluster instances</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pi-bp16v3824rt73****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the UNIX timestamp format. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>The maximum query window is 7 days.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This field is of the Long type. During serialization/deserialization, precision loss may occur. Make sure that the value does not exceed 9007199254740991.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1731983066000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The status of the analysis task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
