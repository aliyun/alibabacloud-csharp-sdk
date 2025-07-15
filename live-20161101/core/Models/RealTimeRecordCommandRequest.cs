// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class RealTimeRecordCommandRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs. You can view the application name on the <a href="https://help.aliyun.com/document_detail/197397.html">Stream Management</a> page of the ApsaraVideo Live console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The action to be performed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>start</b>: forcibly starts recording.</description></item>
        /// <item><description><b>stop</b>: forcibly stops recording. If the live stream is interrupted for longer than a specific latency, a recording is generated.</description></item>
        /// <item><description><b>cancel_delay</b>: resets the latency for stream interruption and completely stops recording. If the recording task is stopped when you perform this action, a recording is generated.</description></item>
        /// <item><description><b>restart</b>: forcibly restarts recording. If the live stream is being recorded when you perform this action, a recording is generated.</description></item>
        /// </list>
        /// <remarks>
        /// <para> <b>stop</b> forcibly stops recording. By default, a recording is generated after 180 seconds. <b>cancel_delay</b> resets the latency for stream interruption from 180 seconds to 0 seconds. This means that a recording is generated immediately.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>start</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// <para>The main streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the live stream. Make sure that you specify the correct stream name. You can view the stream name on the <a href="https://help.aliyun.com/document_detail/197397.html">Stream Management</a> page of the ApsaraVideo Live console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveStream****</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

    }

}
