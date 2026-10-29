// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeDeviceResponseBody : TeaModel {
        /// <summary>
        /// <para>The subscribed national standard alarm methods. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: All.</description></item>
        /// <item><description>5: Video alarm.</description></item>
        /// <item><description>7: Other alarms.<remarks>
        /// <list type="bullet">
        /// <item><description>An empty value indicates no subscription.</description></item>
        /// <item><description>Multiple values are supported and must be separated by commas (,).</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("AlarmMethod")]
        [Validation(Required=false)]
        public string AlarmMethod { get; set; }

        [NameInMap("AutoDirectory")]
        [Validation(Required=false)]
        public bool? AutoDirectory { get; set; }

        /// <summary>
        /// <para>Specifies whether device position subscription is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPos")]
        [Validation(Required=false)]
        public bool? AutoPos { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically start the stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoStart")]
        [Validation(Required=false)]
        public bool? AutoStart { get; set; }

        /// <summary>
        /// <para>The channel synchronization time. The time is in UTC and follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-02-28T17:01:17Z</para>
        /// </summary>
        [NameInMap("ChannelSyncTime")]
        [Validation(Required=false)]
        public string ChannelSyncTime { get; set; }

        /// <summary>
        /// <para>The time when the device was created. The time is in UTC and follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-02-28T17:00:17Z</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The device description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Camera at the XXX intersection</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The directory information.</para>
        /// </summary>
        [NameInMap("Directory")]
        [Validation(Required=false)]
        public DescribeDeviceResponseBodyDirectory Directory { get; set; }
        public class DescribeDeviceResponseBodyDirectory : TeaModel {
            /// <summary>
            /// <para>The time when the directory was created. The time is in UTC and follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-02-28T17:00:17Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The directory description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Directory 1</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the workspace to which the directory belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3238848****092994-cn-qingdao</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The directory ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3238848****092994-cn-qingdao</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The directory name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Directory 1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the parent directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3238848****092995-cn-qingdao</para>
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

        }

        /// <summary>
        /// <para>The directory ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3238848****092994-cn-qingdao</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The device serial number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7D0*****4C0</para>
        /// </summary>
        [NameInMap("Dsn")]
        [Validation(Required=false)]
        public string Dsn { get; set; }

        /// <summary>
        /// <para>Specifies whether the device is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The national standard ID of the device.</para>
        /// <remarks>
        /// <para>This parameter is applicable only to the national standard protocol.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>31000000****00000002</para>
        /// </summary>
        [NameInMap("GbId")]
        [Validation(Required=false)]
        public string GbId { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the device belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3238848****092994-cn-qingdao</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The device ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3238848****092996-cn-qingdao</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The IP address of the device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.10.10.10</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The latitude of the device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>119.20</para>
        /// </summary>
        [NameInMap("Latitude")]
        [Validation(Required=false)]
        public string Latitude { get; set; }

        /// <summary>
        /// <para>The longitude of the device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>45.00</para>
        /// </summary>
        [NameInMap("Longitude")]
        [Validation(Required=false)]
        public string Longitude { get; set; }

        /// <summary>
        /// <para>The device name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Camera at the XXX intersection</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Other parameters of the device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>The ID of the parent device, such as the ID of the platform to which the camera belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3238848****092995-cn-qingdao</para>
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// <para>The device password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The device port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public long? Port { get; set; }

        /// <summary>
        /// <para>The position subscription interval, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("PosInterval")]
        [Validation(Required=false)]
        public long? PosInterval { get; set; }

        /// <summary>
        /// <para>The device registration protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gb28181</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The time when the device was registered. The time is in UTC and follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-02-28T17:00:17Z</para>
        /// </summary>
        [NameInMap("RegisteredTime")]
        [Validation(Required=false)]
        public string RegisteredTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The stream statistics information of the device.</para>
        /// </summary>
        [NameInMap("Stats")]
        [Validation(Required=false)]
        public DescribeDeviceResponseBodyStats Stats { get; set; }
        public class DescribeDeviceResponseBodyStats : TeaModel {
            /// <summary>
            /// <para>The number of channels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ChannelNum")]
            [Validation(Required=false)]
            public long? ChannelNum { get; set; }

            /// <summary>
            /// <para>The number of failed streams.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FailedNum")]
            [Validation(Required=false)]
            public long? FailedNum { get; set; }

            /// <summary>
            /// <para>The number of offline streams.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OfflineNum")]
            [Validation(Required=false)]
            public long? OfflineNum { get; set; }

            /// <summary>
            /// <para>The number of online streams.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OnlineNum")]
            [Validation(Required=false)]
            public long? OnlineNum { get; set; }

            /// <summary>
            /// <para>The number of streams.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StreamNum")]
            [Validation(Required=false)]
            public long? StreamNum { get; set; }

        }

        /// <summary>
        /// <para>The device status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Online.</description></item>
        /// <item><description>off: Offline.</description></item>
        /// <item><description>failed: Locked.</description></item>
        /// <item><description>new: Unregistered.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The device type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ipc: IP camera.</description></item>
        /// <item><description>platform: Platform.</description></item>
        /// <item><description>ied: Intelligent device.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ipc</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The stream URL on the device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://xxx/xxx</para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        /// <summary>
        /// <para>The device username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The device vendor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Company A</para>
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

    }

}
