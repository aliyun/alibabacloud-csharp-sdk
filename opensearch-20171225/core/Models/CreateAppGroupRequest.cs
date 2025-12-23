// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateAppGroupRequest : TeaModel {
        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>POSTPAY: pay-as-you-go</description></item>
        /// <item><description>PREPAY: subscription</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("chargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The name of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jmbon_analyzer</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The quota.</para>
        /// </summary>
        [NameInMap("quota")]
        [Validation(Required=false)]
        public CreateAppGroupRequestQuota Quota { get; set; }
        public class CreateAppGroupRequestQuota : TeaModel {
            /// <summary>
            /// <para>The computing resources. Unit: logical computing unit (LCU).</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("computeResource")]
            [Validation(Required=false)]
            public int? ComputeResource { get; set; }

            /// <summary>
            /// <para>The storage capacity. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("docSize")]
            [Validation(Required=false)]
            public int? DocSize { get; set; }

            /// <summary>
            /// <para>The specifications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>opensearch.share.junior: basic</description></item>
            /// <item><description>opensearch.share.common: shared general-purpose</description></item>
            /// <item><description>opensearch.share.compute: shared computing</description></item>
            /// <item><description>opensearch.share.storage: shared storage</description></item>
            /// <item><description>opensearch.private.common: exclusive general-purpose</description></item>
            /// <item><description>opensearch.private.compute: exclusive computing</description></item>
            /// <item><description>opensearch.private.storage: exclusive storage</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>opensearch.share.common</para>
            /// </summary>
            [NameInMap("spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

        }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2ij6pwxsvua</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<CreateAppGroupRequestTags> Tags { get; set; }
        public class CreateAppGroupRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The type of the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>standard</description></item>
        /// <item><description>enhanced</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enhanced</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
