// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVideoInfosRequest : TeaModel {
        /// <summary>
        /// <para>The list of video IDs. Separate multiple IDs with commas (,). A maximum of 20 IDs can be specified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7753d144efd8e649c6c45fe0579****,7753d144efd74d6c45fe0570****</para>
        /// </summary>
        [NameInMap("VideoIds")]
        [Validation(Required=false)]
        public string VideoIds { get; set; }

    }

}
