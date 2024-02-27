// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class ListApplicationRequest : TeaModel {
        /// <summary>
        /// Keywords in the app name
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The pagination size of the resulting value cannot be less than the minimum value of 1 and cannot be greater than the maximum value of 50.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination page number of the resulting value cannot be less than the minimum value of 1 and cannot be greater than the maximum value of 10000.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public int? NextToken { get; set; }

        /// <summary>
        /// 1 update time,<br>2 creation time
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public long? OrderType { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// Resource Id
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// The status of the applications to be returned.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// Template Id
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
