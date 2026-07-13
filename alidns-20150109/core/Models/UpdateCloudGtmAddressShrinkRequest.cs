// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateCloudGtmAddressShrinkRequest : TeaModel {
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
        /// <para>The updated IP address or domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>223.5.XX.XX</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

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
        /// <para>The attribution information of the address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>当前版本不支持此参数，不需要传入此参数。</para>
        /// </summary>
        [NameInMap("AttributeInfo")]
        [Validation(Required=false)]
        public string AttributeInfo { get; set; }

        /// <summary>
        /// <para>A client token that is used to ensure the idempotence of the request. You can specify a custom value for this parameter, but you must make sure that the value is unique among different requests. The value can contain a maximum of 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The updated condition for determining the health status of the address:</para>
        /// <list type="bullet">
        /// <item><description><para>any_ok: At least one probe is normal for all health check templates.</para>
        /// </description></item>
        /// <item><description><para>p30_ok: At least 30% of the probes are normal for all health check templates.</para>
        /// </description></item>
        /// <item><description><para>p50_ok: At least 50% of the probes are normal for all health check templates.</para>
        /// </description></item>
        /// <item><description><para>p70_ok: At least 70% of the probes are normal for all health check templates.</para>
        /// </description></item>
        /// <item><description><para>all_ok: All probes are normal for all health check templates.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>p50_ok</para>
        /// </summary>
        [NameInMap("HealthJudgement")]
        [Validation(Required=false)]
        public string HealthJudgement { get; set; }

        /// <summary>
        /// <para>The list of health check tasks.</para>
        /// </summary>
        [NameInMap("HealthTasks")]
        [Validation(Required=false)]
        public string HealthTasksShrink { get; set; }

        /// <summary>
        /// <para>The updated name of the address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Address-1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
