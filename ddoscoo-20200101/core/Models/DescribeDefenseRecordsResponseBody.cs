// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDefenseRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of details of the log of an advanced mitigation session.</para>
        /// </summary>
        [NameInMap("DefenseRecords")]
        [Validation(Required=false)]
        public List<DescribeDefenseRecordsResponseBodyDefenseRecords> DefenseRecords { get; set; }
        public class DescribeDefenseRecordsResponseBodyDefenseRecords : TeaModel {
            /// <summary>
            /// <para>The peak attack traffic. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6584186000</para>
            /// </summary>
            [NameInMap("AttackPeak")]
            [Validation(Required=false)]
            public long? AttackPeak { get; set; }

            /// <summary>
            /// <para>The end time of the advanced mitigation session. This value is a UNIX timestamp. Units: miliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1583683200000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The number of attacks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("EventCount")]
            [Validation(Required=false)]
            public int? EventCount { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddoscoo-cn-mp91j1ao****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The start time of the advanced mitigation session. This value is a UNIX timestamp. Units: miliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1582992000000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The status of the advanced mitigation session. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The advanced mitigation session is being used.</description></item>
            /// <item><description><b>1</b>: The advanced mitigation session is used.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bcf28g5-d57c-11e7-9bs0-d89d6717dxbc</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of advanced mitigation sessions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
