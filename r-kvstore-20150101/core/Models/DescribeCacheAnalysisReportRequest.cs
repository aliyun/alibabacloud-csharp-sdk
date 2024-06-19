// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeCacheAnalysisReportRequest : TeaModel {
        /// <summary>
        /// The type of analytics. Set the value to **BigKey**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AnalysisType")]
        [Validation(Required=false)]
        public string AnalysisType { get; set; }

        /// <summary>
        /// The date to query. You can query the report for one day each time. Specify the date in the *yyyy-MM-dd*Z format. The time must be in UTC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the child node in the cluster instance.
        /// 
        /// > If this parameter is not specified, the analytics results of all child nodes in the instance are returned.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// > If the parameter value exceeds the maximum number of the returned pages, an empty large key list is returned.
        /// </summary>
        [NameInMap("PageNumbers")]
        [Validation(Required=false)]
        public int? PageNumbers { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: **30**, **50**, and **100**.
        /// 
        /// > The default value is **30**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
