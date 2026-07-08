// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class CreateDeviceRequest : TeaModel {
        /// <summary>
        /// <para>GB-compliant alarm method to subscribe to. Valid values:</para>
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
        /// <item><description><para>You can specify multiple values, separated by commas (,).</para>
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

        [NameInMap("AutoDirectory")]
        [Validation(Required=false)]
        public bool? AutoDirectory { get; set; }

        /// <summary>
        /// <para>Whether to enable location subscription for the device. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPos")]
        [Validation(Required=false)]
        public bool? AutoPos { get; set; }

        /// <summary>
        /// <para>Whether to automatically start the stream. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoStart")]
        [Validation(Required=false)]
        public bool? AutoStart { get; set; }

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
        /// <para>ID of the folder that contains the device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>399*****488-cn-qingdao</para>
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
        /// <para>GB-compliant device ID.</para>
        /// <remarks>
        /// <para>This parameter applies only to GB-compliant protocols.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>31000000****00000002</para>
        /// </summary>
        [NameInMap("GbId")]
        [Validation(Required=false)]
        public string GbId { get; set; }

        /// <summary>
        /// <para>ID of the space that contains the device.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>348*****174-cn-qingdao</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

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
        /// <para>The dimension of the device.</para>
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

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Additional device parameters, formatted as a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>ID of the parent device. For example, the ID of the platform that hosts the camera.</para>
        /// 
        /// <b>Example:</b>
        /// <para>399*****774-cn-qingdao</para>
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
        /// <para>Location subscription interval, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("PosInterval")]
        [Validation(Required=false)]
        public long? PosInterval { get; set; }

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
        /// <para>This parameter is required.</para>
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
