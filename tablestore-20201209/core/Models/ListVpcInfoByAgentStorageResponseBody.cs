// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class ListVpcInfoByAgentStorageResponseBody : TeaModel {
        /// <summary>
        /// <para>The agent storage name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent-test</para>
        /// </summary>
        [NameInMap("AgentStorageName")]
        [Validation(Required=false)]
        public string AgentStorageName { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID, which can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39871ED2-62C0-578F-A32E-B88072D5582F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of VPCs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The VPC details.</para>
        /// </summary>
        [NameInMap("VpcInfos")]
        [Validation(Required=false)]
        public List<ListVpcInfoByAgentStorageResponseBodyVpcInfos> VpcInfos { get; set; }
        public class ListVpcInfoByAgentStorageResponseBodyVpcInfos : TeaModel {
            /// <summary>
            /// <para>The VPC name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>remua</para>
            /// </summary>
            [NameInMap("AgentStorageVpcName")]
            [Validation(Required=false)]
            public string AgentStorageVpcName { get; set; }

            /// <summary>
            /// <para>The VPC access address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://remua-agent-test.cn-beijing.vpc.ots.aliyuncs.com">http://remua-agent-test.cn-beijing.vpc.ots.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The endpoint of the agent storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://172.**.***.34:80/">http://172.**.***.34:80/</a></para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <para>VPC ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2z***********n7w3dl</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
