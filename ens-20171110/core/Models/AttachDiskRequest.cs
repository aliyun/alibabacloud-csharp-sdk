// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AttachDiskRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the cloud disk to be mounted is released when the instance is released. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The cloud disk is released when the instance is released.</description></item>
        /// <item><description>false: The cloud disk is retained when the instance is released.</description></item>
        /// <item><description>Empty: The default value is false.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteWithInstance")]
        [Validation(Required=false)]
        public string DeleteWithInstance { get; set; }

        /// <summary>
        /// <para>The ID of the cloud disk to mount. The cloud disk and the instance must be in the same edge zone.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-5saf13yy6sopmmg88mzsg****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
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
