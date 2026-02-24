// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The token to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTRBMDc0NjAtRUJFNy00N0NBLTk3NTctMTJ****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the tags belong.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// <para>You can query tags for a maximum of 50 resources.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type in CloudConfig. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ACS::Config::Rule</c>: a rule for a single account.</para>
        /// </description></item>
        /// <item><description><para><c>ACS::Config::AggregateConfigRule</c>: a rule for multiple accounts.</para>
        /// </description></item>
        /// <item><description><para><c>ACS::Config::Aggregator</c>: an account group.</para>
        /// </description></item>
        /// <item><description><para><c>ACS::Config::CompliancePack</c>: a compliance package for a single account.</para>
        /// </description></item>
        /// <item><description><para><c>ACS::Config::AggregateCompliancePack</c>: a compliance package for multiple accounts.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::Config::Rule</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tags of the resource.</para>
        /// <para>You can filter resources by a maximum of 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// <para>You can specify a maximum of 20 tag keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource.</para>
            /// <para>You can specify a maximum of 20 tag values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
