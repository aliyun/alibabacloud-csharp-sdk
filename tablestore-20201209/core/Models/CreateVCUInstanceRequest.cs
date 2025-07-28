// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class CreateVCUInstanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>实例别名</para>
        /// </summary>
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewPeriodInMonth")]
        [Validation(Required=false)]
        public long? AutoRenewPeriodInMonth { get; set; }

        /// <summary>
        /// <para>cluster type</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SSD vs HYBRID</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("EnableAutoRenew")]
        [Validation(Required=false)]
        public bool? EnableAutoRenew { get; set; }

        [NameInMap("EnableElasticVCU")]
        [Validation(Required=false)]
        public bool? EnableElasticVCU { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>实例描述</para>
        /// </summary>
        [NameInMap("InstanceDescription")]
        [Validation(Required=false)]
        public string InstanceDescription { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PeriodInMonth")]
        [Validation(Required=false)]
        public long? PeriodInMonth { get; set; }

        /// <summary>
        /// <para>resource group id</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxh4em5jnbcd</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>tag</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateVCUInstanceRequestTags> Tags { get; set; }
        public class CreateVCUInstanceRequestTags : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>created</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
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
