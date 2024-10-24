// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDosEventAreaRequest : TeaModel {
        /// <summary>
        /// <para>The type of the attack event that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>defense</b>: attack events that trigger traffic scrubbing</description></item>
        /// <item><description><b>blackhole</b>: attack events that trigger blackhole filtering</description></item>
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
        /// <para>The IP address of the attacked Anti-DDoS Pro or Anti-DDoS Premium instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>203.<em><b>.</b></em>.199</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        [NameInMap("Range")]
        [Validation(Required=false)]
        public long? Range { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp when the query starts. Unit: seconds.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/188604.html">DescribeDDosAllEventList</a> operation to query the beginning time of all attack events.</para>
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
