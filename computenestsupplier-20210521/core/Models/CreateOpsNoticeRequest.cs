// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class CreateOpsNoticeRequest : TeaModel {
        /// <summary>
        /// <para>The properties of the O\&amp;M item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;cveId&quot;:&quot;CVE-2021-4034&quot;}</para>
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public Dictionary<string, object> Attributes { get; set; }

        /// <summary>
        /// <para>The category of the notice. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Availability</para>
        /// </description></item>
        /// <item><description><para>Cost</para>
        /// </description></item>
        /// <item><description><para>Performance</para>
        /// </description></item>
        /// <item><description><para>Recovery</para>
        /// </description></item>
        /// <item><description><para>Security</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Availability</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>A client token to ensure that the request is idempotent. Generate a unique token for each request. The token can contain only ASCII characters. Note: If you do not set this parameter, the system uses the RequestId as the ClientToken. The RequestId may be different for each request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10CM943JP0EN9D51H</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The content of the notice.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>content</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The service ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-0e6fca6a51a54420****</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The service versions to which the notice applies.</para>
        /// </summary>
        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public List<string> ServiceVersion { get; set; }

        /// <summary>
        /// <para>The severity level of the notice. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Critical</para>
        /// </description></item>
        /// <item><description><para>High</para>
        /// </description></item>
        /// <item><description><para>Medium</para>
        /// </description></item>
        /// <item><description><para>Low</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>High</para>
        /// </summary>
        [NameInMap("Severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The solution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You need to upgrade the service instance</para>
        /// </summary>
        [NameInMap("Solutions")]
        [Validation(Required=false)]
        public string Solutions { get; set; }

        /// <summary>
        /// <para>The type of the notice. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ServiceInstanceUpgrade: Upgrade</para>
        /// </description></item>
        /// <item><description><para>VulnerabilityFix: Vulnerability</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ServiceInstanceUpgrade</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
