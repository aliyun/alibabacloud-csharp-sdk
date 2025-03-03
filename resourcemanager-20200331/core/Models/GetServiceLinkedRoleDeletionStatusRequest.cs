// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetServiceLinkedRoleDeletionStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the deletion task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task/acs-service-role/hdr.aliyuncs.com/AliyunServiceRoleForHdr/c4d22c52-247f-4ee1-83a2-6c0460bd****</para>
        /// </summary>
        [NameInMap("DeletionTaskId")]
        [Validation(Required=false)]
        public string DeletionTaskId { get; set; }

    }

}
