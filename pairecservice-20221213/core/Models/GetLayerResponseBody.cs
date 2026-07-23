// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetLayerResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of the layer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a test.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The time when the experiment layer was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-13 17:34:52.0</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The ID of the laboratory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("LaboratoryId")]
        [Validation(Required=false)]
        public string LaboratoryId { get; set; }

        /// <summary>
        /// <para>The name of the layer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>layer1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE97D06A-2AA0-5AD9-B6CF-8A267924D691</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The residual traffic in the experiment layer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ResidualFlow")]
        [Validation(Required=false)]
        public long? ResidualFlow { get; set; }

        /// <summary>
        /// <para>The ID of the scene.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

    }

}
