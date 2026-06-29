// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetNodeUpDownStreamResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The dag data of the node.</para>
        /// </summary>
        [NameInMap("NodeDagInfo")]
        [Validation(Required=false)]
        public GetNodeUpDownStreamResponseBodyNodeDagInfo NodeDagInfo { get; set; }
        public class GetNodeUpDownStreamResponseBodyNodeDagInfo : TeaModel {
            /// <summary>
            /// <para>The downstream nodes.</para>
            /// </summary>
            [NameInMap("DownStreamNodeList")]
            [Validation(Required=false)]
            public List<GetNodeUpDownStreamResponseBodyNodeDagInfoDownStreamNodeList> DownStreamNodeList { get; set; }
            public class GetNodeUpDownStreamResponseBodyNodeDagInfoDownStreamNodeList : TeaModel {
                /// <summary>
                /// <para>The list of field IDs.</para>
                /// </summary>
                [NameInMap("FieldIdList")]
                [Validation(Required=false)]
                public List<string> FieldIdList { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n_123456</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The node name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx测试</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The node type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DATA_PROCESS: code task.</description></item>
                /// <item><description>BBOX_LOGIC_TABLE_NODE: logical table node.</description></item>
                /// <item><description>PIPELINE_NODE: pipeline node.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DATA_PROCESS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The center nodes.</para>
            /// </summary>
            [NameInMap("StartNodeList")]
            [Validation(Required=false)]
            public List<GetNodeUpDownStreamResponseBodyNodeDagInfoStartNodeList> StartNodeList { get; set; }
            public class GetNodeUpDownStreamResponseBodyNodeDagInfoStartNodeList : TeaModel {
                /// <summary>
                /// <para>The list of field IDs.</para>
                /// </summary>
                [NameInMap("FieldIdList")]
                [Validation(Required=false)]
                public List<string> FieldIdList { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n_123456</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The node name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx测试</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The node type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DATA_PROCESS: code task.</description></item>
                /// <item><description>BBOX_LOGIC_TABLE_NODE: logical table node.</description></item>
                /// <item><description>PIPELINE_NODE: pipeline node.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DATA_PROCESS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The upstream nodes.</para>
            /// </summary>
            [NameInMap("UpStreamNodeList")]
            [Validation(Required=false)]
            public List<GetNodeUpDownStreamResponseBodyNodeDagInfoUpStreamNodeList> UpStreamNodeList { get; set; }
            public class GetNodeUpDownStreamResponseBodyNodeDagInfoUpStreamNodeList : TeaModel {
                /// <summary>
                /// <para>The list of field IDs.</para>
                /// </summary>
                [NameInMap("FieldIdList")]
                [Validation(Required=false)]
                public List<string> FieldIdList { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n_123456</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The node name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx测试</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The node type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DATA_PROCESS: code task.</description></item>
                /// <item><description>BBOX_LOGIC_TABLE_NODE: black box logical table node.</description></item>
                /// <item><description>PIPELINE_NODE: pipeline node.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DATA_PROCESS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
