// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetInstanceUpDownStreamResponseBody : TeaModel {
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
        /// <para>The instance dag data, including the current instance and its upstream and downstream instances.</para>
        /// </summary>
        [NameInMap("InstanceDagInfo")]
        [Validation(Required=false)]
        public GetInstanceUpDownStreamResponseBodyInstanceDagInfo InstanceDagInfo { get; set; }
        public class GetInstanceUpDownStreamResponseBodyInstanceDagInfo : TeaModel {
            /// <summary>
            /// <para>The downstream instances.</para>
            /// </summary>
            [NameInMap("DownInstanceList")]
            [Validation(Required=false)]
            public List<GetInstanceUpDownStreamResponseBodyInstanceDagInfoDownInstanceList> DownInstanceList { get; set; }
            public class GetInstanceUpDownStreamResponseBodyInstanceDagInfoDownInstanceList : TeaModel {
                /// <summary>
                /// <para>The list of field IDs.</para>
                /// </summary>
                [NameInMap("FieldInstanceIdList")]
                [Validation(Required=false)]
                public List<string> FieldInstanceIdList { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t_1234567</para>
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
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n_1234567</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The node type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DATA_PROCESS</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

            }

            /// <summary>
            /// <para>The center instances.</para>
            /// </summary>
            [NameInMap("StartInstanceList")]
            [Validation(Required=false)]
            public List<GetInstanceUpDownStreamResponseBodyInstanceDagInfoStartInstanceList> StartInstanceList { get; set; }
            public class GetInstanceUpDownStreamResponseBodyInstanceDagInfoStartInstanceList : TeaModel {
                /// <summary>
                /// <para>The list of field IDs.</para>
                /// </summary>
                [NameInMap("FieldInstanceIdList")]
                [Validation(Required=false)]
                public List<string> FieldInstanceIdList { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t_1234567</para>
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
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n_1234567</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The node type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DATA_PROCESS: code node.</description></item>
                /// <item><description>BBOX_LOGIC_TABLE_NODE: logical table node.</description></item>
                /// <item><description>PIPELINE_NODE: pipeline node.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DATA_PROCESS</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

            }

            /// <summary>
            /// <para>The upstream instances.</para>
            /// </summary>
            [NameInMap("UpInstanceList")]
            [Validation(Required=false)]
            public List<GetInstanceUpDownStreamResponseBodyInstanceDagInfoUpInstanceList> UpInstanceList { get; set; }
            public class GetInstanceUpDownStreamResponseBodyInstanceDagInfoUpInstanceList : TeaModel {
                /// <summary>
                /// <para>The list of field IDs.</para>
                /// </summary>
                [NameInMap("FieldInstanceIdList")]
                [Validation(Required=false)]
                public List<string> FieldInstanceIdList { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t_1234567</para>
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
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n_1234567</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The node type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DATA_PROCESS</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

            }

        }

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
