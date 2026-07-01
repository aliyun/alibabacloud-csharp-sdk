// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateDNADBRequest : TeaModel {
        /// <summary>
        /// <para>The description of the DNA database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是一个视频DNA库。</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The DNA database model. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Video</b>: For video content.</para>
        /// </description></item>
        /// <item><description><para><b>Audio</b>: For audio content.</para>
        /// </description></item>
        /// <item><description><para><b>Image</b>: For image content. (Deprecated)</para>
        /// </description></item>
        /// <item><description><para><b>Text</b>: For text content. Supported only in the China (Shanghai) region. (Deprecated)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Video</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The name of the DNA database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example name</para>
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
