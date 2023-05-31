// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class PageImageRegistryRequest : TeaModel {
        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 20.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The name of the image repository. Fuzzy match is supported.
        /// </summary>
        [NameInMap("RegistryNameLike")]
        [Validation(Required=false)]
        public string RegistryNameLike { get; set; }

        /// <summary>
        /// The types of image repositories.
        /// </summary>
        [NameInMap("RegistryTypeInList")]
        [Validation(Required=false)]
        public List<string> RegistryTypeInList { get; set; }

        /// <summary>
        /// The types of excluded image repositories.
        /// </summary>
        [NameInMap("RegistryTypeNotInList")]
        [Validation(Required=false)]
        public List<string> RegistryTypeNotInList { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
