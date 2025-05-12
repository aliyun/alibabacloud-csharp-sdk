// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class UpdateSmarttagTemplateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ocr,asr</para>
        /// </summary>
        [NameInMap("AnalyseTypes")]
        [Validation(Required=false)]
        public string AnalyseTypes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>celebrity</para>
        /// </summary>
        [NameInMap("FaceCategoryIds")]
        [Validation(Required=false)]
        public string FaceCategoryIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{ &quot;faceDetThreshold&quot;:0.999, &quot;faceRegThreshold&quot;:0.9 }</para>
        /// </summary>
        [NameInMap("FaceCustomParamsConfig")]
        [Validation(Required=false)]
        public string FaceCustomParamsConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>common</para>
        /// </summary>
        [NameInMap("Industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{ &quot;type&quot;: &quot;name,location,organization,other&quot; }</para>
        /// </summary>
        [NameInMap("KeywordConfig")]
        [Validation(Required=false)]
        public string KeywordConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{ &quot;movie&quot;:&quot;name,alias,chnl,genre&quot;, &quot;music&quot;:&quot;songName,artistName&quot;, &quot;person&quot;:&quot;name,gender&quot; }</para>
        /// </summary>
        [NameInMap("KnowledgeConfig")]
        [Validation(Required=false)]
        public string KnowledgeConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hmi</para>
        /// </summary>
        [NameInMap("LabelType")]
        [Validation(Required=false)]
        public string LabelType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("LabelVersion")]
        [Validation(Required=false)]
        public string LabelVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>common</para>
        /// </summary>
        [NameInMap("LandmarkGroupIds")]
        [Validation(Required=false)]
        public string LandmarkGroupIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>general,item,weapon,animal</para>
        /// </summary>
        [NameInMap("ObjectGroupIds")]
        [Validation(Required=false)]
        public string ObjectGroupIds { get; set; }

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
        /// <b>Example:</b>
        /// <para>search</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public string TemplateConfig { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05de22f255284c7a8d2aab535dde****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>template-example-****</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
