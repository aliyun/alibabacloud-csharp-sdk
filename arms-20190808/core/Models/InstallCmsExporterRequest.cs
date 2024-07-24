// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class InstallCmsExporterRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The cloud services that you want to monitor. The CmsArgs parameter is the startup parameter of the cms-exporter collector. Separate multiple cloud services with number signs (`#`).
        /// </summary>
        [NameInMap("CmsArgs")]
        [Validation(Required=false)]
        public string CmsArgs { get; set; }

        /// <summary>
        /// The recently monitored cloud services. Separate multiple cloud services with number signs (`#`).
        /// </summary>
        [NameInMap("DirectArgs")]
        [Validation(Required=false)]
        public string DirectArgs { get; set; }

        /// <summary>
        /// Specifies whether to collect the aliyun tags attached to each cloud service. Default value: false.
        /// </summary>
        [NameInMap("EnableTag")]
        [Validation(Required=false)]
        public bool? EnableTag { get; set; }

        /// <summary>
        /// The ID of the region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
