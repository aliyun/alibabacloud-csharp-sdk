// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ModifyHybridMonitorNamespaceRequest : TeaModel {
        /// <summary>
        /// <para>The description of the metric store.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud product metric repository.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the metric store.</para>
        /// <para>Format: consists of uppercase letters, lowercase letters, digits, and hyphens (-).</para>
        /// <para>For information about how to obtain the name of a metric store, see <a href="https://help.aliyun.com/document_detail/428880.html">DescribeHybridMonitorNamespaceList</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The data storage duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cms.s1.large: 15 days.</description></item>
        /// <item><description>cms.s1.xlarge: 32 days.</description></item>
        /// <item><description>cms.s1.2xlarge: 63 days.</description></item>
        /// <item><description>cms.s1.3xlarge: 93 days.</description></item>
        /// <item><description>cms.s1.6xlarge: 185 days.</description></item>
        /// <item><description>cms.s1.12xlarge: 376 days.</description></item>
        /// </list>
        /// <para>For the prices of different storage duration specifications, see the <b>Pricing</b> section in <a href="https://help.aliyun.com/document_detail/223532.html">Dashboard</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cms.s1.2xlarge</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
