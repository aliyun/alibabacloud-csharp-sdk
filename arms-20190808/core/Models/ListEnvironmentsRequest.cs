// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListEnvironmentsRequest : TeaModel {
        /// <summary>
        /// <para>The add-on name. You must specify at least one of the AddonName and EnvironmentType parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trace-java</para>
        /// </summary>
        [NameInMap("AddonName")]
        [Validation(Required=false)]
        public string AddonName { get; set; }

        /// <summary>
        /// <para>The ID of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cff30f0d67d7542dfb05bd114b4b1d7af</para>
        /// </summary>
        [NameInMap("BindResourceId")]
        [Validation(Required=false)]
        public string BindResourceId { get; set; }

        /// <summary>
        /// <para>The environment type. You must specify at least one of the AddonName and EnvironmentType parameters.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>CS</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <para>Container Service for Kubernetes (ACK)</para>
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>ECS</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <para>Elastic Compute Service (ECS)</para>
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Cloud</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <para>cloud service</para>
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CS</para>
        /// </summary>
        [NameInMap("EnvironmentType")]
        [Validation(Required=false)]
        public string EnvironmentType { get; set; }

        /// <summary>
        /// <para>The payable resource plan.</para>
        /// <list type="bullet">
        /// <item><description>If the EnvironmentType parameter is set to CS, set the value to CS_Basic or CS_Pro. Default value: CS_Basic.</description></item>
        /// <item><description>Otherwise, leave the parameter empty.</description></item>
        /// </list>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CS_Pro: Container Monitoring Pro</description></item>
        /// <item><description>CS_Basic: Container Monitoring Basic</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CS_Pro</para>
        /// </summary>
        [NameInMap("FeePackage")]
        [Validation(Required=false)]
        public string FeePackage { get; set; }

        /// <summary>
        /// <para>The region IDs to be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing,cn-hangzhou</para>
        /// </summary>
        [NameInMap("FilterRegionIds")]
        [Validation(Required=false)]
        public string FilterRegionIds { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzfurdatohtka</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListEnvironmentsRequestTag> Tag { get; set; }
        public class ListEnvironmentsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gfn_web_outbound_add</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
