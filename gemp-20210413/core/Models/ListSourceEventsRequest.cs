// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListSourceEventsRequest : TeaModel {
        /// <summary>
        /// 报警或者事件ID
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// INCIDENT 事件、ALERT 报警、PROBLEM 故障
        /// </summary>
        [NameInMap("instanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// startRowKey 用来查询下一页的数据
        /// </summary>
        [NameInMap("startRowKey")]
        [Validation(Required=false)]
        public string StartRowKey { get; set; }

        /// <summary>
        /// stopRowKey 用来查询上一页的数据
        /// </summary>
        [NameInMap("stopRowKey")]
        [Validation(Required=false)]
        public string StopRowKey { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// 幂等号
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

    }

}
