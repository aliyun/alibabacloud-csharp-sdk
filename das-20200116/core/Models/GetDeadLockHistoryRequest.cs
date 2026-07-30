// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetDeadLockHistoryRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the query. This value is a UNIX timestamp. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is a Long value. To prevent precision loss during serialization and deserialization, make sure that the value does not exceed 9007199254740991.</para>
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
        /// <para>Specify the node ID for a PolarDB for MySQL instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pi-bp16v3824rt73****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The maximum value is <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The source of the task:</para>
        /// <list type="bullet">
        /// <item><description><para><b>MANUAL</b> or unspecified: queries tasks for recent deadlock analysis.</para>
        /// </description></item>
        /// <item><description><para><b>AUTO</b>: queries tasks for full deadlock analysis.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>If you set this parameter to AUTO to query tasks for full deadlock analysis, the start time can be a maximum of seven days earlier than the end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AUTO</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The start time of the query. This value is a UNIX timestamp. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is a Long value. To prevent precision loss during serialization and deserialization, make sure that the value does not exceed 9007199254740991.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1731983066000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
