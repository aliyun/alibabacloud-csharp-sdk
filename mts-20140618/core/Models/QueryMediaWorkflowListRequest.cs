// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMediaWorkflowListRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the media workflows that you want to query. To obtain the IDs of the media workflows, you can log on to the <b>ApsaraVideo Media Processing (MPS) console</b> and choose <b>Workflows</b> &gt; <b>Workflow Settings</b> in the left-side navigation pane. You can query up to 10 media workflows at a time. Separate multiple IDs of media workflows with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>93ab850b4f6f44eab54b6e9181d4****,72dfa5e679ab4be9a3ed9974c736****</para>
        /// </summary>
        [NameInMap("MediaWorkflowIds")]
        [Validation(Required=false)]
        public string MediaWorkflowIds { get; set; }

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

    }

}
