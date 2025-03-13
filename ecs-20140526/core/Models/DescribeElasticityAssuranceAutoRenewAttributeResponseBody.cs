// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeElasticityAssuranceAutoRenewAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The auto-renewal attribute of the elasticity assurances.</para>
        /// </summary>
        [NameInMap("ElasticityAssuranceRenewAttributes")]
        [Validation(Required=false)]
        public DescribeElasticityAssuranceAutoRenewAttributeResponseBodyElasticityAssuranceRenewAttributes ElasticityAssuranceRenewAttributes { get; set; }
        public class DescribeElasticityAssuranceAutoRenewAttributeResponseBodyElasticityAssuranceRenewAttributes : TeaModel {
            [NameInMap("ElasticityAssuranceRenewAttribute")]
            [Validation(Required=false)]
            public List<DescribeElasticityAssuranceAutoRenewAttributeResponseBodyElasticityAssuranceRenewAttributesElasticityAssuranceRenewAttribute> ElasticityAssuranceRenewAttribute { get; set; }
            public class DescribeElasticityAssuranceAutoRenewAttributeResponseBodyElasticityAssuranceRenewAttributesElasticityAssuranceRenewAttribute : TeaModel {
                /// <summary>
                /// <para>The auto-renewal period. Valid values: Valid values: 1, 2, 3, 6, 12, 24, and 36.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public int? Period { get; set; }

                /// <summary>
                /// <para>The unit of the auto-renewal period. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Month (default)</description></item>
                /// <item><description>Year</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Month</para>
                /// </summary>
                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                /// <summary>
                /// <para>The ID of the elasticity assurance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eap-bp67acfmxazb4****</para>
                /// </summary>
                [NameInMap("PrivatePoolOptionsId")]
                [Validation(Required=false)]
                public string PrivatePoolOptionsId { get; set; }

                /// <summary>
                /// <para>Indicates whether auto-renewal is enabled for the elasticity assurance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AutoRenewal: Auto-renewal is enabled for the elasticity assurance.</description></item>
                /// <item><description>Normal: Auto-renewal is disabled for the elasticity assurance.</description></item>
                /// <item><description>NotRenewal: The elasticity assurance is not renewed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("RenewalStatus")]
                [Validation(Required=false)]
                public string RenewalStatus { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
