// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryVmsRealNumberCallConnectionRateInfoRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>真实号码</para>
        /// 
        /// <b>Example:</b>
        /// <para>131***1234</para>
        /// </summary>
        [NameInMap("RealNumber")]
        [Validation(Required=false)]
        public string RealNumber { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>时间段</para>
        /// 
        /// <b>Example:</b>
        /// <para>1764666240123-1764686240567</para>
        /// </summary>
        [NameInMap("TimePeriod")]
        [Validation(Required=false)]
        public string TimePeriod { get; set; }

        /// <summary>
        /// <para>虚拟号码</para>
        /// 
        /// <b>Example:</b>
        /// <para>0571***1234</para>
        /// </summary>
        [NameInMap("VirtualNumber")]
        [Validation(Required=false)]
        public string VirtualNumber { get; set; }

    }

}
