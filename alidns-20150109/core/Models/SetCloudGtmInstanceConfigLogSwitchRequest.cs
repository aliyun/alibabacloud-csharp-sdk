// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SetCloudGtmInstanceConfigLogSwitchRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. Generate a unique value for this parameter. The client token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>F4D7C841-A1C9-50B4-88B7-F5****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the instance configuration. A and AAAA records can be configured for the same connected domain name and GTM instance. In this case, the GTM instance has two instance configurations. ConfigId uniquely identifies an instance configuration. To find the ConfigId for a domain name instance, call the <a href="https://help.aliyun.com/document_detail/2797349.html">ListCloudGtmInstanceConfigs</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Config-000****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// <para>The ID of the Global Traffic Manager (GTM) 3.0 instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-cn-wwo3a3h****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The status of the network traffic analysis feature:</para>
        /// <list type="bullet">
        /// <item><description><para>enable</para>
        /// </description></item>
        /// <item><description><para>disable</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enable
        /// disable</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
