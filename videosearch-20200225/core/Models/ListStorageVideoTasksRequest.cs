// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videosearch20200225.Models
{
    public class ListStorageVideoTasksRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("VideoName")]
        [Validation(Required=false)]
        public string VideoName { get; set; }

        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=true)]
        public string InstanceId { get; set; }

        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public string StatusList { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("StorageInfoList")]
        [Validation(Required=false)]
        public string StorageInfoList { get; set; }

    }

}
