// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateCloudGtmAddressRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN: Chinese</description></item>
        /// <item><description>en-US (default): English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>Modified IP address or domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>223.5.XX.XX</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The ID of the address. This ID uniquely identifies the address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>addr-89518218114368**92</para>
        /// </summary>
        [NameInMap("AddressId")]
        [Validation(Required=false)]
        public string AddressId { get; set; }

        /// <summary>
        /// <para>Address Attribution information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This parameter is not supported in the current version and does not need to be input.</para>
        /// </summary>
        [NameInMap("AttributeInfo")]
        [Validation(Required=false)]
        public string AttributeInfo { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can specify a custom value for this parameter, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24**22</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The condition for determining the health status of the address. This parameter is required when HealthTasks is specified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>any_ok: The health check results of at least one health check template are normal.</description></item>
        /// <item><description>p30_ok: The health check results of at least 30% of health check templates are normal.</description></item>
        /// <item><description>p50_ok: The health check results of at least 50% of health check templates are normal.</description></item>
        /// <item><description>p70_ok: The health check results of at least 70% of health check templates are normal.</description></item>
        /// <item><description>all_ok: The health check results of all health check templates are normal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>p50_ok</para>
        /// </summary>
        [NameInMap("HealthJudgement")]
        [Validation(Required=false)]
        public string HealthJudgement { get; set; }

        /// <summary>
        /// <para>The health check tasks.</para>
        /// </summary>
        [NameInMap("HealthTasks")]
        [Validation(Required=false)]
        public List<UpdateCloudGtmAddressRequestHealthTasks> HealthTasks { get; set; }
        public class UpdateCloudGtmAddressRequestHealthTasks : TeaModel {
            /// <summary>
            /// <para>The target service port for health checks. When the Ping protocol is selected for health checks, configuration of the service port is not supported.</para>
            /// <list type="bullet">
            /// <item><description>If the input parameter is empty: Delete the currently configured port number;</description></item>
            /// <item><description>If the input parameter is not empty: Update the port number based on the input parameter;</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>ID of the health check template associated with the address. This parameter is required if a health check port is configured.</para>
            /// <list type="bullet">
            /// <item><description>If the input parameter is empty: Delete the currently configured detection template;</description></item>
            /// <item><description>If the input parameter is not empty: Update the detection template based on the input parameter;</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>mtp-89518052425100**80</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// <para>Modified address name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Address-1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
