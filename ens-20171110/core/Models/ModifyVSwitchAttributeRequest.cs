// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyVSwitchAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The description of the vSwitch.</para>
        /// <list type="bullet">
        /// <item><description>The description must be 2 to 256 characters in length.</description></item>
        /// <item><description>The description cannot start with http:// or https://.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>this is my first network</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>n-****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The name of the vSwitch.</para>
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 128 characters in length.</description></item>
        /// <item><description>The name must start with a letter and cannot start with http:// or https://.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Test-switch</para>
        /// </summary>
        [NameInMap("VSwitchName")]
        [Validation(Required=false)]
        public string VSwitchName { get; set; }

    }

}
