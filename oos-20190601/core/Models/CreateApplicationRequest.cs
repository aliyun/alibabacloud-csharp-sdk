// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CreateApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The configurations of application alerts.</para>
        /// </summary>
        [NameInMap("AlarmConfig")]
        [Validation(Required=false)]
        public CreateApplicationRequestAlarmConfig AlarmConfig { get; set; }
        public class CreateApplicationRequestAlarmConfig : TeaModel {
            /// <summary>
            /// <para>The alert contact groups.</para>
            /// </summary>
            [NameInMap("ContactGroups")]
            [Validation(Required=false)]
            public List<string> ContactGroups { get; set; }

            /// <summary>
            /// <para>The health check URL of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/healthcheck/tcp50122</para>
            /// </summary>
            [NameInMap("HealthCheckUrl")]
            [Validation(Required=false)]
            public string HealthCheckUrl { get; set; }

            /// <summary>
            /// <para>The alert templates.</para>
            /// </summary>
            [NameInMap("TemplateIds")]
            [Validation(Required=false)]
            public List<string> TemplateIds { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TF-CreateApplication-1647587475-84104b89-eba5-47a8-b2fd-807b8b7d</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyApplication</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The region ID. Set the value to cn-hangzhou.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxsn4m******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-79538e30e44541b699d8</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;k1&quot;:&quot;v1&quot;,&quot;k2&quot;:&quot;v2&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

    }

}
