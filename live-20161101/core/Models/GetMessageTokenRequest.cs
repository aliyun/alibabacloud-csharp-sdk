// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class GetMessageTokenRequest : TeaModel {
        /// <summary>
        /// <para>Interactive Messages application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a494caec-***-695ef345db77</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Terminal device ID, uniquely representing a user terminal device, user-defined. It consists of lowercase letters, numbers, underscores (_), and hyphens (-), with a maximum length of 64 characters. Different terminal devices need to use different DeviceIds. We recommend obtaining it from the terminal device and passing it to the server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a494caec-***-695ef345db77</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <para>Terminal device type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ios</para>
        /// </description></item>
        /// <item><description><para>android</para>
        /// </description></item>
        /// <item><description><para>web</para>
        /// </description></item>
        /// <item><description><para>pc</para>
        /// </description></item>
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
        /// <para>User UserId, user-defined, unique within the AppId. It consists of lowercase letters, numbers, underscores (_), and periods (.), with a maximum length of 32 characters. Different users need to use different UserIds.</para>
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
