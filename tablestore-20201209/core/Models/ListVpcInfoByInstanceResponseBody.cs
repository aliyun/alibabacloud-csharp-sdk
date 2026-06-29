// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class ListVpcInfoByInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mkdd-test</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

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
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request. You can use the ID to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44FDC379-4443-560E-B652-9F7476D8854F</para>
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
        /// <para>The details of the VPCs.</para>
        /// </summary>
        [NameInMap("VpcInfos")]
        [Validation(Required=false)]
        public List<ListVpcInfoByInstanceResponseBodyVpcInfos> VpcInfos { get; set; }
        public class ListVpcInfoByInstanceResponseBodyVpcInfos : TeaModel {
            /// <summary>
            /// <para>The endpoint of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xu6666-mkdd-test.cn-hangzhou.vpc.ots.aliyuncs.com">http://xu6666-mkdd-test.cn-hangzhou.vpc.ots.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The endpoint of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://172.**.***.34:80/">http://172.**.***.34:80/</a></para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The name of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xu6666</para>
            /// </summary>
            [NameInMap("InstanceVpcName")]
            [Validation(Required=false)]
            public string InstanceVpcName { get; set; }

            /// <summary>
            /// <para>The ID of the region.</para>
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
            /// <para>vpc-2z***********n7w3dl</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
