// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryWaterMarkTemplateListRequest : TeaModel {
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
        /// <para>The IDs of the watermark templates that you want to query. To obtain the IDs of the watermark templates, you can log on to the <b>ApsaraVideo Media Processing (MPS) console</b> and choose <b>Global Settings</b> &gt; <b>Watermark Templates</b> in the left-side navigation pane. You can query up to 10 watermark templates at a time. Separate multiple IDs of watermark templates with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3780bd69b2b74540bc7b1096f564****</para>
        /// </summary>
        [NameInMap("WaterMarkTemplateIds")]
        [Validation(Required=false)]
        public string WaterMarkTemplateIds { get; set; }

    }

}
