// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyInstanceBootConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The boot method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>legacy</para>
        /// </summary>
        [NameInMap("BootSet")]
        [Validation(Required=false)]
        public string BootSet { get; set; }

        /// <summary>
        /// <para>The boot type.
        /// Governance testing has confirmed that the value disk passes parameter validation, whereas the original example value pxe returns Parameter.Invalid. Other values have not been confirmed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>disk</para>
        /// </summary>
        [NameInMap("BootType")]
        [Validation(Required=false)]
        public string BootType { get; set; }

        /// <summary>
        /// <para>Specifies whether the boot process depends on a disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("DiskSet")]
        [Validation(Required=false)]
        public string DiskSet { get; set; }

        /// <summary>
        /// <para>The ID of the instance whose boot configuration you want to modify. You can specify only one instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-instance****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
