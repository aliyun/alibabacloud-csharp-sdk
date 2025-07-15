// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class GetMessageTokenRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the interactive messaging application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a494caec-***-695ef345db77</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the device. Each device has a unique ID. You can specify a custom ID. The ID can be up to 64 characters in length and can contain lowercase letters, digits, underscores (_), and hyphen (-). You can specify multiple device IDs. We recommend that you obtain the IDs from the devices and pass the IDs to the server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a494caec-***-695ef345db77</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <para>The type of the device. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ios</description></item>
        /// <item><description>android</description></item>
        /// <item><description>web</description></item>
        /// <item><description>pc</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>android</para>
        /// </summary>
        [NameInMap("DeviceType")]
        [Validation(Required=false)]
        public string DeviceType { get; set; }

        /// <summary>
        /// <para>The ID of the user. Each user has a unique ID in the application. The ID can be up to 32 characters in length and can contain lowercase letters, digits, underscores (_), and periods (.). You can specify multiple user IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>de1**a0</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
