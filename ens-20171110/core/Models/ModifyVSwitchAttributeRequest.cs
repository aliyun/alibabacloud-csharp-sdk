// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyVSwitchAttributeRequest : TeaModel {
        /// <summary>
        /// <para>Description.</para>
        /// <list type="bullet">
        /// <item><description><para>Must be 2 to 256 characters in length and can contain English or Chinese characters.</para>
        /// </description></item>
        /// <item><description><para>Cannot start with http\:// or https\://.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>this is my first vswitch</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EnableIPv6")]
        [Validation(Required=false)]
        public bool? EnableIPv6 { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2408:XXXX:0:a600::/110</para>
        /// </summary>
        [NameInMap("Ipv6CidrBlock")]
        [Validation(Required=false)]
        public string Ipv6CidrBlock { get; set; }

        /// <summary>
        /// <para>vSwitch ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>n-****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>vSwitch name.</para>
        /// <list type="bullet">
        /// <item><description><para>Must be 2 to 128 characters long. Can contain letters, digits, Chinese characters, underscores (_), and hyphens (-).</para>
        /// </description></item>
        /// <item><description><para>Must start with a letter or a Chinese character. Cannot start with http\:// or https\://.</para>
        /// </description></item>
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
