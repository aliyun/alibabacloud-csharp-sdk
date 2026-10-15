// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class BindAppDomainRequest : TeaModel {
        /// <summary>
        /// <para>The business ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250820143531000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The domain hosting method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CUSTOMER_ESA: Uses the customer\&quot;s own Edge Security Acceleration (ESA). Only supported when DomainType is set to CUSTOM.</description></item>
        /// </list>
        /// <para>If this parameter is not specified, the original hosting process is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CDN</para>
        /// </summary>
        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public string DeployType { get; set; }

        /// <summary>
        /// <para>The domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xiaoniu.link</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The domain management type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CUSTOM</description></item>
        /// <item><description>PLATFORM_PREFIX</description></item>
        /// </list>
        /// <para>Default value: CUSTOM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CUSTOM</para>
        /// </summary>
        [NameInMap("DomainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        /// <summary>
        /// <para>The extended information (OverwriteExistingRecord).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;deliveryNodeName\&quot;:\&quot;Website acceptance\&quot;,\&quot;deliveryNodeStatus\&quot;:\&quot;Reject\&quot;,\&quot;deliveryOperatorRole\&quot;:\&quot;Customer\&quot;}</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <para>The operation type for domain binding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vul_fix</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

    }

}
