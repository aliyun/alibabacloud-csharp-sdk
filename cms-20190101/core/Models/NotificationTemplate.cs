// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class NotificationTemplate : TeaModel {
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EnContent")]
        [Validation(Required=false)]
        public string EnContent { get; set; }

        [NameInMap("EnItemContent")]
        [Validation(Required=false)]
        public string EnItemContent { get; set; }

        [NameInMap("EnTitle")]
        [Validation(Required=false)]
        public string EnTitle { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        [NameInMap("WraperType")]
        [Validation(Required=false)]
        public string WraperType { get; set; }

        [NameInMap("ZhContent")]
        [Validation(Required=false)]
        public string ZhContent { get; set; }

        [NameInMap("ZhItemContent")]
        [Validation(Required=false)]
        public string ZhItemContent { get; set; }

        [NameInMap("ZhTitle")]
        [Validation(Required=false)]
        public string ZhTitle { get; set; }

    }

}
