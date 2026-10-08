// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListVpcResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The information about VPCs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The name of the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b197-40ab-9155-7ca7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VpcList")]
        [Validation(Required=false)]
        public ListVpcResponseBodyVpcList VpcList { get; set; }
        public class ListVpcResponseBodyVpcList : TeaModel {
            [NameInMap("VpcEntity")]
            [Validation(Required=false)]
            public List<ListVpcResponseBodyVpcListVpcEntity> VpcEntity { get; set; }
            public class ListVpcResponseBodyVpcListVpcEntity : TeaModel {
                [NameInMap("EcsNum")]
                [Validation(Required=false)]
                public int? EcsNum { get; set; }

                [NameInMap("Expired")]
                [Validation(Required=false)]
                public bool? Expired { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

        }

    }

}
