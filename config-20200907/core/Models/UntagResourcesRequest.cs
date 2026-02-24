// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to detach all tags from the resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Detach all tags from the resources.</para>
        /// </description></item>
        /// <item><description><para>false (default): Detach the specified tags.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IDs of the resources. You can specify a maximum of 50 resource IDs.</para>
        /// <para>You can detach tags from up to 50 resources at a time.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The type of the CloudConfig resource. Valid values:</para>
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
        /// <para>The tag keys of the tags to detach.</para>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
