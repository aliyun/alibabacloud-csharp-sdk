// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetImageDistributeInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the image whose region distribution information you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imgc-bp1example****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The ID of the image version. If this parameter is not specified, the online version of the image is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iv-xxx</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
