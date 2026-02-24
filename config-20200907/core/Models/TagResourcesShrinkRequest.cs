// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class TagResourcesShrinkRequest : TeaModel {
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
        /// <para>The resource ID.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The type of the resource in CloudConfig. Valid values:</para>
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
        /// <para>You can attach a maximum of 20 tags.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string TagShrink { get; set; }

    }

}
