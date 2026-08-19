// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateDeviceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The description of the device label. The description can contain letters, digits, Chinese characters, spaces, periods (.), underscores (_), and hyphens (-). This parameter can be left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test device group description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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
        public Rule DynamicRule { get; set; }

        /// <summary>
        /// <para>The type of the device label. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>static</b>: static device label. After creation, manually add terminal devices by calling <a href="~~AddDeviceGroupMatchDevices~~">AddDeviceGroupMatchDevices</a>.</description></item>
        /// <item><description><b>dynamic</b>: dynamic device label. Members are automatically matched by the DynamicRule matching rule.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>static</para>
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>The name of the device label. The name must be 1 to 128 characters in length and can contain letters, digits, Chinese characters, periods (.), underscores (_), and hyphens (-). Spaces are not supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
