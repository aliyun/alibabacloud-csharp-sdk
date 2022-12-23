// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SearchMediaRequest : TeaModel {
        /// <summary>
        /// The media asset fields to return in the query results.
        /// 
        /// By default, only the basic media asset fields are returned. You can specify additional media asset fields that need to be returned in the request. For more information, see the "API examples" section of the [Search for media asset information](~~99179~~) topic.
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public string Fields { get; set; }

        /// <summary>
        /// The filter condition. For more information about the syntax, see [Protocol for media asset search](~~86991~~).
        /// </summary>
        [NameInMap("Match")]
        [Validation(Required=false)]
        public string Match { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// 
        /// > If the value of this parameter exceeds **200**, we recommend that you set the ScrollToken parameter as well.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **10**. Maximum value: **100**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The pagination identifier. The identifier can be up to 32 characters in length.
        /// 
        /// The first time you call this operation for each new search, you do not need to specify this parameter. The value of this parameter is returned each time data records that meet the specified filter criteria are found. The value is used to record the current position of queried data. Record the returned parameter value and set this parameter according to the following requirements during the next search:
        /// 
        /// *   If SearchType is set to **video** or **audio** and you need to traverse all data that meets the filter criteria, you must set the ScrollToken parameter.
        /// *   If the value of the PageNo parameter exceeds **200**, we recommend that you set this parameter to optimize search performance.
        /// </summary>
        [NameInMap("ScrollToken")]
        [Validation(Required=false)]
        public string ScrollToken { get; set; }

        /// <summary>
        /// The type of the media asset that you want to query. Default value: video. Valid values:
        /// 
        /// *   **video**
        /// *   **audio**
        /// *   **image**
        /// *   **attached**
        /// 
        /// > If this parameter is set to **video** or **audio** and you want to traverse all data that meets the filter criteria, you must set the ScrollToken parameter.
        /// </summary>
        [NameInMap("SearchType")]
        [Validation(Required=false)]
        public string SearchType { get; set; }

        /// <summary>
        /// The sort field and order. Separate multiple values with commas (,). Default value: CreationTime:Desc. Valid values:
        /// 
        /// *   **CreationTime:Desc**: The results are sorted in reverse chronological order based on the creation time.
        /// *   **CreationTime:Asc**: The results are sorted in chronological order based on the creation time.
        /// 
        /// > * For more information about the sort field, see "Sort field" in the [Search for media asset information](~~99179~~) topic.
        /// > * To obtain the first 5,000 data records that meet the specified filter criteria, you can specify a maximum of three sort fields.
        /// > * To obtain all the data records that meet the specified filter criteria, you can specify only one sort field.
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

    }

}
