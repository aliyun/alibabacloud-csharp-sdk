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
        /// <para>The instance ID.</para>
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
        /// <para>The resource type.</para>
        /// <remarks>
        /// <para>This parameter is case-sensitive. Ensure that the value is spelled correctly.</para>
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
        /// <item><description>PackageUsedUpStrategy: Valid values:<list type="bullet">
        /// <item><description>Postpaid: Enters the pay-as-you-go phase.</description></item>
        /// <item><description>Shutdown: Hibernation.</description></item>
        /// <item><description>Maintenance: Shuts down and enters O&amp;M mode. Client connections are not allowed.</description></item>
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
