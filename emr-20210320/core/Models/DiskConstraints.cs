// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class DiskConstraints : TeaModel {
        /// <summary>
        /// <para>支持的磁盘类型。</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cloud_efficiency&quot;,&quot;cloud_ssd&quot;,&quot;cloud_essd&quot;,&quot;local_disk&quot;]</para>
        /// </summary>
        [NameInMap("Categories")]
        [Validation(Required=false)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// <para>磁盘数量最小值。</para>
        /// </summary>
        [NameInMap("CountConstraint")]
        [Validation(Required=false)]
        public ValueConstraints CountConstraint { get; set; }

        /// <summary>
        /// <para>磁盘容量限制。</para>
        /// </summary>
        [NameInMap("SizeConstraint")]
        [Validation(Required=false)]
        public ValueConstraints SizeConstraint { get; set; }

    }

}
