// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeInstanceBootConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The startup method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>legacy</para>
        /// </summary>
        [NameInMap("BootSet")]
        [Validation(Required=false)]
        public string BootSet { get; set; }

        /// <summary>
        /// <para>The startup type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxe</para>
        /// </summary>
        [NameInMap("BootType")]
        [Validation(Required=false)]
        public string BootType { get; set; }

        /// <summary>
        /// <para>Specifies whether the startup depends on the disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("DiskSet")]
        [Validation(Required=false)]
        public string DiskSet { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
