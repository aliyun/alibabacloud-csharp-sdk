// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ImAuditRequest : TeaModel {
        /// <summary>
        /// <para>The business type. By default, the public business type is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>139440480445****</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The custom text entries. You can specify up to 5 text entries. The value must be a JSON array. You must specify at least one of the Images and Contents parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;Hello&quot;,&quot;Who are you&quot;,&quot;Where am I&quot;]</para>
        /// </summary>
        [NameInMap("Contents")]
        [Validation(Required=false)]
        public string Contents { get; set; }

        /// <summary>
        /// <para>The image URLs. You can specify up to 5 image URLs. The value must be a JSON array. To view the URLs of the images, you can log on to the <b>ApsaraVideo Media Processing (MPS) console</b> and choose <b>Media Management</b> &gt; <b>Media List</b> in the left-side navigation pane. You must set at least one of the Images and Contents parameters. The image to be moderated must meet the following limits. Otherwise, the moderation task may fail.</para>
        /// <list type="bullet">
        /// <item><description>The image size cannot exceed 20 MB, the height or width of the image cannot exceed 30,000 pixels, and the image cannot exceed 0.25 billion pixels.</description></item>
        /// <item><description>We recommend that you upload images of at least 256 × 256 pixels to ensure required moderation result.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;http://<c>127.66.**.**</c>/image.jpeg&quot;,&quot;http://<c>127.66.**.**</c>/photo.jpeg&quot;]</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public string Images { get; set; }

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
        /// <para>The moderation scenarios. Separate multiple scenarios with commas (,). For example, if you specify {&quot;porn&quot;,&quot;terrorism&quot;} for this parameter, both pornographic content detection and terrorist content detection are performed on the images and text. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>porn: pornography</description></item>
        /// <item><description>terrorism: terrorist content</description></item>
        /// <item><description>ad: ad violation</description></item>
        /// <item><description>qrcode: QR code</description></item>
        /// <item><description>live: undesirable scene</description></item>
        /// <item><description>logo: special logo</description></item>
        /// <item><description>antispam: text anti-spam (valid only for text)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;porn&quot;,&quot;terrorism&quot;,&quot;ad&quot;]</para>
        /// </summary>
        [NameInMap("Scenes")]
        [Validation(Required=false)]
        public string Scenes { get; set; }

    }

}
