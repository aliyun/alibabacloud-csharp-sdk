// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateCloudGtmInstanceConfigEnableStatusRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh-CN</b>: Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en-US</b> (default): English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>A client-generated token that is used to ensure the idempotence of the request. The token must be unique among different requests and can contain a maximum of 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the domain name instance configuration. For the same access domain name and GTM instance, you can configure both A and AAAA records. This results in two domain name instance configurations for the GTM instance. The ConfigId uniquely identifies a specific configuration.</para>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/2797349.html">ListCloudGtmInstanceConfigs</a> operation to query the ConfigId of a domain name instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Config-000****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// <para>The enablement status of the domain name instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>enable: Enables the domain name instance.</para>
        /// </description></item>
        /// <item><description><para>disable: Disables the domain name instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("EnableStatus")]
        [Validation(Required=false)]
        public string EnableStatus { get; set; }

        /// <summary>
        /// <para>The ID of the GTM 3.0 instance that you want to modify.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-cn-wwo3a3h****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
