// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class AddLargeModelShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The authorization code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-xxxxxxxxxxx*******xx</para>
        /// </summary>
        [NameInMap("AuthCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// <para>The base model.</para>
        /// </summary>
        [NameInMap("BaseModel")]
        [Validation(Required=false)]
        public string BaseModelShrink { get; set; }

        /// <summary>
        /// <para>The model name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test Model Name</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The model URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxxxxxxxxxx">https://xxxxxxxxxxx</a></para>
        /// </summary>
        [NameInMap("ModelUrl")]
        [Validation(Required=false)]
        public string ModelUrl { get; set; }

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
        /// <para>The temperature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.1</para>
        /// </summary>
        [NameInMap("Temperature")]
        [Validation(Required=false)]
        public double? Temperature { get; set; }

        /// <summary>
        /// <para>The <c>top-k</c> value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public long? TopK { get; set; }

        /// <summary>
        /// <para>The <c>top-p</c> value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.1</para>
        /// </summary>
        [NameInMap("TopP")]
        [Validation(Required=false)]
        public double? TopP { get; set; }

    }

}
