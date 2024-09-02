// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListDataCollectionsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the data collection tasks.
        /// 
        /// For more information, see [DataCollection](https://help.aliyun.com/document_detail/173605.html).
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListDataCollectionsResponseBodyResult> Result { get; set; }
        public class ListDataCollectionsResponseBodyResult : TeaModel {
            /// <summary>
            /// The time when the data collection task was created.
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            /// <summary>
            /// The type of the data that is collected by the task. Valid values:
            /// 
            /// *   behavior: behavioral data
            /// *   item_info: project data
            /// *   industry_specific: industry-specific data
            /// </summary>
            [NameInMap("dataCollectionType")]
            [Validation(Required=false)]
            public string DataCollectionType { get; set; }

            /// <summary>
            /// The ID of the data collection task.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The industry to which the data collection task applies. Valid values:
            /// 
            /// *   general
            /// *   ecommerce
            /// </summary>
            [NameInMap("industryName")]
            [Validation(Required=false)]
            public string IndustryName { get; set; }

            /// <summary>
            /// The name of the data collection task.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The status of the data collection task. Valid values:
            /// 
            /// *   0: disabled
            /// *   1: being enabled
            /// *   2: enabled
            /// *   3: failed to be enabled
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The ID of the sundial.
            /// </summary>
            [NameInMap("sundialId")]
            [Validation(Required=false)]
            public string SundialId { get; set; }

            /// <summary>
            /// The type of the data source. Valid values:
            /// 
            /// *   server
            /// *   web
            /// *   app
            /// 
            /// Note: Only server is supported.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The time when the data collection task was updated.
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

        }

        /// <summary>
        /// The total number of the returned data collection tasks.
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
