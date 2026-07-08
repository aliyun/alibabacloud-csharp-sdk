// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeDevicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of devices.</para>
        /// </summary>
        [NameInMap("Devices")]
        [Validation(Required=false)]
        public List<DescribeDevicesResponseBodyDevices> Devices { get; set; }
        public class DescribeDevicesResponseBodyDevices : TeaModel {
            /// <summary>
            /// <para>The GB/T 28181 alarm subscription method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0 (all)</para>
            /// </description></item>
            /// <item><description><para>5 (video alarm)</para>
            /// </description></item>
            /// <item><description><para>7 (other alarm)</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>An empty value indicates that no alarm is subscribed.</para>
            /// </description></item>
            /// <item><description><para>Specify multiple values. Separate them with commas (,).</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AlarmMethod")]
            [Validation(Required=false)]
            public string AlarmMethod { get; set; }

            /// <summary>
            /// <para>Indicates whether directory reporting is enabled for the platform device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoDirectory")]
            [Validation(Required=false)]
            public bool? AutoDirectory { get; set; }

            /// <summary>
            /// <para>Indicates whether to enable position subscription for the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoPos")]
            [Validation(Required=false)]
            public bool? AutoPos { get; set; }

            /// <summary>
            /// <para>Indicates whether to automatically start the stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoStart")]
            [Validation(Required=false)]
            public bool? AutoStart { get; set; }

            /// <summary>
            /// <para>The time when the channels were synchronized.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-02-28T17:01:17Z</para>
            /// </summary>
            [NameInMap("ChannelSyncTime")]
            [Validation(Required=false)]
            public string ChannelSyncTime { get; set; }

            /// <summary>
            /// <para>The time when the device was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-02-28T17:00:17Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The description of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx路口摄像头</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The directory information.</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public DescribeDevicesResponseBodyDevicesDirectory Directory { get; set; }
            public class DescribeDevicesResponseBodyDevicesDirectory : TeaModel {
                /// <summary>
                /// <para>The time when the directory was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-02-28T17:00:17Z</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// <para>The description of the directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>目录1</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the group to which the directory belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>348*****174-cn-qingdao</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The directory ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>399*****488-cn-qingdao</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>目录1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the parent directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>399*****774-cn-qingdao</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

            }

            /// <summary>
            /// <para>The directory ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>399*****488-cn-qingdao</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <para>The serial number of the device.</para>
            /// <remarks>
            /// <para>This parameter applies only to the AUVSP and ODCAP protocols.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>7D0*****4C0</para>
            /// </summary>
            [NameInMap("Dsn")]
            [Validation(Required=false)]
            public string Dsn { get; set; }

            /// <summary>
            /// <para>Indicates whether the device is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The GB/T 28181 ID of the device.</para>
            /// <remarks>
            /// <para>This parameter applies only to the GB/T 28181 protocol.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>310000000****0000002</para>
            /// </summary>
            [NameInMap("GbId")]
            [Validation(Required=false)]
            public string GbId { get; set; }

            /// <summary>
            /// <para>The ID of the group to which the device belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>348*****174-cn-qingdao</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The device ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>348*****380-cn-qingdao</para>
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
            /// <para>xxx路口摄像头</para>
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
            /// <para>The ID of the parent device, such as the ID of the platform to which a camera belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3238848****092995</para>
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
            /// <para>The device protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gb28181</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The time when the device was registered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-02-28T17:00:17Z</para>
            /// </summary>
            [NameInMap("RegisteredTime")]
            [Validation(Required=false)]
            public string RegisteredTime { get; set; }

            /// <summary>
            /// <para>The stream statistics of the device.</para>
            /// </summary>
            [NameInMap("Stats")]
            [Validation(Required=false)]
            public DescribeDevicesResponseBodyDevicesStats Stats { get; set; }
            public class DescribeDevicesResponseBodyDevicesStats : TeaModel {
                /// <summary>
                /// <para>The number of channels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ChannelNum")]
                [Validation(Required=false)]
                public long? ChannelNum { get; set; }

                /// <summary>
                /// <para>The number of failed streams.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FailedNum")]
                [Validation(Required=false)]
                public long? FailedNum { get; set; }

                /// <summary>
                /// <para>The number of offline streams.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("OfflineNum")]
                [Validation(Required=false)]
                public long? OfflineNum { get; set; }

                /// <summary>
                /// <para>The number of online streams.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("OnlineNum")]
                [Validation(Required=false)]
                public long? OnlineNum { get; set; }

                /// <summary>
                /// <para>The number of streams.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StreamNum")]
                [Validation(Required=false)]
                public long? StreamNum { get; set; }

            }

            /// <summary>
            /// <para>The device status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>on (online)</para>
            /// </description></item>
            /// <item><description><para>off (offline)</para>
            /// </description></item>
            /// <item><description><para>failed</para>
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
            /// <para>The device type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ipc (camera)</para>
            /// </description></item>
            /// <item><description><para>platform</para>
            /// </description></item>
            /// <item><description><para>ied (intelligent edge device)</para>
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
            /// <para>The stream URL on the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtmp://xxx/xxx</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <para>The username for the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

            /// <summary>
            /// <para>The manufacturer of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>公司A</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

        }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public long? PageCount { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

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
        /// <para>The total number of devices.</para>
        /// 
        /// <b>Example:</b>
        /// <para>77</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
