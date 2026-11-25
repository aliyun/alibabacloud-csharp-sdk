// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class CreateDeviceRequest : TeaModel {
        /// <summary>
        /// <para>The subscribed national standard alarm methods. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: All.</description></item>
        /// <item><description>5: Video alarm.</description></item>
        /// <item><description>7: Other alarms.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>An empty value indicates no subscription.</description></item>
        /// <item><description>Multiple values are supported and must be separated by commas (,).</description></item>
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
        /// <para>Specifies whether to enable device location subscription. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Yes.</description></item>
        /// <item><description>false: No.
        /// Default value: false.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPos")]
        [Validation(Required=false)]
        public bool? AutoPos { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically start the stream. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Yes.</description></item>
        /// <item><description>false: No.
        /// Default value: false.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoStart")]
        [Validation(Required=false)]
        public bool? AutoStart { get; set; }

        /// <summary>
        /// <para>The description of the device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx intersection camera</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the folder to which the device belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>399*****488-cn-qingdao</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The serial number of the device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7D0*****4C0</para>
        /// </summary>
        [NameInMap("Dsn")]
        [Validation(Required=false)]
        public string Dsn { get; set; }

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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>348*****174-cn-qingdao</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

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
        /// <para>The name of the device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx intersection camera</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The other parameters of the device, in the format of a JSON serialized string.</para>
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
        /// <para>399*****774-cn-qingdao</para>
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// <para>The password of the device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The port of the device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public long? Port { get; set; }

        /// <summary>
        /// <para>The location subscription interval, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("PosInterval")]
        [Validation(Required=false)]
        public long? PosInterval { get; set; }

        /// <summary>
        /// <para>The type of the device. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ipc: IP camera.</description></item>
        /// <item><description>platform: Platform.</description></item>
        /// <item><description>ied: Intelligent device.</description></item>
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
        /// <para>The URL of the stream on the device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://xxx/xxx</para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        /// <summary>
        /// <para>The username of the device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The vendor of the device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Company A</para>
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

    }

}
