// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class AddMediaWorkflowRequest : TeaModel {
        /// <summary>
        /// <para>The name of the media workflow.</para>
        /// <list type="bullet">
        /// <item><description>The value cannot be empty.</description></item>
        /// <item><description>The name cannot be the same as that of an existing media workflow within the current Alibaba Cloud account.</description></item>
        /// <item><description>The name can be up to 64 characters in length.</description></item>
        /// <item><description>The value must be encoded in the UTF-8 format.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mediaworkflow-example</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The topology of the media workflow. The value must be a JSON object that contains the activities and activity dependencies. For more information, see the <b>Sample topology</b> section of this topic.</para>
        /// <remarks>
        /// <para> The Object Storage Service (OSS) bucket must reside in the same region as your MPS service.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Topology")]
        [Validation(Required=false)]
        public string Topology { get; set; }

        /// <summary>
        /// <para>The triggering mode of the media workflow. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OssAutoTrigger</b>: The media workflow is automatically triggered.</description></item>
        /// <item><description><b>NotInAuto</b>: The media workflow is not automatically triggered.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OssAutoTrigger</para>
        /// </summary>
        [NameInMap("TriggerMode")]
        [Validation(Required=false)]
        public string TriggerMode { get; set; }

    }

}
