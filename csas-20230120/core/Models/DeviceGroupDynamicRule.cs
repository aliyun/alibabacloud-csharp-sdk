// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class DeviceGroupDynamicRule : TeaModel {
        /// <summary>
        /// <para>The list of matching parameters. The meaning of the parameters is determined by both Key and Operator. When Key is set to dev_type and Operator is set to in, specify the operating system types to match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;windows&quot;]</para>
        /// </summary>
        [NameInMap("Args")]
        [Validation(Required=false)]
        public object Args { get; set; }

        /// <summary>
        /// <para>The user endpoint device property key used for dynamic matching. The example value dev_type indicates the operating system type of the endpoint device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dev_type</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The matching operator applied to the property specified by Key. The example value in indicates that the property value belongs to the list of parameters specified by Args.</para>
        /// 
        /// <b>Example:</b>
        /// <para>in</para>
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

    }

}
