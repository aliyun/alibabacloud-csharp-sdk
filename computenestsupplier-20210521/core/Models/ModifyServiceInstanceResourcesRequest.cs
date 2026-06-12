// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ModifyServiceInstanceResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The resources to import.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;RegionId&quot;: &quot;cn-hangzhou&quot;,
        ///   &quot;Type&quot;: &quot;ResourceIds&quot;,
        ///   &quot;ResourceIds&quot;: {
        ///     &quot;ALIYUN::ECS::INSTANCE&quot;: [&quot;i-xxx&quot;, &quot;i-yyy&quot;],
        ///     &quot;ALIYUN::RDS::INSTANCE&quot;: [&quot;rm-xxx&quot;, &quot;rm-yyy&quot;],
        ///     &quot;ALIYUN::VPC::VPC&quot;: [&quot;vpc-xxx&quot;, &quot;vpc-yyy&quot;],
        ///     &quot;ALIYUN::SLB::INSTANCE&quot;: [&quot;lb-xxx&quot;, &quot;lb-yyy&quot;]
        ///   }
        /// }</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

        /// <summary>
        /// <para>The ID of the service instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-d8a0cc2a1ee04dce****</para>
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

        /// <summary>
        /// <para>The operation to perform on the resources of the service instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Import: Imports resources.</para>
        /// </description></item>
        /// <item><description><para>UnImport: Removes imported resources.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Import</para>
        /// </summary>
        [NameInMap("ServiceInstanceResourcesAction")]
        [Validation(Required=false)]
        public string ServiceInstanceResourcesAction { get; set; }

    }

}
