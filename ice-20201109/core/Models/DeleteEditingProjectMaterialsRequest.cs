// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeleteEditingProjectMaterialsRequest : TeaModel {
        /// <summary>
        /// <para>The material ID. Separate multiple material IDs with commas (,). You can specify up to 10 IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><em><b><b>cbd721b418a89a7dafb1dc</b></b></em>,<em><b><b>86f5d534c95997c55c96f</b></b></em></para>
        /// </summary>
        [NameInMap("MaterialIds")]
        [Validation(Required=false)]
        public string MaterialIds { get; set; }

        /// <summary>
        /// <para>The material type. Valid values:</para>
        /// <para>\- video</para>
        /// <para>\- image</para>
        /// <para>\- audio</para>
        /// <para>\- subtitle</para>
        /// <para>\- text</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("MaterialType")]
        [Validation(Required=false)]
        public string MaterialType { get; set; }

        /// <summary>
        /// <para>The ID of the online editing project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><em><b><b>fb2101cb318</b></b></em></para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

    }

}
