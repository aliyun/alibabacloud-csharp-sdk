// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDosEventAreaRequest : TeaModel {
        /// <summary>
        /// <para>The event type of the attack event to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>defense</b>: traffic scrubbing events for volumetric attacks.</description></item>
        /// <item><description><b>blackhole</b>: blackhole filtering events for volumetric attacks.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>defense</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The attacked IP Address of Anti-DDoS Proxy instance of Anti-DDoS Pro and Anti-DDoS Premium.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>203.XX.XX.199</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The number of data entries to return. Unit: entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Range")]
        [Validation(Required=false)]
        public long? Range { get; set; }

        /// <summary>
        /// <para>The start timestamp of the event to query. Unit: seconds.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/188604.html">DescribeDDosAllEventList</a> to query the start time of all events.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1598948471</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
