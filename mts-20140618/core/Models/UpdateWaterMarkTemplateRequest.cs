// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class UpdateWaterMarkTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The updated configuration of the watermark template. The value is a JSON object. For more information, see <a href="https://help.aliyun.com/document_detail/29253.html">Parameter details</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Width&quot;:&quot;10&quot;,&quot;Height&quot;:&quot;30&quot;,&quot;Dx&quot;:&quot;10&quot;,&quot;Dy&quot;:&quot;5&quot;,&quot;Type&quot;:&quot;Image&quot;,&quot;Timeline&quot;:{&quot;Start&quot;:&quot;0&quot;,&quot;Duration&quot;:&quot;10&quot;}}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The new name of the watermark template. The value can contain letters and digits and can be up to 128 bytes in size.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-watermark-****</para>
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
        /// <para>The ID of the watermark template that you want to update. To obtain the ID of the watermark template, you can log on to the <b>ApsaraVideo Media Processing (MPS) console</b> and choose <b>Global Settings</b> &gt; <b>Watermark Templates</b> in the left-side navigation pane.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3780bd69b2b74540bc7b1096f564****</para>
        /// </summary>
        [NameInMap("WaterMarkTemplateId")]
        [Validation(Required=false)]
        public string WaterMarkTemplateId { get; set; }

    }

}
