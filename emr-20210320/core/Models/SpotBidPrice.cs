// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class SpotBidPrice : TeaModel {
        /// <summary>
        /// <para>实例的每小时最高出价。支持最大3位小数，参数SpotStrategy=SpotWithPriceLimit时，该参数生效。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000.0</para>
        /// </summary>
        [NameInMap("BidPrice")]
        [Validation(Required=false)]
        public double? BidPrice { get; set; }

        /// <summary>
        /// <para>实例类型。</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g7.2xlarge</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

    }

}
