// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class UpdateMediaWorkflowTriggerModeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the media workflow that you want to update. To obtain the ID of the media workflow, you can log on to the <b>ApsaraVideo Media Processing (MPS) console</b> and choose <b>Workflows</b> &gt; <b>Workflow Settings</b> in the left-side navigation pane.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e00732b977da427d9177a4dee646****</para>
        /// </summary>
        [NameInMap("MediaWorkflowId")]
        [Validation(Required=false)]
        public string MediaWorkflowId { get; set; }

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
        /// <para>The trigger mode of the media workflow. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OssAutoTrigger</b>: automatically triggers the media workflow.</description></item>
        /// <item><description><b>NotInAuto</b>: does not automatically trigger the media workflow.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NotInAuto</para>
        /// </summary>
        [NameInMap("TriggerMode")]
        [Validation(Required=false)]
        public string TriggerMode { get; set; }

    }

}
