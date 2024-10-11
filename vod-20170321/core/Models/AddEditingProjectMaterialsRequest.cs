// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddEditingProjectMaterialsRequest : TeaModel {
        /// <summary>
        /// <para>Separate multiple material IDs with commas (,). You can specify up to 10 IDs.</para>
        /// <remarks>
        /// <para> If you specify multiple materials, make sure that the materials are of the same type as specified in MaterialType.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d3251979f9fd41f2acb29ccda5a6f772</para>
        /// </summary>
        [NameInMap("MaterialIds")]
        [Validation(Required=false)]
        public string MaterialIds { get; set; }

        /// <summary>
        /// <para>The type of the material. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>video</b></description></item>
        /// <item><description><b>audio</b></description></item>
        /// <item><description><b>image</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("MaterialType")]
        [Validation(Required=false)]
        public string MaterialType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the online editing project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>afa31b483b5c41609185de0e1b790579</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public string ResourceOwnerId { get; set; }

    }

}
