// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListSmartSysAvatarModelsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SmartSysAvatarModelList")]
        [Validation(Required=false)]
        public List<ListSmartSysAvatarModelsResponseBodySmartSysAvatarModelList> SmartSysAvatarModelList { get; set; }
        public class ListSmartSysAvatarModelsResponseBodySmartSysAvatarModelList : TeaModel {
            [NameInMap("AvatarId")]
            [Validation(Required=false)]
            public string AvatarId { get; set; }

            [NameInMap("AvatarName")]
            [Validation(Required=false)]
            public string AvatarName { get; set; }

            [NameInMap("CoverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

            [NameInMap("VideoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
