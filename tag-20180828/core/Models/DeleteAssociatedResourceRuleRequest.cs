// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class DeleteAssociatedResourceRuleRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The name of the associated resource tagging rule.</para>
        /// <para>For more information, see the <b>Rule Name</b> column in <a href="https://help.aliyun.com/document_detail/2586330.html">Resource types that support the Associated Resource Tagging feature</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule:AttachEni-DetachEni-TagInstance:Ecs-Instance:Ecs-Eni</para>
        /// </summary>
        [NameInMap("SettingName")]
        [Validation(Required=false)]
        public string SettingName { get; set; }

    }

}
