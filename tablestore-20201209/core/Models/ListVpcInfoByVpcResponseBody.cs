// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class ListVpcInfoByVpcResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4141784E-91FF-56E3-9371-FD011FF876F4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>VPC ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1***********0mh8</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("VpcInfos")]
        [Validation(Required=false)]
        public List<ListVpcInfoByVpcResponseBodyVpcInfos> VpcInfos { get; set; }
        public class ListVpcInfoByVpcResponseBodyVpcInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://xu6666-mkdd-test.cn-hangzhou.vpc.ots.aliyuncs.com">http://xu6666-mkdd-test.cn-hangzhou.vpc.ots.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://172.**.***.34:80/">http://172.**.***.34:80/</a></para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mkdd-test</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xu6666</para>
            /// </summary>
            [NameInMap("InstanceVpcName")]
            [Validation(Required=false)]
            public string InstanceVpcName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

        }

    }

}
