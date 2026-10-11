// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class ListEgressProxyConfigurationsRequest : TeaModel {
        /// <summary>
        /// <para>The list of egress proxy configuration IDs.</para>
        /// </summary>
        [NameInMap("EgressProxyConfigurationIds")]
        [Validation(Required=false)]
        public List<string> EgressProxyConfigurationIds { get; set; }

        /// <summary>
        /// <para>The list of egress proxy configuration names.</para>
        /// </summary>
        [NameInMap("EgressProxyConfigurationNames")]
        [Validation(Required=false)]
        public List<string> EgressProxyConfigurationNames { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return per page during paging in a paged query. Valid values: 0 to 1000. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Leave this parameter empty for the first query or when no next query is required.</description></item>
        /// <item><description>If a next query is required, set this parameter to the value of NextToken returned from the previous API call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm4jcyx5e****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The number of entries to skip during paging in a paged query. The value must be greater than or equal to 0. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Skip")]
        [Validation(Required=false)]
        public int? Skip { get; set; }

        /// <summary>
        /// <para>Filters egress proxy configurations by status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Provisioning</b>: The egress proxy configuration is being created.</para>
        /// </description></item>
        /// <item><description><para><b>Available</b>: The egress proxy configuration is available.</para>
        /// </description></item>
        /// <item><description><para><b>Configuring</b>: The specifications of the egress proxy configuration are being changed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListEgressProxyConfigurationsRequestTag> Tag { get; set; }
        public class ListEgressProxyConfigurationsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The value can be up to 256 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
