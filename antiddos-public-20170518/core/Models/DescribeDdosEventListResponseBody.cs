// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeDdosEventListResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the DDoS attack events.</para>
        /// </summary>
        [NameInMap("DdosEventList")]
        [Validation(Required=false)]
        public DescribeDdosEventListResponseBodyDdosEventList DdosEventList { get; set; }
        public class DescribeDdosEventListResponseBodyDdosEventList : TeaModel {
            [NameInMap("DdosEvent")]
            [Validation(Required=false)]
            public List<DescribeDdosEventListResponseBodyDdosEventListDdosEvent> DdosEvent { get; set; }
            public class DescribeDdosEventListResponseBodyDdosEventListDdosEvent : TeaModel {
                /// <summary>
                /// <para>The status of the DDoS attack event. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>mitigating</b>: indicates that traffic scrubbing is in progress.</description></item>
                /// <item><description><b>blackholed</b>: indicates that blackhole filtering is triggered for the asset.</description></item>
                /// <item><description><b>normal</b>: indicates that the DDoS attack event ends.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("DdosStatus")]
                [Validation(Required=false)]
                public string DdosStatus { get; set; }

                /// <summary>
                /// <para>The type of the DDoS attack event. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>defense</b>: an attack event that triggers traffic scrubbing</description></item>
                /// <item><description><b>blackhole</b>: an attack event that triggers blackhole filtering</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>blackhole</para>
                /// </summary>
                [NameInMap("DdosType")]
                [Validation(Required=false)]
                public string DdosType { get; set; }

                /// <summary>
                /// <para>The time of the last attack. The value is a UNIX timestamp. Unit: milliseconds.</para>
                /// <remarks>
                /// <para>This parameter is returned only when the asset is attacked multiple times within a DDoS attack event.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1637817679000</para>
                /// </summary>
                [NameInMap("DelayTime")]
                [Validation(Required=false)]
                public long? DelayTime { get; set; }

                /// <summary>
                /// <para>The end time of the DDoS attack event. The value is a UNIX timestamp. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1637817679000</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The start time of the DDoS attack event. The value is a UNIX timestamp. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1637812279000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The time when blackhole filtering is deactivated. The value is a UNIX timestamp. Unit: milliseconds.</para>
                /// <remarks>
                /// <para>This parameter is returned only when the value of the <b>DdosType</b> parameter is <b>blackhole</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1637814079000</para>
                /// </summary>
                [NameInMap("UnBlackholeTime")]
                [Validation(Required=false)]
                public long? UnBlackholeTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC0907F8-A9F3-5E11-977B-D59CD98C64ED</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of DDoS attack events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
