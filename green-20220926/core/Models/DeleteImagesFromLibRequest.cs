// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class DeleteImagesFromLibRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[158794]</para>
        /// </summary>
        [NameInMap("ImageIds")]
        [Validation(Required=false)]
        public string ImageIds { get; set; }

        /// <summary>
        /// <para>Library ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>customxx_xxxx</para>
        /// </summary>
        [NameInMap("LibId")]
        [Validation(Required=false)]
        public string LibId { get; set; }

        /// <summary>
        /// <para>Region ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
