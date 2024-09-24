// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ModifyHybridMonitorNamespaceRequest : TeaModel {
        /// <summary>
        /// <para>The description of the namespace.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the namespace.</para>
        /// <para>The name can contain letters, digits, and hyphens (-).</para>
        /// <para>For information about how to obtain the name of a namespace, see <a href="https://help.aliyun.com/document_detail/428880.html">DescribeHybridMonitorNamespaceList</a>.</para>
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
        /// <para>The data retention period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cms.s1.large: Data is stored for 15 days.</description></item>
        /// <item><description>cms.s1.xlarge: Data is stored for 32 days.</description></item>
        /// <item><description>cms.s1.2xlarge: Data is stored for 63 days.</description></item>
        /// <item><description>cms.s1.3xlarge: Data is stored for 93 days.</description></item>
        /// <item><description>cms.s1.6xlarge: Data is stored for 185 days.</description></item>
        /// <item><description>cms.s1.12xlarge: Data is stored for 376 days.</description></item>
        /// </list>
        /// <para>For information about the pricing for different retention periods, see the <b>Pricing</b> section in <a href="https://help.aliyun.com/document_detail/223532.html">Billing of the dashboard feature</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cms.s1.2xlarge</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
