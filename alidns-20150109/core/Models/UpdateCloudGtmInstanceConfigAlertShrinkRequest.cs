// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateCloudGtmInstanceConfigAlertShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh-CN: Chinese</para>
        /// </description></item>
        /// <item><description><para>en-US: English</para>
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
        /// <para>A list of alert configurations.</para>
        /// </summary>
        [NameInMap("AlertConfig")]
        [Validation(Required=false)]
        public string AlertConfigShrink { get; set; }

        /// <summary>
        /// <para>A list of alert notification groups.</para>
        /// </summary>
        [NameInMap("AlertGroup")]
        [Validation(Required=false)]
        public string AlertGroupShrink { get; set; }

        /// <summary>
        /// <para>The alert configuration mode for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>global: The instance inherits the global alert configuration.</para>
        /// </description></item>
        /// <item><description><para>instance_config: The instance uses a custom alert configuration.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("AlertMode")]
        [Validation(Required=false)]
        public string AlertMode { get; set; }

        /// <summary>
        /// <para>A client-generated token that ensures the idempotence of the request. The client must generate a unique value for this parameter. The token can contain a maximum of 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24**22</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the domain name instance configuration. A GTM instance can have two configurations for the same access domain name if you configure both A and AAAA records. The ConfigId uniquely identifies a configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Config-000**11</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// <para>The ID of the Global Traffic Manager (GTM) 3.0 instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-cn-zz11t58**0s</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
