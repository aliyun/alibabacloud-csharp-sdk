// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class UpdateLargeModelShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The authorization code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-sxxxxx*********xx</para>
        /// </summary>
        [NameInMap("AuthCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// <para>A list of base models.</para>
        /// </summary>
        [NameInMap("BaseModel")]
        [Validation(Required=false)]
        public string BaseModelShrink { get; set; }

        /// <summary>
        /// <para>The model code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test Model Name</para>
        /// </summary>
        [NameInMap("ModelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

        /// <summary>
        /// <para>The model name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test model</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The model URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxxxxxxxx">https://xxxxxxxxx</a></para>
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
        /// <para>Controls the randomness of the model\&quot;s output. A higher value increases randomness, and a lower value makes the output more deterministic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.1</para>
        /// </summary>
        [NameInMap("Temperature")]
        [Validation(Required=false)]
        public double? Temperature { get; set; }

        /// <summary>
        /// <para>Restricts token selection to the top k most probable tokens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public long? TopK { get; set; }

        /// <summary>
        /// <para>Controls output diversity by using nucleus sampling. It defines a cumulative probability threshold for token selection, considering only the most likely tokens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.1</para>
        /// </summary>
        [NameInMap("TopP")]
        [Validation(Required=false)]
        public double? TopP { get; set; }

    }

}
