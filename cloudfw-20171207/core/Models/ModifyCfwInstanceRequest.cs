// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyCfwInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Cloud Firewall instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cfw_elasticity_public_cn-zsk39m******</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>A list of instance properties to update.</para>
        /// </summary>
        [NameInMap("UpdateList")]
        [Validation(Required=false)]
        public List<ModifyCfwInstanceRequestUpdateList> UpdateList { get; set; }
        public class ModifyCfwInstanceRequestUpdateList : TeaModel {
            /// <summary>
            /// <para>The code of the instance property to update.
            /// The following codes are supported:</para>
            /// <list type="bullet">
            /// <item><description><para>`Code`: `MajorVersion`. Set `Value` to `2`. This is available only for pay-as-you-go 1.0 users to upgrade their instances to pay-as-you-go 2.0.</para>
            /// <remarks>
            /// <para>Warning: </para>
            /// </remarks>
            /// <para>Make sure you understand the billing methods and pricing of pay-as-you-go 2.0.</para>
            /// <remarks>
            /// <para>Warning: </para>
            /// </remarks>
            /// <para>Note that if log delivery is enabled before the upgrade, it will remain enabled after the upgrade, and logs will be delivered to a new Logstore.</para>
            /// </description></item>
            /// <item><description><para>`Code`: `ThreatIntelligence`. This is available only for pay-as-you-go 2.0 users to enable or disable the threat intelligence feature. Set `Value` to `1` to enable the feature or `0` to disable it.</para>
            /// </description></item>
            /// <item><description><para>`Code`: `Sdl`. This is available only for pay-as-you-go 2.0 users to enable or disable the sensitive data leak detection feature. Set `Value` to `1` to enable the feature or `0` to disable it.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Sdl</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The value for the specified `Code`. For valid values, see the description of the `Code` parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
