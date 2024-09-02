// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeDataCollctionResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the data collection task.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public DescribeDataCollctionResponseBodyResult Result { get; set; }
        public class DescribeDataCollctionResponseBodyResult : TeaModel {
            /// <summary>
            /// The time when the task was created.
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            /// <summary>
            /// The type of data collected. Valid values:
            /// 
            /// *   behavior: behavioral data.
            /// *   item_info: project information.
            /// *   industry_specific: industry-specific data.
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
            /// The industry name. Valid values:
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
            /// The status of the data collection feature. Valid values:
            /// 
            /// *   0: The feature is disabled.
            /// *   1: The feature is being enabled.
            /// *   2: The feature is enabled.
            /// *   3: The feature failed to be enabled.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The sundial ID.
            /// </summary>
            [NameInMap("sundialId")]
            [Validation(Required=false)]
            public string SundialId { get; set; }

            /// <summary>
            /// The type of the source from which data was collected. Valid values:
            /// 
            /// *   server
            /// *   web
            /// *   app Note: Only server is supported.
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

    }

}
