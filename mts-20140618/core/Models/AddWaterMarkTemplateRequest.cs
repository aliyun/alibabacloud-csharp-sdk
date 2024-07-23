// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class AddWaterMarkTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the watermark template. The value is a JSON object. For more information, see the &quot;WaterMarks&quot; section of the <a href="https://help.aliyun.com/document_detail/29253.html">Parameter details</a> topic.</para>
        /// <remarks>
        /// <para>If you do not require a positive correlation between the size of text in the watermark and the resolution, you can enable adaptation for the watermark. To do so, add <c>[\\&quot;adaptive\\&quot;]=true</c> to the TextWaterMark parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Width&quot;:&quot;10&quot;,&quot;Height&quot;:&quot;30&quot;,&quot;Dx&quot;:&quot;10&quot;,&quot;Dy&quot;:&quot;5&quot;,&quot;ReferPos&quot;:&quot;TopRight&quot;,&quot;Type&quot;:&quot;Image&quot;,&quot;Timeline&quot;:{&quot;Start&quot;:&quot;0&quot;,&quot;Duration&quot;:&quot;10&quot;}}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The name of the watermark template. The value can contain letters and digits and can be up to 128 bytes in size.</para>
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

    }

}
