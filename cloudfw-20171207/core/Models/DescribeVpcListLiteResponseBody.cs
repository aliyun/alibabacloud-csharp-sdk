// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcListLiteResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>55E56A55-D93A-5614-AE00-BE2F8077F891</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the VPCs.</para>
        /// </summary>
        [NameInMap("VpcList")]
        [Validation(Required=false)]
        public List<DescribeVpcListLiteResponseBodyVpcList> VpcList { get; set; }
        public class DescribeVpcListLiteResponseBodyVpcList : TeaModel {
            /// <summary>
            /// <para>The region ID of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <para>The ID of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-wz9dqhljd10fk0b4eh885</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The name of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Cloud_Firewall_VPC</para>
            /// </summary>
            [NameInMap("VpcName")]
            [Validation(Required=false)]
            public string VpcName { get; set; }

        }

    }

}
