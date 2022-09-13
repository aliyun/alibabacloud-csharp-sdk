// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetVideoPreviewPlayInfoRequest : TeaModel {
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        [NameInMap("get_without_url")]
        [Validation(Required=false)]
        public string GetWithoutUrl { get; set; }

        [NameInMap("share_id")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        [NameInMap("template_id")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
