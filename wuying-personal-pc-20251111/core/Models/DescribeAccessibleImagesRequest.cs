// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wuying_personal_pc20251111.Models
{
    public class DescribeAccessibleImagesRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        [NameInMap("BizSource")]
        [Validation(Required=false)]
        public string BizSource { get; set; }

        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        [NameInMap("DesktopType")]
        [Validation(Required=false)]
        public string DesktopType { get; set; }

        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
