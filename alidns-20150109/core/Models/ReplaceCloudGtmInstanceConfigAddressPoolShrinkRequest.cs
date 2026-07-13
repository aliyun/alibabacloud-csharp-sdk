// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ReplaceCloudGtmInstanceConfigAddressPoolShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh-CN: Chinese</para>
        /// </description></item>
        /// <item><description><para>en-US (default): English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>A list of address pools.</para>
        /// </summary>
        [NameInMap("AddressPools")]
        [Validation(Required=false)]
        public string AddressPoolsShrink { get; set; }

        /// <summary>
        /// <para>A client-generated token that you use to ensure the idempotence of the request. Make sure that the token is unique among different requests. The token can contain a maximum of 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the instance configuration. For the same access domain name and GTM instance, you can configure both A and AAAA records. In this case, the GTM instance has two instance configurations. The ConfigId parameter uniquely identifies an instance configuration.</para>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/2797349.html">ListCloudGtmInstanceConfigs</a> operation to query the ConfigId of the instance configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Config-000****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// <para>The ID of the GTM 3.0 instance for which you want to replace address pools.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-cn-wwo3a3hb****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
