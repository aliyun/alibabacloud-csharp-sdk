// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDestinationPortEventRequest : TeaModel {
        /// <summary>
        /// <para>The type of the attack event that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>defense</b>: attack events that trigger traffic scrubbing.</description></item>
        /// <item><description><b>blackhole</b>: attack events that trigger blackhole filtering.</description></item>
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
        /// <para>The IP address of the attacker.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>203.107.XX.XX</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The number of destination ports to return. The ports are sorted in descending order of the number of received request packets. By default, the first <b>10</b> ports are returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Range")]
        [Validation(Required=false)]
        public long? Range { get; set; }

        /// <summary>
        /// <para>The region in which your service is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn</b>: a region in the Chinese mainland.</description></item>
        /// <item><description><b>cn-hongkong</b>: a region outside the Chinese mainland.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is a UNIX timestamp. Unit: seconds.</para>
        /// <remarks>
        /// <para> This UNIX timestamp must indicate a point in time that is accurate to the minute.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1720059000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
