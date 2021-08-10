// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListAllPublicMediaTagsResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 公共素材库标签列表
        /// </summary>
        [NameInMap("MediaTagList")]
        [Validation(Required=false)]
        public List<ListAllPublicMediaTagsResponseBodyMediaTagList> MediaTagList { get; set; }
        public class ListAllPublicMediaTagsResponseBodyMediaTagList : TeaModel {
            /// <summary>
            /// 素材标签id
            /// </summary>
            [NameInMap("MediaTagId")]
            [Validation(Required=false)]
            public string MediaTagId { get; set; }

            /// <summary>
            /// 素材标签中文名
            /// </summary>
            [NameInMap("MediaTagNameChinese")]
            [Validation(Required=false)]
            public string MediaTagNameChinese { get; set; }

            /// <summary>
            /// 素材标签英文名
            /// </summary>
            [NameInMap("MediaTagNameEnglish")]
            [Validation(Required=false)]
            public string MediaTagNameEnglish { get; set; }

        }

    }

}
