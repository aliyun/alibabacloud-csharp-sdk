// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListFunctionInstancesRequest : TeaModel {
        /// <summary>
        /// The type of the feature.
        /// </summary>
        [NameInMap("functionType")]
        [Validation(Required=false)]
        public string FunctionType { get; set; }

        /// <summary>
        /// The type of the model.
        /// </summary>
        [NameInMap("modelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// The richness of the returned information. Valid values:
        /// 
        /// *   normal: displays information such as createParameters and cron. This is the default value.
        /// *   simple: displays only the basic information.
        /// *   detail: returns the details of the training task.
        /// </summary>
        [NameInMap("output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: 1.
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 10.
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// How the instance is created. Valid values:
        /// 
        /// *   builtin: The instance is created by system.
        /// *   user: The instance is created by user. This is the default value.
        /// *   all: all instances
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
