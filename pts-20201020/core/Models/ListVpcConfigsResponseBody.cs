// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class ListVpcConfigsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>The specified parameter is invalid.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9E4FE41E-782D-5CF9-BFAF-2F369EFD803A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("VpcConfigList")]
        [Validation(Required=false)]
        public List<ListVpcConfigsResponseBodyVpcConfigList> VpcConfigList { get; set; }
        public class ListVpcConfigsResponseBodyVpcConfigList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>VPC配置信息描述</para>
            /// </summary>
            [NameInMap("ConfigDescription")]
            [Validation(Required=false)]
            public string ConfigDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>05AHW</para>
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public string ConfigId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>my-test-vpc-config-info</para>
            /// </summary>
            [NameInMap("ConfigName")]
            [Validation(Required=false)]
            public string ConfigName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sg-2zeid0dd7bhkynxqpaly</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1756954374266</para>
            /// </summary>
            [NameInMap("SortPriority")]
            [Validation(Required=false)]
            public long? SortPriority { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-2zes82msebuel5lbw0w1r</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>192.168.0.0/16</para>
            /// </summary>
            [NameInMap("VpcCidr")]
            [Validation(Required=false)]
            public string VpcCidr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-bp11w3qellkjwnhqxzmt2</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
