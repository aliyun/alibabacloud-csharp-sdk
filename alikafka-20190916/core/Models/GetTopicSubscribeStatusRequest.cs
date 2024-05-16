// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetTopicSubscribeStatusRequest : TeaModel {
        /// <summary>
        /// The instance ID.
        /// 
        /// You can call the [GetInstanceList](https://help.aliyun.com/document_detail/437663.html) operation to query instances.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The topic name.
        /// 
        /// You can call the [GetTopicList](https://help.aliyun.com/document_detail/437677.html) operation to query topics.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
