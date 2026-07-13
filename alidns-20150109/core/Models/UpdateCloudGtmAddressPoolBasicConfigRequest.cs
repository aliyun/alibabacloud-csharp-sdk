// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateCloudGtmAddressPoolBasicConfigRequest : TeaModel {
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
        /// <para>The unique ID of the address pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pool-89528023225442****</para>
        /// </summary>
        [NameInMap("AddressPoolId")]
        [Validation(Required=false)]
        public string AddressPoolId { get; set; }

        /// <summary>
        /// <para>The name of the address pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app</para>
        /// </summary>
        [NameInMap("AddressPoolName")]
        [Validation(Required=false)]
        public string AddressPoolName { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. The client generates this token to make sure that each request is unique. The token can contain a maximum of 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The condition for determining the health status of the address pool.</para>
        /// <list type="bullet">
        /// <item><description><para>any_ok: At least one address in the address pool is active.</para>
        /// </description></item>
        /// <item><description><para>p30_ok: At least 30% of the addresses in the address pool are active.</para>
        /// </description></item>
        /// <item><description><para>p50_ok: At least 50% of the addresses in the address pool are active.</para>
        /// </description></item>
        /// <item><description><para>p70_ok: At least 70% of the addresses in the address pool are active.</para>
        /// </description></item>
        /// <item><description><para>all_ok: All addresses in the address pool are active.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>any_ok</para>
        /// </summary>
        [NameInMap("HealthJudgement")]
        [Validation(Required=false)]
        public string HealthJudgement { get; set; }

    }

}
