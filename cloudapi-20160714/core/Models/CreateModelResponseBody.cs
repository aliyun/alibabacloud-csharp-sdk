// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateModelResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the model was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-01-29T09:33:01Z</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The description of the created model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Model Description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the API group to which the created model belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30e792398d6c4569b04c0e53a3494381</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the created model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>766c0b9538a04bdf974953b5576783ba</para>
        /// </summary>
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <para>The name of the created model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The URI of the created model.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://apigateway.aliyun.com/models/30e792398d6c4569b04c0e53a3494381/766c0b9538a04bdf974953b5576783ba">https://apigateway.aliyun.com/models/30e792398d6c4569b04c0e53a3494381/766c0b9538a04bdf974953b5576783ba</a></para>
        /// </summary>
        [NameInMap("ModelRef")]
        [Validation(Required=false)]
        public string ModelRef { get; set; }

        /// <summary>
        /// <para>The time when the model is last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-01-29T09:33:01Z</para>
        /// </summary>
        [NameInMap("ModifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// <para>The region to which the created model belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4173F95B-360C-460C-9F6C-4A960B904411</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The definition of the created model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;type\&quot;:\&quot;object\&quot;,\&quot;properties\&quot;:{\&quot;id\&quot;:{\&quot;format\&quot;:\&quot;int64\&quot;,\&quot;maximum\&quot;:100,\&quot;exclusiveMaximum\&quot;:true,\&quot;type\&quot;:\&quot;integer\&quot;},\&quot;name\&quot;:{\&quot;maxLength\&quot;:10,\&quot;type\&quot;:\&quot;string\&quot;}}}</para>
        /// </summary>
        [NameInMap("Schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

    }

}
