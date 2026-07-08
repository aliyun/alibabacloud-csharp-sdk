// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeStreamURLRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to generate a signed URL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Auth")]
        [Validation(Required=false)]
        public bool? Auth { get; set; }

        /// <summary>
        /// <para>The primary key associated with the playback domain name. This key is used to generate the authentication URL.</para>
        /// <remarks>
        /// <para>Call the <a href="https://next.api.aliyun.com/document/vs/2018-12-12/DescribeVsDomainConfigs">DescribeVsDomainConfigs</a> operation to query the \<c>AuthKey\\</c> information.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ocs*****ace</para>
        /// </summary>
        [NameInMap("AuthKey")]
        [Validation(Required=false)]
        public string AuthKey { get; set; }

        /// <summary>
        /// <para>The end time. This parameter applies to \<c>vod\\</c> streams.<br>
        /// A UNIX timestamp. Unit: seconds.<br></para>
        /// 
        /// <b>Example:</b>
        /// <para>1571649499</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The time-to-live (TTL) of the URL. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Expire")]
        [Validation(Required=false)]
        public long? Expire { get; set; }

        /// <summary>
        /// <para>The stream ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>323*****997-cn-qingdao</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The playback protocol for the stream. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>rtmp</para>
        /// </description></item>
        /// <item><description><para>flv</para>
        /// </description></item>
        /// <item><description><para>hls</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp</para>
        /// </summary>
        [NameInMap("OutProtocol")]
        [Validation(Required=false)]
        public string OutProtocol { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The start time. This parameter applies to \<c>vod\\</c> streams.<br>
        /// A UNIX timestamp. Unit: seconds.<br></para>
        /// 
        /// <b>Example:</b>
        /// <para>1571639499</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The name of the transcoding rule. This parameter is valid only after a transcoding template is attached.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sd</para>
        /// </summary>
        [NameInMap("Transcode")]
        [Validation(Required=false)]
        public string Transcode { get; set; }

        /// <summary>
        /// <para>The type of the stream. The default value is \<c>live\\</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>\<c>live\\</c>: a live stream.</para>
        /// </description></item>
        /// <item><description><para>\<c>vod\\</c>: a video-on-demand (VOD) stream, such as a historical stream from a Network Video Recorder (NVR).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>live</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
