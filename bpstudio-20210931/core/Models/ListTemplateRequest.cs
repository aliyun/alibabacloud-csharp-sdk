// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class ListTemplateRequest : TeaModel {
        /// <summary>
        /// The keyword that is used to search for templates.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public int? NextToken { get; set; }

        /// <summary>
        /// The criterion by which the returned templates are sorted. Valid values:
        /// 
        /// *   1: The templates are sorted by the time when they are updated.
        /// *   2: The templates are sorted by the time when they are created.
        /// *   3: The templates are sorted by the system.
        /// *   4: The templates are sorted by the number of times that they are used.
        /// *   If you specify an integer other than 1, 2, 3, and 4 or do not specify any value, the templates are sorted by the system.
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
        /// The tag that you want to use to query templates.
        /// </summary>
        [NameInMap("TagList")]
        [Validation(Required=false)]
        public int? TagList { get; set; }

        /// <summary>
        /// The type of the templates to be returned. Valid values: public and private
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
