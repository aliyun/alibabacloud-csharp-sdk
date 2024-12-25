// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class ListTLSCipherPoliciesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return the information about the associated listeners. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: returns the information about the associated listeners.</description></item>
        /// <item><description><b>false</b> (default): does not return the information about the associated listeners.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeListener")]
        [Validation(Required=false)]
        public bool? IncludeListener { get; set; }

        /// <summary>
        /// <para>The maximum number of TLS policies to be queried in this call. Valid values: <b>1</b> to <b>100</b>. If you do not set this parameter, the default value <b>20</b> is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxItems")]
        [Validation(Required=false)]
        public int? MaxItems { get; set; }

        /// <summary>
        /// <para>The name of the TLS policy. The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TLSPolicy-test****</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The token that is used for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If this is your first query or no next query is to be sent, ignore this parameter.</description></item>
        /// <item><description>If a next query is to be sent, set the value to the value of NextToken that is returned from the last call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the Classic Load Balancer (CLB) instance is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the TLS policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tls-bp17elso1h323r****</para>
        /// </summary>
        [NameInMap("TLSCipherPolicyId")]
        [Validation(Required=false)]
        public string TLSCipherPolicyId { get; set; }

    }

}
