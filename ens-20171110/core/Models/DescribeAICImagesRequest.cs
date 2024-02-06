// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeAICImagesRequest : TeaModel {
        /// <summary>
        /// The description of the image.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The image ID of the AIC instance.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The type of the image. Valid values:
        /// 
        /// *   **public**: public image
        /// *   **private**: custom image
        /// </summary>
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// The URL of the AIC image repository.
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the 2006-01-02 format. By default, the time range to query is not restricted.
        /// </summary>
        [NameInMap("MaxDate")]
        [Validation(Required=false)]
        public string MaxDate { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the 2006-01-02 format. By default, the time range to query is not restricted.
        /// </summary>
        [NameInMap("MinDate")]
        [Validation(Required=false)]
        public string MinDate { get; set; }

        /// <summary>
        /// The page number. Pages start from page **1**. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. The maximum value is **100**. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The status of the image. Valid values:
        /// 
        /// *   **verifying**
        /// *   **disable**
        /// *   **available**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
