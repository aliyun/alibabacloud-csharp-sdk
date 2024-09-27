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
        /// <para>The failover mode that is used when address exceptions are identified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>auto: the automatic mode. The system determines whether to return an address based on health check results. If the address fails health checks, the system does not return the address. If the address passes health checks, the system returns the address.</description></item>
        /// <item><description>manual: the manual mode. If an address is in the unavailable state, the address is not returned for DNS requests even if the address passes health checks. If an address is in the available state, the address is returned for DNS requests even if an alert is triggered when the address fails health checks.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>manual</para>
        /// </summary>
        [NameInMap("AvailableMode")]
        [Validation(Required=false)]
        public string AvailableMode { get; set; }

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
        /// <para>The availability state of the address when AvailableMode is set to manual. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>available: The address is normal. In this state, the address is returned for DNS requests even if an alert is triggered when the address fails health checks.</description></item>
        /// <item><description>unavailable: The address is abnormal. In this state, the address is not returned for DNS requests even if the address passes health checks.</description></item>
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
