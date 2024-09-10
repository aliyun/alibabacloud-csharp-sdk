// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorGroupCategoriesResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The cloud services to which the resources in the application group belong and the number of resources that belong to the cloud service.
        /// </summary>
        [NameInMap("MonitorGroupCategories")]
        [Validation(Required=false)]
        public DescribeMonitorGroupCategoriesResponseBodyMonitorGroupCategories MonitorGroupCategories { get; set; }
        public class DescribeMonitorGroupCategoriesResponseBodyMonitorGroupCategories : TeaModel {
            /// <summary>
            /// The ID of the application group.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// The cloud services to which the resources in the application group belong and the number of resources that belong to the cloud service.
            /// </summary>
            [NameInMap("MonitorGroupCategory")]
            [Validation(Required=false)]
            public DescribeMonitorGroupCategoriesResponseBodyMonitorGroupCategoriesMonitorGroupCategory MonitorGroupCategory { get; set; }
            public class DescribeMonitorGroupCategoriesResponseBodyMonitorGroupCategoriesMonitorGroupCategory : TeaModel {
                [NameInMap("CategoryItem")]
                [Validation(Required=false)]
                public List<DescribeMonitorGroupCategoriesResponseBodyMonitorGroupCategoriesMonitorGroupCategoryCategoryItem> CategoryItem { get; set; }
                public class DescribeMonitorGroupCategoriesResponseBodyMonitorGroupCategoriesMonitorGroupCategoryCategoryItem : TeaModel {
                    /// <summary>
                    /// The abbreviation of the cloud service name.
                    /// 
                    /// >  For more information about how to obtain the abbreviation of a cloud service name, see `metricCategory` in the response parameter `Labels` of the [DescribeProjectMeta](https://help.aliyun.com/document_detail/114916.html) operation.
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// The number of resources that belong to the cloud service.
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true: The request was successful.
        /// *   false: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
