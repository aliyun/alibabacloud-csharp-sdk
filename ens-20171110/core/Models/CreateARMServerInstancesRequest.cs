// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateARMServerInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The number of instances to create. Valid values: <b>1</b> to <b>100</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the subscription. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>Specifies whether to use coupons. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The ID of the Edge Node Service (ENS) node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-guiyang-12</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        [NameInMap("EnvironmentVar")]
        [Validation(Required=false)]
        public string EnvironmentVar { get; set; }

        /// <summary>
        /// <para>The refresh rate. Unit: Hz. Valid values: 30 and 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public int? Frequency { get; set; }

        /// <summary>
        /// <para>The ID of the image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourImage ID</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The specification of the Android in Container (AIC) instance. Examples:</para>
        /// <list type="bullet">
        /// <item><description>aic.cf52r.c1.np</description></item>
        /// <item><description>aic.cf52r.c2.np</description></item>
        /// <item><description>aic.cf53r.c2.np</description></item>
        /// <item><description>aic.cf52r.c4.np</description></item>
        /// <item><description>aic.cf53r.c3.np</description></item>
        /// <item><description>aic.cf52r.c3.np</description></item>
        /// <item><description>aic.cf53r.c1.np</description></item>
        /// <item><description>aic.cf53r.c5.np</description></item>
        /// <item><description>aic.cf53r.c6</description></item>
        /// <item><description>aic.cf53r.c4.np</description></item>
        /// <item><description>aic.cf53r.c6.np</description></item>
        /// <item><description>aic.cf53r.c7.np</description></item>
        /// <item><description>aic.cf52m1r.c5.np</description></item>
        /// <item><description>aic.cf53r.c8.np</description></item>
        /// <item><description>aic.cf53r.c7</description></item>
        /// <item><description>aic.cf52m1r.c2.np</description></item>
        /// <item><description>aic.cf52m1r.c1.np</description></item>
        /// <item><description>aic.cf52m1r.c3.np</description></item>
        /// <item><description>aic.cf52m1r.c4.np</description></item>
        /// <item><description>aic.cf52m1r.c6</description></item>
        /// <item><description>ens.a6c2</description></item>
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
        /// <para>The name of the key pair.</para>
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
        /// <para>The billing method. Set the value to <b>PrePaid</b>. PrePaid specifies the subscription billing method.</para>
        /// <remarks>
        /// <para> Only PrePaid is supported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The subscription duration of the instance.</para>
        /// <list type="bullet">
        /// <item><description>If you leave PeriodUnit empty, the instance is purchased on a monthly basis. Valid values: Day and Month.</description></item>
        /// <item><description>If you set PeriodUnit to Day, you can set Period only to 3.</description></item>
        /// <item><description>If you set PeriodUnit to Month, you can set Period to a value within the range of [1,9], or set the value to 12.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration.</para>
        /// <list type="bullet">
        /// <item><description>If you leave PeriodUnit empty, the instance is purchased on a monthly basis. Valid values: Day and Month.</description></item>
        /// <item><description>If you set PeriodUnit to Day, you can set Period only to 3.</description></item>
        /// <item><description>If you set PeriodUnit to Month, you can set Period to a value within the range of [1,9], or set the value to 12.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The resolution. Examples:</para>
        /// <list type="bullet">
        /// <item><description>1920\*864</description></item>
        /// <item><description>1080\*1920</description></item>
        /// <item><description>1920\*1080</description></item>
        /// <item><description>720\*1280</description></item>
        /// <item><description>2400\*1080</description></item>
        /// <item><description>1080\*2400</description></item>
        /// <item><description>1280\*720</description></item>
        /// <item><description>864\*1920</description></item>
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
        /// <para>The name of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AIC-Server</para>
        /// </summary>
        [NameInMap("ServerName")]
        [Validation(Required=false)]
        public string ServerName { get; set; }

        /// <summary>
        /// <para>The specification of the ARM server. Examples:</para>
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

    }

}
