// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AttachDiskRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the disk to be attached is released with the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The disk will be released when the ECS instance is released.</description></item>
        /// <item><description>false: The disk will be retained when the ECS instance is released.</description></item>
        /// <item><description>If you leave this parameter empty, the default value is used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteWithInstance")]
        [Validation(Required=false)]
        public string DeleteWithInstance { get; set; }

        /// <summary>
        /// <para>The ID of the disk to be attached. The cloud disk and the instance must belong to the same node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-5saf13yy6sopmmg88mzsg****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-5rr19av7tkpgi9os52ag1****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
