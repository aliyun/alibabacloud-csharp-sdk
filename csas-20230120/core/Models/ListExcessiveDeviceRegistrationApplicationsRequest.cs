// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListExcessiveDeviceRegistrationApplicationsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the excessive device registration applications.</para>
        /// </summary>
        [NameInMap("ApplicationIds")]
        [Validation(Required=false)]
        public List<string> ApplicationIds { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: 1 to 10,000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The user\&quot;s department. The value must be 1 to 128 characters long and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), commas (,), semicolons (;), hyphens (-), underscores (_), forward slashes (/), at signs (@), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试部</para>
        /// </summary>
        [NameInMap("Department")]
        [Validation(Required=false)]
        public string Department { get; set; }

        /// <summary>
        /// <para>The device ID. You can get the device ID from the <c>DeviceTag</c> parameter returned by the following operations:</para>
        /// <list type="bullet">
        /// <item><description><para><a href="~~GetUserDevice~~">GetUserDevice</a>: Queries the details of a user\&quot;s device.</para>
        /// </description></item>
        /// <item><description><para><a href="~~ListUserDevices~~">ListUserDevices</a>: Queries a list of devices for a user.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>36efa42d-2c32-c4dc-e3fc-8541e33a****</para>
        /// </summary>
        [NameInMap("DeviceTag")]
        [Validation(Required=false)]
        public string DeviceTag { get; set; }

        /// <summary>
        /// <para>The hostname of the device. The value must be 1 to 128 characters long and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), commas (,), semicolons (;), hyphens (-), underscores (<em>), forward slashes (/), at signs (@), and spaces. If you specify only an underscore (</em>), the query is extended to include devices whose hostnames contain 4-byte UTF-8 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>win10-64bit</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <para>The MAC address of the device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:16:XX:XX:7c:46</para>
        /// </summary>
        [NameInMap("Mac")]
        [Validation(Required=false)]
        public string Mac { get; set; }

        /// <summary>
        /// <para>The number of entries on each page. Valid values: 1 to 500.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The user ID. You can get the user ID from the <c>SaseUserId</c> parameter returned by the following operations:</para>
        /// <list type="bullet">
        /// <item><description><para><a href="~~GetUserDevice~~">GetUserDevice</a>: Queries the details of a user\&quot;s device.</para>
        /// </description></item>
        /// <item><description><para><a href="~~ListUserDevices~~">ListUserDevices</a>: Queries a list of devices for a user.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
        /// </summary>
        [NameInMap("SaseUserId")]
        [Validation(Required=false)]
        public string SaseUserId { get; set; }

        /// <summary>
        /// <para>The statuses of excessive device registration applications.</para>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public List<string> Statuses { get; set; }

        /// <summary>
        /// <para>The username. The value must be 1 to 128 characters long and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), hyphens (-), asterisks (\*), at signs (@), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>王先生</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
