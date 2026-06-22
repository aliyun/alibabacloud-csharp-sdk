// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeTraceInfoDetailRequest : TeaModel {
        /// <summary>
        /// <para>The identifier of the request source. Set the value to <b>sas</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The detection timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1670555392000</para>
        /// </summary>
        [NameInMap("IncidentTime")]
        [Validation(Required=false)]
        public long? IncidentTime { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The source IP address of the request. You do not need to specify this parameter. The system automatically obtains the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The vertex type. Set the value to <b>SAS_INCIDENT</b> for security alerts.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SAS_INCIDENT</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The UUID of the server to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1627f2d7-aaa2-4ed1-b07a-xxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <para>The vertex ID. You can obtain this value from the AlarmUniqueInfo parameter returned by the <a href="~~DescribeSuspEvents~~">DescribeSuspEvents</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cce1d28dxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("VertexId")]
        [Validation(Required=false)]
        public string VertexId { get; set; }

    }

}
