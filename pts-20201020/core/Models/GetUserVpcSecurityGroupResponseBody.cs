// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetUserVpcSecurityGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The system status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message. If the operation is successful, this parameter is not returned.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61B15017-1A68-5C47-834F-87E2BBC44F2C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of security groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("SecurityGroupCount")]
        [Validation(Required=false)]
        public int? SecurityGroupCount { get; set; }

        /// <summary>
        /// <para>The security groups.</para>
        /// </summary>
        [NameInMap("SecurityGroupList")]
        [Validation(Required=false)]
        public List<GetUserVpcSecurityGroupResponseBodySecurityGroupList> SecurityGroupList { get; set; }
        public class GetUserVpcSecurityGroupResponseBodySecurityGroupList : TeaModel {
            /// <summary>
            /// <para>The description of the security group.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp16bt3zuugxpfjkasdfvthxth8</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The name of the security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-security-group</para>
            /// </summary>
            [NameInMap("SecurityGroupName")]
            [Validation(Required=false)]
            public string SecurityGroupName { get; set; }

            /// <summary>
            /// <para>The ID of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-uf6tar2ohlasdhsatjln37h30bv</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the operation is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
