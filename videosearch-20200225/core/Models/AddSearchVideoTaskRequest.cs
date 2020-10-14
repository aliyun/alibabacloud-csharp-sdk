// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videosearch20200225.Models
{
    public class AddSearchVideoTaskRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("VideoUrl")]
        [Validation(Required=true)]
        public string VideoUrl { get; set; }

        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

        [NameInMap("VideoTags")]
        [Validation(Required=false)]
        public string VideoTags { get; set; }

        [NameInMap("ReturnVideoNumber")]
        [Validation(Required=false)]
        public int? ReturnVideoNumber { get; set; }

        [NameInMap("QueryTags")]
        [Validation(Required=false)]
        public string QueryTags { get; set; }

        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public int? StorageType { get; set; }

        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        [NameInMap("ReplaceStorageThreshold")]
        [Validation(Required=false)]
        public float? ReplaceStorageThreshold { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=true)]
        public string InstanceId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("SearchType")]
        [Validation(Required=false)]
        public int? SearchType { get; set; }

    }

}
