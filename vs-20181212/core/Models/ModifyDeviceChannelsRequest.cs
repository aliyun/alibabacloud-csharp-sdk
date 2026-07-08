// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ModifyDeviceChannelsRequest : TeaModel {
        /// <summary>
        /// <para>An array of channels in a JSON-formatted string.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ChannelId&quot;:12333,&quot;Name&quot;:&quot;测试&quot;,&quot;DeviceStatus&quot;:&quot;on&quot;}]</para>
        /// </summary>
        [NameInMap("Channels")]
        [Validation(Required=false)]
        public string Channels { get; set; }

        /// <summary>
        /// <para>The status of the device. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>on: online</para>
        /// </description></item>
        /// <item><description><para>off: offline</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("DeviceStatus")]
        [Validation(Required=false)]
        public string DeviceStatus { get; set; }

        /// <summary>
        /// <para>The device serial number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210235C3GN32090008286cf17e130d</para>
        /// </summary>
        [NameInMap("Dsn")]
        [Validation(Required=false)]
        public string Dsn { get; set; }

        /// <summary>
        /// <para>The device ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>348*****380-cn-qingdao</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

    }

}
