// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class Quota : TeaModel {
        /// <summary>
        /// 集群id
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// 是否允许使用潮汐资源
        /// </summary>
        [NameInMap("EnableTideResource")]
        [Validation(Required=false)]
        public bool? EnableTideResource { get; set; }

        /// <summary>
        /// 是否是独占Quota组
        /// </summary>
        [NameInMap("IsExclusiveQuota")]
        [Validation(Required=false)]
        public bool? IsExclusiveQuota { get; set; }

        /// <summary>
        /// 资源配额id
        /// </summary>
        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// 资源配额名称
        /// </summary>
        [NameInMap("QuotaName")]
        [Validation(Required=false)]
        public string QuotaName { get; set; }

        /// <summary>
        /// 资源配额类型
        /// </summary>
        [NameInMap("QuotaType")]
        [Validation(Required=false)]
        public string QuotaType { get; set; }

        /// <summary>
        /// 资源组允许使用的潮汐资源级别
        /// </summary>
        [NameInMap("ResourceLevel")]
        [Validation(Required=false)]
        public string ResourceLevel { get; set; }

        /// <summary>
        /// 资源总量
        /// </summary>
        [NameInMap("TotalQuota")]
        [Validation(Required=false)]
        public QuotaDetail TotalQuota { get; set; }

        /// <summary>
        /// 潮汐资源总量
        /// </summary>
        [NameInMap("TotalTideQuota")]
        [Validation(Required=false)]
        public QuotaDetail TotalTideQuota { get; set; }

        /// <summary>
        /// 资源用量
        /// </summary>
        [NameInMap("UsedQuota")]
        [Validation(Required=false)]
        public QuotaDetail UsedQuota { get; set; }

        /// <summary>
        /// 潮汐资源用量
        /// </summary>
        [NameInMap("UsedTideQuota")]
        [Validation(Required=false)]
        public QuotaDetail UsedTideQuota { get; set; }

    }

}
