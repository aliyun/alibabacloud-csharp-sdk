// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateARMServerInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The number of instances to create. Minimum value: <b>1</b>. Maximum value: <b>100</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>Specifies whether to use coupons. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The IPv4 CIDR block used by the instance, in CIDR notation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/24</para>
        /// </summary>
        [NameInMap("Cidr")]
        [Validation(Required=false)]
        public string Cidr { get; set; }

        /// <summary>
        /// <para>The ENS edge zone ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-guiyang-12</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>One or more environment variables to set during EAIS instance initialization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[object Object]</para>
        /// </summary>
        [NameInMap("EnvironmentVar")]
        [Validation(Required=false)]
        public string EnvironmentVar { get; set; }

        /// <summary>
        /// <para>The refresh rate, in Hz. Valid values: 30 and 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public int? Frequency { get; set; }

        /// <summary>
        /// <para>The image ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourImage ID</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The instance billing cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Hour</description></item>
        /// <item><description>Day</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Hour</para>
        /// </summary>
        [NameInMap("InstanceBillingCycle")]
        [Validation(Required=false)]
        public string InstanceBillingCycle { get; set; }

        /// <summary>
        /// <para>The instance type of the AIC container instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>aic.cf52r.c1.np</para>
        /// </description></item>
        /// <item><description><para>aic.cf52r.c2.np</para>
        /// </description></item>
        /// <item><description><para>aic.cf53r.c2.np</para>
        /// </description></item>
        /// <item><description><para>aic.cf52r.c4.np</para>
        /// </description></item>
        /// <item><description><para>aic.cf53r.c3.np</para>
        /// </description></item>
        /// <item><description><para>aic.cf52r.c3.np</para>
        /// </description></item>
        /// <item><description><para>aic.cf53r.c1.np</para>
        /// </description></item>
        /// <item><description><para>aic.cf53r.c5.np</para>
        /// </description></item>
        /// <item><description><para>aic.cf53r.c6</para>
        /// </description></item>
        /// <item><description><para>aic.cf53r.c4.np</para>
        /// </description></item>
        /// <item><description><para>aic.cf53r.c6.np</para>
        /// </description></item>
        /// <item><description><para>aic.cf53r.c7.np</para>
        /// </description></item>
        /// <item><description><para>aic.cf52m1r.c5.np</para>
        /// </description></item>
        /// <item><description><para>aic.cf53r.c8.np</para>
        /// </description></item>
        /// <item><description><para>aic.cf53r.c7</para>
        /// </description></item>
        /// <item><description><para>aic.cf52m1r.c2.np</para>
        /// </description></item>
        /// <item><description><para>aic.cf52m1r.c1.np</para>
        /// </description></item>
        /// <item><description><para>aic.cf52m1r.c3.np</para>
        /// </description></item>
        /// <item><description><para>aic.cf52m1r.c4.np</para>
        /// </description></item>
        /// <item><description><para>aic.cf52m1r.c6</para>
        /// </description></item>
        /// <item><description><para>ens.a6c2</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aic.cf53r.c6.np</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The key pair name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestKeyPairName</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pre</para>
        /// </summary>
        [NameInMap("NameSpace")]
        [Validation(Required=false)]
        public string NameSpace { get; set; }

        /// <summary>
        /// <para>The billing type. Valid values: <b>PrePaid</b> (subscription).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The duration for which you want to purchase the resource.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify PeriodUnit, the resource is purchased on a monthly basis by default. Currently, only Days and Month are supported.</description></item>
        /// <item><description>If PeriodUnit is set to Day, Period can only be set to 3.</description></item>
        /// <item><description>If PeriodUnit is set to Month, Period can be set to 1 to 9 or 12.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the purchase duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The resolution. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>1920*864</para>
        /// </description></item>
        /// <item><description><para>1080*1920</para>
        /// </description></item>
        /// <item><description><para>1920*1080</para>
        /// </description></item>
        /// <item><description><para>720*1280</para>
        /// </description></item>
        /// <item><description><para>2400*1080</para>
        /// </description></item>
        /// <item><description><para>1080*2400</para>
        /// </description></item>
        /// <item><description><para>1280*720</para>
        /// </description></item>
        /// <item><description><para>864*1920</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>720*1280</para>
        /// </summary>
        [NameInMap("Resolution")]
        [Validation(Required=false)]
        public string Resolution { get; set; }

        /// <summary>
        /// <para>The service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AIC-Server</para>
        /// </summary>
        [NameInMap("ServerName")]
        [Validation(Required=false)]
        public string ServerName { get; set; }

        /// <summary>
        /// <para>The ARM board specification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cas.cf53r</description></item>
        /// <item><description>cas.cf52r</description></item>
        /// <item><description>cas.cf52m1r</description></item>
        /// <item><description>cas.tg52g2</description></item>
        /// <item><description>ens.afq-c2m3i.medium</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cas.cf53r</para>
        /// </summary>
        [NameInMap("ServerType")]
        [Validation(Required=false)]
        public string ServerType { get; set; }

        /// <summary>
        /// <para>The list of tags bound to the instance.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateARMServerInstancesRequestTag> Tag { get; set; }
        public class CreateARMServerInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>team</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>backend</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
