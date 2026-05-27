// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class UpdateLargeModelShrinkRequest : TeaModel {
        /// <summary>
        /// <para>授权码</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("AuthCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// <para>基础模型</para>
        /// </summary>
        [NameInMap("BaseModel")]
        [Validation(Required=false)]
        public string BaseModelShrink { get; set; }

        /// <summary>
        /// <para>模型编码</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test Model Name</para>
        /// </summary>
        [NameInMap("ModelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

        /// <summary>
        /// <para>模型名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>模型地址</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
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
        /// <para>温度</para>
        /// 
        /// <b>Example:</b>
        /// <para>49.29</para>
        /// </summary>
        [NameInMap("Temperature")]
        [Validation(Required=false)]
        public double? Temperature { get; set; }

        /// <summary>
        /// <para>topK</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public long? TopK { get; set; }

        /// <summary>
        /// <para>topP</para>
        /// 
        /// <b>Example:</b>
        /// <para>84.38427</para>
        /// </summary>
        [NameInMap("TopP")]
        [Validation(Required=false)]
        public double? TopP { get; set; }

    }

}
