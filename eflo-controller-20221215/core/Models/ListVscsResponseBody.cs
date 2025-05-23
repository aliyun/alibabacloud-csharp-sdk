// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListVscsResponseBody : TeaModel {
        /// <summary>
        /// <para>No return. Please use TotalCount</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Indicates the position of the current call return read. An empty value means that the data has been fully read.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3a6b93229825ac667104463b56790c91</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>03668372-18FF-5959-98D9-6B36A4643C7A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total count of data under the current request conditions</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>VSC list</para>
        /// </summary>
        [NameInMap("Vscs")]
        [Validation(Required=false)]
        public List<ListVscsResponseBodyVscs> Vscs { get; set; }
        public class ListVscsResponseBodyVscs : TeaModel {
            /// <summary>
            /// <para>Lingjun node ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>e01-cn-fzh47xd7u08</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>Resource group ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfm2zkwhkns57i</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Status of Vsc</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Tags</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListVscsResponseBodyVscsTags> Tags { get; set; }
            public class ListVscsResponseBodyVscsTags : TeaModel {
                /// <summary>
                /// <para>Tag key</para>
                /// 
                /// <b>Example:</b>
                /// <para>key001</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>Tag value</para>
                /// 
                /// <b>Example:</b>
                /// <para>value001</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>Vsc ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsc-001</para>
            /// </summary>
            [NameInMap("VscId")]
            [Validation(Required=false)]
            public string VscId { get; set; }

            /// <summary>
            /// <para>Customized name of Vsc</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_name</para>
            /// </summary>
            [NameInMap("VscName")]
            [Validation(Required=false)]
            public string VscName { get; set; }

            /// <summary>
            /// <para>Vsc type, primary/standard</para>
            /// 
            /// <b>Example:</b>
            /// <para>primary</para>
            /// </summary>
            [NameInMap("VscType")]
            [Validation(Required=false)]
            public string VscType { get; set; }

        }

    }

}
