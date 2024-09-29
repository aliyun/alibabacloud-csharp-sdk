// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class InstallCmsExporterRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc7a37ee31aea4ed1a059eff8034b****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The cloud services that you want to monitor. The CmsArgs parameter is the startup parameter of the cms-exporter collector. Separate multiple cloud services with number signs (<c>#</c>).</para>
        /// 
        /// <b>Example:</b>
        /// <para>hologres#cen</para>
        /// </summary>
        [NameInMap("CmsArgs")]
        [Validation(Required=false)]
        public string CmsArgs { get; set; }

        /// <summary>
        /// <para>The recently monitored cloud services. Separate multiple cloud services with number signs (<c>#</c>).</para>
        /// 
        /// <b>Example:</b>
        /// <para>hologres#cen</para>
        /// </summary>
        [NameInMap("DirectArgs")]
        [Validation(Required=false)]
        public string DirectArgs { get; set; }

        /// <summary>
        /// <para>Specifies whether to collect the aliyun tags attached to each cloud service. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableTag")]
        [Validation(Required=false)]
        public bool? EnableTag { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
