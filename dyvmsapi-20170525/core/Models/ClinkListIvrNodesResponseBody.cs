// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkListIvrNodesResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ClinkListIvrNodesResponseBodyData Data { get; set; }
        public class ClinkListIvrNodesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>请求 id</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("ClinkRequestId")]
            [Validation(Required=false)]
            public string ClinkRequestId { get; set; }

            /// <summary>
            /// <para>语音导航节点列表</para>
            /// </summary>
            [NameInMap("IvrNodes")]
            [Validation(Required=false)]
            public List<ClinkListIvrNodesResponseBodyDataIvrNodes> IvrNodes { get; set; }
            public class ClinkListIvrNodesResponseBodyDataIvrNodes : TeaModel {
                /// <summary>
                /// <para>语音导航节点</para>
                /// 
                /// <b>Example:</b>
                /// <para>E91_rp0D1</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>语音导航常用节点</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("FrequentlyPath")]
                [Validation(Required=false)]
                public string FrequentlyPath { get; set; }

                /// <summary>
                /// <para>语音导航节点id</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>语音导航id</para>
                /// 
                /// <b>Example:</b>
                /// <para>53</para>
                /// </summary>
                [NameInMap("IvrId")]
                [Validation(Required=false)]
                public long? IvrId { get; set; }

                /// <summary>
                /// <para>语音导航节点名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>Name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>是否开启节点统计，0：不开启；1：开启</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Statistic")]
                [Validation(Required=false)]
                public long? Statistic { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D9CB3933-9FE3-4870-BA8E-2BEE91B69D23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
