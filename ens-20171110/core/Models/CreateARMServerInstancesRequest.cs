// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateARMServerInstancesRequest : TeaModel {
        /// <summary>
        /// The number of instances to create. Valid values: **1** to **100**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// Specifies whether to enable auto-renewal for the subscription. Valid values:
        /// 
        /// *   true
        /// *   false (default)
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// Specifies whether to use coupons. Valid values:
        /// 
        /// *   true
        /// *   false (default)
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// The ID of the Edge Node Service (ENS) node.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// The refresh rate. Unit: Hz. Valid values: 30 and 60.
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public int? Frequency { get; set; }

        /// <summary>
        /// The ID of the image.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The specification of the Android in Container (AIC) instance. Examples:
        /// 
        /// *   aic.cf52r.c1.np
        /// *   aic.cf52r.c2.np
        /// *   aic.cf53r.c2.np
        /// *   aic.cf52r.c4.np
        /// *   aic.cf53r.c3.np
        /// *   aic.cf52r.c3.np
        /// *   aic.cf53r.c1.np
        /// *   aic.cf53r.c5.np
        /// *   aic.cf53r.c6
        /// *   aic.cf53r.c4.np
        /// *   aic.cf53r.c6.np
        /// *   aic.cf53r.c7.np
        /// *   aic.cf52m1r.c5.np
        /// *   aic.cf53r.c8.np
        /// *   aic.cf53r.c7
        /// *   aic.cf52m1r.c2.np
        /// *   aic.cf52m1r.c1.np
        /// *   aic.cf52m1r.c3.np
        /// *   aic.cf52m1r.c4.np
        /// *   aic.cf52m1r.c6
        /// *   ens.a6c2
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The name of the key pair.
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// The namespace.
        /// </summary>
        [NameInMap("NameSpace")]
        [Validation(Required=false)]
        public string NameSpace { get; set; }

        /// <summary>
        /// The billing method. Set the value to **PrePaid**. PrePaid specifies the subscription billing method.
        /// 
        /// >  Only PrePaid is supported.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The subscription duration of the instance.
        /// 
        /// *   If you leave PeriodUnit empty, the instance is purchased on a monthly basis. Valid values: Day and Month.
        /// *   If you set PeriodUnit to Day, you can set Period only to 3.
        /// *   If you set PeriodUnit to Month, you can set Period to a value within the range of [1,9], or set the value to 12.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The unit of the subscription duration.
        /// 
        /// *   If you leave PeriodUnit empty, the instance is purchased on a monthly basis. Valid values: Day and Month.
        /// *   If you set PeriodUnit to Day, you can set Period only to 3.
        /// *   If you set PeriodUnit to Month, you can set Period to a value within the range of [1,9], or set the value to 12.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// The resolution. Examples:
        /// 
        /// *   1920\\*864
        /// *   1080\\*1920
        /// *   1920\\*1080
        /// *   720\\*1280
        /// *   2400\\*1080
        /// *   1080\\*2400
        /// *   1280\\*720
        /// *   864\\*1920
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Resolution")]
        [Validation(Required=false)]
        public string Resolution { get; set; }

        /// <summary>
        /// The name of the service.
        /// </summary>
        [NameInMap("ServerName")]
        [Validation(Required=false)]
        public string ServerName { get; set; }

        /// <summary>
        /// The specification of the ARM server. Examples:
        /// 
        /// *   cas.cf53r
        /// *   cas.cf52r
        /// *   cas.cf52m1r
        /// *   cas.tg52g2
        /// *   ens.afq-c2m3i.medium
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServerType")]
        [Validation(Required=false)]
        public string ServerType { get; set; }

    }

}
