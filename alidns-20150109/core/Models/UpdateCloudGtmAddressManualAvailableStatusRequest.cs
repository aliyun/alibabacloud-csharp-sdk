// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateCloudGtmAddressManualAvailableStatusRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh-CN: Chinese</para>
        /// </description></item>
        /// <item><description><para>en-US (Default): English</para>
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
        /// <para>The unique ID of the address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>addr-89518218114368****</para>
        /// </summary>
        [NameInMap("AddressId")]
        [Validation(Required=false)]
        public string AddressId { get; set; }

        /// <summary>
        /// <para>The failover method for the address. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>auto: Automatic. The address status is determined by health check results. If a health check fails, DNS resolution stops. If it succeeds, DNS resolution resumes.</para>
        /// </description></item>
        /// <item><description><para>manual: Manual. You control the address status. If set to abnormal, DNS resolution stops and does not resume even if health checks succeed. If set to normal, DNS resolution resumes. If a health check fails, an alert is triggered but resolution does not stop.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>manual</para>
        /// </summary>
        [NameInMap("AvailableMode")]
        [Validation(Required=false)]
        public string AvailableMode { get; set; }

        /// <summary>
        /// <para>A client-generated token that is used to ensure the idempotence of the request. Make sure that the token is unique among different requests. The token can contain a maximum of 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The availability status of the address. This parameter takes effect only when AvailableMode is set to manual. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>available: Normal. The address is available. If a health check fails, an alert is triggered but DNS resolution continues.</para>
        /// </description></item>
        /// <item><description><para>unavailable: Abnormal. DNS resolution for the address is stopped. It does not resume even if health checks succeed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>available</para>
        /// </summary>
        [NameInMap("ManualAvailableStatus")]
        [Validation(Required=false)]
        public string ManualAvailableStatus { get; set; }

    }

}
