// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class BindAuthToMachineRequest : TeaModel {
        /// <summary>
        /// <para>The region ID of the Smart Access Gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The Security Center SDK request.</para>
        /// </summary>
        [NameInMap("SdkRequest")]
        [Validation(Required=false)]
        public BindAuthToMachineRequestSdkRequest SdkRequest { get; set; }
        public class BindAuthToMachineRequestSdkRequest : TeaModel {
            /// <summary>
            /// <para>The authorization version of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>6</b>: Anti-virus Edition</description></item>
            /// <item><description><b>5</b>: Advanced Edition</description></item>
            /// <item><description><b>3</b>: Enterprise Edition</description></item>
            /// <item><description><b>7</b>: Ultimate Edition</description></item>
            /// <item><description><b>10</b>: Value-added Service Edition</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AuthVersion")]
            [Validation(Required=false)]
            public int? AuthVersion { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable automatic binding. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoBind")]
            [Validation(Required=false)]
            public int? AutoBind { get; set; }

            /// <summary>
            /// <para>The collection of UUIDs to bind.</para>
            /// <remarks>
            /// <para>Bind and UnBind cannot both be empty.
            /// Maximum number of child entries: 1000.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Bind")]
            [Validation(Required=false)]
            public List<string> Bind { get; set; }

            /// <summary>
            /// <para>Specifies whether to bind all assets. Default value: <b>false</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BindAll")]
            [Validation(Required=false)]
            public bool? BindAll { get; set; }

            /// <summary>
            /// <para>The search conditions for assets. This parameter is in JSON format. Pay attention to the letter case when you specify this parameter.</para>
            /// <remarks>
            /// <para>You can search for assets by instance ID, instance name, VPC ID, region, public IP address, and other conditions. You can call the DescribeCriteria operation to query the supported search conditions.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;name\&quot;:\&quot;clientStatus\&quot;,\&quot;value\&quot;:\&quot;online\&quot;},{\&quot;name\&quot;:\&quot;authVersion\&quot;,\&quot;value\&quot;:\&quot;1\&quot;}]</para>
            /// </summary>
            [NameInMap("Criteria")]
            [Validation(Required=false)]
            public string Criteria { get; set; }

            /// <summary>
            /// <para>Specifies whether this is a pre-binding operation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: no</description></item>
            /// <item><description><b>1</b>: yes</description></item>
            /// </list>
            /// <remarks>
            /// <para>After pre-binding is enabled, the corresponding authorization quota is automatically bound to the specified servers after the purchase is completed.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsPreBind")]
            [Validation(Required=false)]
            public int? IsPreBind { get; set; }

            /// <summary>
            /// <para>The logical relationship between multiple search conditions. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>OR</b>: The search conditions are in an <b>OR</b> relationship.</description></item>
            /// <item><description><b>AND</b>: The search conditions are in an <b>AND</b> relationship.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AND</para>
            /// </summary>
            [NameInMap("LogicalExp")]
            [Validation(Required=false)]
            public string LogicalExp { get; set; }

            /// <summary>
            /// <para>The order version associated with the pre-binding. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>level7</b>: Anti-virus Edition</description></item>
            /// <item><description><b>level3</b>: Advanced Edition</description></item>
            /// <item><description><b>level2</b>: Enterprise Edition</description></item>
            /// <item><description><b>level8</b>: Ultimate Edition</description></item>
            /// <item><description><b>level10</b>: value-added service only</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>level2</para>
            /// </summary>
            [NameInMap("NtmVersion")]
            [Validation(Required=false)]
            public long? NtmVersion { get; set; }

            /// <summary>
            /// <para>The order ID associated with the pre-binding.</para>
            /// <remarks>
            /// <para>Note: This field is of the Long type. Precision loss may occur during the sequence/deserialization procedure. The value must not exceed 9007199254740991.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>263076506250432</para>
            /// </summary>
            [NameInMap("PreBindOrderId")]
            [Validation(Required=false)]
            public long? PreBindOrderId { get; set; }

            /// <summary>
            /// <para>The collection of UUIDs to unbind.</para>
            /// <remarks>
            /// <para><b>Bind</b> and <b>UnBind</b> cannot both be empty.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("UnBind")]
            [Validation(Required=false)]
            public List<string> UnBind { get; set; }

        }

    }

}
