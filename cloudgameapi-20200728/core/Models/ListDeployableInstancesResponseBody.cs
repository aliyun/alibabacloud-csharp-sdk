// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class ListDeployableInstancesResponseBody : TeaModel {
        /// <summary>
        /// 数据列表
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<ListDeployableInstancesResponseBodyDataList> DataList { get; set; }
        public class ListDeployableInstancesResponseBodyDataList : TeaModel {
            /// <summary>
            /// 实例ID
            /// </summary>
            [NameInMap("CloudGameInstanceId")]
            [Validation(Required=false)]
            public string CloudGameInstanceId { get; set; }

            /// <summary>
            /// 实例名称
            /// </summary>
            [NameInMap("CloudGameInstanceName")]
            [Validation(Required=false)]
            public string CloudGameInstanceName { get; set; }

        }

        /// <summary>
        /// 表示当前调用返回读取到的位置，空代表数据已经读取完毕
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// MaxResults本次请求所返回的最大记录条数
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// TotalCount本次请求条件下的数据总量，此参数为可选参数，默认可不返回
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
