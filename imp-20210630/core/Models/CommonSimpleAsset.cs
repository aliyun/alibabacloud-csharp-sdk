// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class CommonSimpleAsset : TeaModel {
        [NameInMap("Address")]
        [Validation(Required=false)]
        public CommonAddress Address { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AuditStatus")]
        [Validation(Required=false)]
        public string AuditStatus { get; set; }

        [NameInMap("Author")]
        [Validation(Required=false)]
        public string Author { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Extends")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extends { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Image")]
        [Validation(Required=false)]
        public CommonMediaResource Image { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public Dictionary<string, object> Labels { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public TypeLatLng Location { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Synopsis")]
        [Validation(Required=false)]
        public string Synopsis { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("Video")]
        [Validation(Required=false)]
        public CommonMediaResource Video { get; set; }

    }

}
