// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeDBNodeDirectVipInfoResponseBody : TeaModel {
        [NameInMap("DirectVipInfo")]
        [Validation(Required=false)]
        public DescribeDBNodeDirectVipInfoResponseBodyDirectVipInfo DirectVipInfo { get; set; }
        public class DescribeDBNodeDirectVipInfoResponseBodyDirectVipInfo : TeaModel {
            [NameInMap("VipInfo")]
            [Validation(Required=false)]
            public List<DescribeDBNodeDirectVipInfoResponseBodyDirectVipInfoVipInfo> VipInfo { get; set; }
            public class DescribeDBNodeDirectVipInfoResponseBodyDirectVipInfoVipInfo : TeaModel {
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                [NameInMap("Vip")]
                [Validation(Required=false)]
                public string Vip { get; set; }

            }

        }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABAF95F6-35C1-4177-AF3A-70969EBD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
