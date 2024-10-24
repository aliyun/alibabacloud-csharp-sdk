// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class Quota : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("QuotaConfig")]
        [Validation(Required=false)]
        public QuotaConfig QuotaConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>quotamtl37ge7gkvdz</para>
        /// </summary>
        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dlc-quota</para>
        /// </summary>
        [NameInMap("QuotaName")]
        [Validation(Required=false)]
        public string QuotaName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>asiquota</para>
        /// </summary>
        [NameInMap("QuotaType")]
        [Validation(Required=false)]
        public string QuotaType { get; set; }

        [NameInMap("TotalQuota")]
        [Validation(Required=false)]
        public QuotaDetail TotalQuota { get; set; }

        [NameInMap("TotalTideQuota")]
        [Validation(Required=false)]
        public QuotaDetail TotalTideQuota { get; set; }

        [NameInMap("UsedQuota")]
        [Validation(Required=false)]
        public QuotaDetail UsedQuota { get; set; }

        [NameInMap("UsedTideQuota")]
        [Validation(Required=false)]
        public QuotaDetail UsedTideQuota { get; set; }

    }

}
