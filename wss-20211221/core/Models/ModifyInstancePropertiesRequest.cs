// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class ModifyInstancePropertiesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mdp-0c62ayep0nk4v****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance IDs.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The key of the attribute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PackageUsedUpStrategy</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The list of instance attributes to modify. You can modify multiple key-value pairs at a time. These pairs are merged with the original Key and Value request parameters. If an attribute with the same name has the same value, it is deduplicated. If the values are different, a parameter error is returned.</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public List<ModifyInstancePropertiesRequestProperties> Properties { get; set; }
        public class ModifyInstancePropertiesRequestProperties : TeaModel {
            /// <summary>
            /// <para>The name of the instance attribute. For example, DisableRemainingNotify specifies whether to disable the remaining duration reminder for the client, and PackageUsedUpStrategy specifies the policy applied when the package duration is used up.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DisableRemainingNotify</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the instance attribute. When Key is set to DisableRemainingNotify, only the string true or false is supported, and ResourceType must be set to DurationPackage. A value of true indicates that the remaining duration reminder for the client is disabled. A value of false indicates that the reminder is retained and triggered based on the original conditions. Administrator notifications continue to be triggered based on the original conditions. For other attributes, pass values based on their respective definitions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The resource type.</para>
        /// <remarks>
        /// <para>This parameter is case-sensitive. Ensure correct spelling.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DurationPackage</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The value of the attribute.</para>
        /// <list type="bullet">
        /// <item><description>PackageUsedUpStrategy: [enum]<list type="bullet">
        /// <item><description>Postpaid (switches to the pay-as-you-go billing method)</description></item>
        /// <item><description>Shutdown (hibernates or shuts down the instance)</description></item>
        /// <item><description>Maintenance (stops the instance and enters O&amp;M mode, and does not allow client connections)</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
