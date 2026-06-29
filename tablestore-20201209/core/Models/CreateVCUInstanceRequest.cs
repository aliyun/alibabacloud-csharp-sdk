// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class CreateVCUInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The alias of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// <para>The auto-renewal cycle. This parameter is required if auto-renewal is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewPeriodInMonth")]
        [Validation(Required=false)]
        public long? AutoRenewPeriodInMonth { get; set; }

        /// <summary>
        /// <para>The cluster type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SSD vs HYBRID</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. If you perform a dry run, no instance is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal.</para>
        /// </summary>
        [NameInMap("EnableAutoRenew")]
        [Validation(Required=false)]
        public bool? EnableAutoRenew { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable instance elasticity. If you enable instance elasticity, the peak VCU usage can exceed the purchased VCU amount, but additional fees are incurred.</para>
        /// </summary>
        [NameInMap("EnableElasticVCU")]
        [Validation(Required=false)]
        public bool? EnableElasticVCU { get; set; }

        /// <summary>
        /// <para>The description of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testvcu</para>
        /// </summary>
        [NameInMap("InstanceDescription")]
        [Validation(Required=false)]
        public string InstanceDescription { get; set; }

        /// <summary>
        /// <para>The subscription duration. Unit: month.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PeriodInMonth")]
        [Validation(Required=false)]
        public long? PeriodInMonth { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxh4em5jnbcd</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateVCUInstanceRequestTags> Tags { get; set; }
        public class CreateVCUInstanceRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of the tag. The key can be up to 64 characters in length.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>created</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag. The value can be up to 64 characters in length.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0woauavextilfqr61</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The instance type: the number of VCUs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VCU")]
        [Validation(Required=false)]
        public long? VCU { get; set; }

    }

}
