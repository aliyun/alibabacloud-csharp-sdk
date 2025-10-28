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

        /// <summary>
        /// <para>Indicates whether the VPC is available. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The VPC is available.</description></item>
        /// <item><description>false: The VPC is unavailable.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("VpcList")]
        [Validation(Required=false)]
        public ListVpcResponseBodyVpcList VpcList { get; set; }
        public class ListVpcResponseBodyVpcList : TeaModel {
            [NameInMap("VpcEntity")]
            [Validation(Required=false)]
            public List<ListVpcResponseBodyVpcListVpcEntity> VpcEntity { get; set; }
            public class ListVpcResponseBodyVpcListVpcEntity : TeaModel {
                /// <summary>
                /// <para>This operation uses only common request headers. For more information, see <a href="https://help.aliyun.com/document_detail/123488.html">Common parameters for API calls</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("EcsNum")]
                [Validation(Required=false)]
                public int? EcsNum { get; set; }

                /// <summary>
                /// <para>The region ID of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public bool? Expired { get; set; }

                /// <summary>
                /// <para>No request parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shenzhen</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>GET /pop/v5/vpc_list HTTP/1.1
                /// Common request headers</para>
                /// 
                /// <b>Example:</b>
                /// <para>edas_****_test@aliyun-****.com</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the VPC belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-wz9pcq3jofczwpujq****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The number of ECS instances associated with the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>edas-default-vpc4</para>
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

        }

    }

}
