// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class UpdateAclGroupCidrsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the allow list group.</para>
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-xxxx</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The new CIDR blocks for the allow list group. To specify multiple CIDR blocks, separate them with a comma.</para>
        /// 
        /// <b>Example:</b>
        /// <para>140.205.11.0/24,140.205.11.2</para>
        /// </summary>
        [NameInMap("newCidrs")]
        [Validation(Required=false)]
        public string NewCidrs { get; set; }

    }

}
