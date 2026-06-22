// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeTraceInfoNodeRequest : TeaModel {
        /// <summary>
        /// <para>The event name.</para>
        /// <remarks>
        /// <para>For more information, call the <a href="~~DescribeSuspEvents~~">DescribeSuspEvents</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>WEBSHELL</para>
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <para>The source identifier of the request. Set the value to sas.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The time when the event was first detected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1635978934000</para>
        /// </summary>
        [NameInMap("IncidentTime")]
        [Validation(Required=false)]
        public long? IncidentTime { get; set; }

        /// <summary>
        /// <para>The language type of the request and response. Default value: <b>zh</b>. Valid values:</para>
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
        /// <para>127.0.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The vertex type. You can call the <a href="~~DescribeTraceInfoDetail~~">DescribeTraceInfoDetail</a> operation to obtain this parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SAS_ASSET</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The UUID of the server to query. You can call the <a href="~~DescribeSuspEvents~~">DescribeSuspEvents</a> operation to obtain this parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6f346617-eef9-45e6-b6d1-946xxxxxxxx</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <para>The vertex ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>03da4e2350a3eb50cd25a18cexxxxxxx</para>
        /// </summary>
        [NameInMap("VertexId")]
        [Validation(Required=false)]
        public string VertexId { get; set; }

    }

}
