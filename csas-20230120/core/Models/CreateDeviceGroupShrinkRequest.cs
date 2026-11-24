// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateDeviceGroupShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the device tag. The description can contain Chinese characters, uppercase and lowercase letters, digits, spaces, periods (.), underscores (_), and hyphens (-). This parameter can be left empty.</para>
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
        /// <para>The operator for dynamic device group rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AND</para>
        /// </summary>
        [NameInMap("DynamicOperator")]
        [Validation(Required=false)]
        [Obsolete]
        public string DynamicOperator { get; set; }

        /// <summary>
        /// <para>The matching rule for the dynamic device tag.</para>
        /// </summary>
        [NameInMap("DynamicRule")]
        [Validation(Required=false)]
        public string DynamicRuleShrink { get; set; }

        /// <summary>
        /// <para>The type of the device tag. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>static</b>: static device tag. After the tag is created, you can manually add terminal devices by calling the <a href="~~AddDeviceGroupMatchDevices~~">AddDeviceGroupMatchDevices</a> operation.</description></item>
        /// <item><description><b>dynamic</b>: dynamic device tag. Members are automatically matched based on the DynamicRule matching rule.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>static</para>
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>The name of the device tag. The name must be 1 to 128 characters in length and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), and hyphens (-). Spaces are not allowed.</para>
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
