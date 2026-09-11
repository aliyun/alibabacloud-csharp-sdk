// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateDeviceGroupShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the device label. Set this parameter to an empty string to clear the description. The description can contain letters, digits, Chinese characters, spaces, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test device group description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the device label.</para>
        /// 
        /// <b>Example:</b>
        /// <para>device-group-5191cf830a5e****</para>
        /// </summary>
        [NameInMap("DeviceGroupId")]
        [Validation(Required=false)]
        public string DeviceGroupId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The operator of the dynamic device group rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AND</para>
        /// </summary>
        [NameInMap("DynamicOperator")]
        [Validation(Required=false)]
        [Obsolete]
        public string DynamicOperator { get; set; }

        /// <summary>
        /// <para>The matching rule of the dynamic device label.</para>
        /// </summary>
        [NameInMap("DynamicRule")]
        [Validation(Required=false)]
        public string DynamicRuleShrink { get; set; }

        /// <summary>
        /// <para>The name of the device label. The name must be 1 to 128 characters in length and can contain letters, digits, Chinese characters, periods (.), underscores (_), and hyphens (-). Spaces are not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
