// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamMetricDetailDataRequest : TeaModel {
        /// <summary>
        /// <para>The application name. Specify this parameter to query stream-level data for a specific application.</para>
        /// <remarks>
        /// <para>If you specify StreamName, you must also specify AppName.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The accelerated domain name to query. Only a single domain name can be queried at a time. An error is returned if multiple domain names are specified.</description></item>
        /// <item><description>If AppName and StreamName are not specified, stream-level data for all streams under the domain name is returned.</description></item>
        /// <item><description>If the domain name is left empty, aggregate data for all accelerated domain names under the account is returned.</description></item>
        /// <item><description>If DomainName is specified and both AppName and StreamName are set to all, aggregate data for the specified accelerated domain name is returned.</description></item>
        /// <item><description>When you specify DomainName, make sure the domain name is a live streaming domain and the user calling this operation has the required permissions on the domain name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time, and the difference cannot exceed 1 day. Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The paged query token. A maximum of 5,000 rows of data can be returned per query. If the data to query exceeds 5,000 rows, the response includes the starting index for the next paging request. Pass this token in the request to continue querying data from where the previous query ended.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UjsM9x3aVcJi9a0-ArwJUTTC67CIBKLw*****</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The stream protocol. Valid values: <b>flv</b>, <b>hls</b>, <b>rtmp</b>, <b>rts</b>, and <b>p2p</b>.</para>
        /// <para>You can query data for multiple protocols by separating them with commas (,). Data for multiple protocols is not aggregated and is output at the stream level.</para>
        /// <remarks>
        /// <para>The <b>rts</b> option queries Real-Time Streaming (RTS) streams that use the ARTC protocol.</para>
        /// <list type="bullet">
        /// <item><description>When using rts, you may need to additionally collect statistics for the xxx_AliRTS-opus transcoding stream. This is because when playing an RTS stream on the web, a transcoding stream with the _AliRTS-opus suffix appended to the stream name is automatically generated. For more information, see <a href="https://help.aliyun.com/document_detail/2948703.html">RTS sub-second latency automatic transcoding</a>.</description></item>
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
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The stream name. Specify this parameter together with AppName to return stream-level data.</para>
        /// <remarks>
        /// <para>If you specify StreamName, you must also specify AppName.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>liveStream****</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

    }

}
