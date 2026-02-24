// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateDiscoveredResourceRequest : TeaModel {
        /// <summary>
        /// <para>The account group ID.</para>
        /// <para>For more information about how to obtain the account group ID, see <a href="https://help.aliyun.com/document_detail/255797.html">ListAggregators</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-5885626622af0008****</para>
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the compliance results of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0 (default): does not query the compliance results of the resource.</para>
        /// </description></item>
        /// <item><description><para>1: queries the compliance results of the resource.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ComplianceOption")]
        [Validation(Required=false)]
        public int? ComplianceOption { get; set; }

        /// <summary>
        /// <para>The region ID of the resource.</para>
        /// <para>For more information about how to obtain the region ID of the resource, see <a href="https://help.aliyun.com/document_detail/411691.html">ListAggregateDiscoveredResources</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>Required. The ID of the Alibaba Cloud account to which the resource to be queried belongs in the account group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100931896542****</para>
        /// </summary>
        [NameInMap("ResourceAccountId")]
        [Validation(Required=false)]
        public long? ResourceAccountId { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// <para>For more information about how to obtain the resource ID, see <a href="https://help.aliyun.com/document_detail/411691.html">ListAggregateDiscoveredResources</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp12g4xbl4i0brkn****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        [Obsolete]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// <para>For more information about how to obtain the resource type, see <a href="https://help.aliyun.com/document_detail/411691.html">ListAggregateDiscoveredResources</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::ECS::Instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
