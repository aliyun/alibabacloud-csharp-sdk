// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveCenterTransferRequest : TeaModel {
        /// <summary>
        /// <para>The name of the live stream application. The AppName you enter must be the same as the AppName of the live stream to be relayed for the configuration to take effect. You can view the AppName on the <a href="https://help.aliyun.com/document_detail/197397.html">Stream Management</a> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testapp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The third-party live streaming address for relay. You can add up to one address.</para>
        /// <remarks>
        /// <para>The protocol of the destination address must be the same as the protocol of the live stream to be relayed. Only RTMP and SRT relay addresses are supported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://push.example2.aliyunlive.com/testapp1/teststream2</para>
        /// </summary>
        [NameInMap("DstUrl")]
        [Validation(Required=false)]
        public string DstUrl { get; set; }

        /// <summary>
        /// <para>The end time of the relay. The date format follows the ISO 8601 notation and uses UTC+0 time. The format is yyyy-MM-ddTHH:mm:ssZ.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-22T08:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start time of the relay. The date format follows the ISO 8601 notation and uses UTC+0 time. The format is yyyy-MM-ddTHH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-21T10:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The name of the live stream. You can view the StreamName on the <a href="https://help.aliyun.com/document_detail/197397.html">Stream Management</a> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>teststream</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

        /// <summary>
        /// <para>The validity period of the relay. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>always</b>: permanently effective.</para>
        /// </description></item>
        /// <item><description><para><b>time</b>: effective within the specified time period.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If the value is <b>time</b>, <b>StartTime</b> and <b>EndTime</b> are required.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>always</para>
        /// </summary>
        [NameInMap("TransferArgs")]
        [Validation(Required=false)]
        public string TransferArgs { get; set; }

    }

}
