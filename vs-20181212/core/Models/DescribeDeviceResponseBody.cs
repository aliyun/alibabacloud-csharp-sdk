// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeDeviceResponseBody : TeaModel {
        /// <summary>
        /// <para>Subscribed GB alarm method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0 (all)</para>
        /// </description></item>
        /// <item><description><para>5 (video alarm)</para>
        /// </description></item>
        /// <item><description><para>7 (other alarms)</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>An empty value means no subscription.</para>
        /// </description></item>
        /// <item><description><para>Multiple values are supported, separated by commas (,).</para>
        /// </description></item>
        /// </list>
        /// </remarks>
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
        /// <para>Indicates whether device location subscription is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPos")]
        [Validation(Required=false)]
        public bool? AutoPos { get; set; }

        /// <summary>
        /// <para>Automatically start the stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoStart")]
        [Validation(Required=false)]
        public bool? AutoStart { get; set; }

        /// <summary>
        /// <para>Channel synchronization time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-02-28T17:01:17Z</para>
        /// </summary>
        [NameInMap("ChannelSyncTime")]
        [Validation(Required=false)]
        public string ChannelSyncTime { get; set; }

        /// <summary>
        /// <para>Device creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-02-28T17:00:17Z</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>Device description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx路口摄像头</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Directory information.</para>
        /// </summary>
        [NameInMap("Directory")]
        [Validation(Required=false)]
        public DescribeDeviceResponseBodyDirectory Directory { get; set; }
        public class DescribeDeviceResponseBodyDirectory : TeaModel {
            /// <summary>
            /// <para>Directory creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-02-28T17:00:17Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>Directory description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>目录1</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Space ID to which the directory belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3238848****092994-cn-qingdao</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>Directory ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3238848****092994-cn-qingdao</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Directory name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>目录1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Parent directory ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3238848****092995-cn-qingdao</para>
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

        }

        /// <summary>
        /// <para>Directory ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3238848****092994-cn-qingdao</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>Device serial number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7D0*****4C0</para>
        /// </summary>
        [NameInMap("Dsn")]
        [Validation(Required=false)]
        public string Dsn { get; set; }

        /// <summary>
        /// <para>Whether the device is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>GB device ID.</para>
        /// <remarks>
        /// <para>This applies only to GB protocols.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>31000000****00000002</para>
        /// </summary>
        [NameInMap("GbId")]
        [Validation(Required=false)]
        public string GbId { get; set; }

        /// <summary>
        /// <para>Space ID to which the device belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3238848****092994-cn-qingdao</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>Device ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3238848****092996-cn-qingdao</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Device IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.10.10.10</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>Device latitude.</para>
        /// 
        /// <b>Example:</b>
        /// <para>119.20</para>
        /// </summary>
        [NameInMap("Latitude")]
        [Validation(Required=false)]
        public string Latitude { get; set; }

        /// <summary>
        /// <para>Device longitude.</para>
        /// 
        /// <b>Example:</b>
        /// <para>45.00</para>
        /// </summary>
        [NameInMap("Longitude")]
        [Validation(Required=false)]
        public string Longitude { get; set; }

        /// <summary>
        /// <para>Device name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx路口摄像头</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Other device parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>Parent device ID. For example, the platform ID to which a camera belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3238848****092995-cn-qingdao</para>
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// <para>Device password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>Device port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public long? Port { get; set; }

        /// <summary>
        /// <para>Position subscription interval, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("PosInterval")]
        [Validation(Required=false)]
        public long? PosInterval { get; set; }

        /// <summary>
        /// <para>Device registration protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gb28181</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>Device registration time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-02-28T17:00:17Z</para>
        /// </summary>
        [NameInMap("RegisteredTime")]
        [Validation(Required=false)]
        public string RegisteredTime { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Device stream statistics.</para>
        /// </summary>
        [NameInMap("Stats")]
        [Validation(Required=false)]
        public DescribeDeviceResponseBodyStats Stats { get; set; }
        public class DescribeDeviceResponseBodyStats : TeaModel {
            /// <summary>
            /// <para>Number of channels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ChannelNum")]
            [Validation(Required=false)]
            public long? ChannelNum { get; set; }

            /// <summary>
            /// <para>Number of failed streams.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FailedNum")]
            [Validation(Required=false)]
            public long? FailedNum { get; set; }

            /// <summary>
            /// <para>Number of offline streams.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OfflineNum")]
            [Validation(Required=false)]
            public long? OfflineNum { get; set; }

            /// <summary>
            /// <para>Number of online streams.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OnlineNum")]
            [Validation(Required=false)]
            public long? OnlineNum { get; set; }

            /// <summary>
            /// <para>Number of streams.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StreamNum")]
            [Validation(Required=false)]
            public long? StreamNum { get; set; }

        }

        /// <summary>
        /// <para>Device status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>on (online)</para>
        /// </description></item>
        /// <item><description><para>off (offline)</para>
        /// </description></item>
        /// <item><description><para>failed (locked)</para>
        /// </description></item>
        /// <item><description><para>new (unregistered)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Device type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ipc (camera)</para>
        /// </description></item>
        /// <item><description><para>platform (platform)</para>
        /// </description></item>
        /// <item><description><para>ied (intelligent device)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ipc</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>Stream URL on the device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://xxx/xxx</para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        /// <summary>
        /// <para>Device username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>Device vendor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>公司A</para>
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

    }

}
