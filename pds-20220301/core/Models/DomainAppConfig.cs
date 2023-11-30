// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class DomainAppConfig : TeaModel {
        [NameInMap("allow_upload_custom_file_ext_list")]
        [Validation(Required=false)]
        public List<string> AllowUploadCustomFileExtList { get; set; }

        [NameInMap("allow_upload_file_category_list")]
        [Validation(Required=false)]
        public List<string> AllowUploadFileCategoryList { get; set; }

        [NameInMap("same_name_file_upload_mode")]
        [Validation(Required=false)]
        public string SameNameFileUploadMode { get; set; }

        [NameInMap("single_file_upload_size_limit")]
        [Validation(Required=false)]
        public long? SingleFileUploadSizeLimit { get; set; }

        [NameInMap("web_client_download_mode")]
        [Validation(Required=false)]
        public string WebClientDownloadMode { get; set; }

    }

}
