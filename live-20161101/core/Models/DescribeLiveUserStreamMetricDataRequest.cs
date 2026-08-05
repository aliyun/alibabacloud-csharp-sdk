// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveUserStreamMetricDataRequest : TeaModel {
        /// <summary>
        /// <para>The application name. Specify the application name to query stream-level data for the corresponding application. If <c>StreamName</c> is specified, <c>AppName</c> must also be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The streaming domain to query.</para>
        /// <remarks>
        /// <para>Only a single domain name is supported. An error is returned if multiple domain names are specified. If the domain name is empty, aggregate data for all streaming domains under the user is queried. If <c>AppName</c> and <c>StreamName</c> are not specified, stream-level data for all streams under the domain is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time and the difference cannot exceed 1 day. Specify the time in the ISO 8601 standard in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 5000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The stream protocol name. Specify the protocol name to query data for the corresponding protocol. Supported protocols: <c>flv</c>, <c>hls</c>, <c>rtmp</c>, <c>rts</c>, <c>p2p</c>. You can query data for multiple protocols by separating them with commas (,). Data for multiple protocols is not aggregated and is output at the stream level.</para>
        /// <remarks>
        /// <para>The <b>rts</b> option queries Real-Time Streaming (RTS) streams using the ARTC protocol.</para>
        /// <list type="bullet">
        /// <item><description>When using rts, you may need to additionally count the xxx_AliRTS-opus transcoding stream. This is because when playing an RTS stream on the web, a transcoding stream with the _AliRTS-opus suffix appended to the stream name is automatically generated, producing transcoding stream data. For more information, see <a href="https://help.aliyun.com/document_detail/2948703.html">RTS sub-second latency automatic transcoding</a>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>flv</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The stream name. If <c>StreamName</c> is specified, stream-level data for the specified <c>StreamName</c> under the specified <c>AppName</c> is returned. If <c>StreamName</c> is specified, <c>AppName</c> must also be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.flv</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

    }

}
