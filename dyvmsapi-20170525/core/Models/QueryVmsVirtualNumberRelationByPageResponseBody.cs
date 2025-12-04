// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryVmsVirtualNumberRelationByPageResponseBody : TeaModel {
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public QueryVmsVirtualNumberRelationByPageResponseBodyModel Model { get; set; }
        public class QueryVmsVirtualNumberRelationByPageResponseBodyModel : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryVmsVirtualNumberRelationByPageResponseBodyModelData> Data { get; set; }
            public class QueryVmsVirtualNumberRelationByPageResponseBodyModelData : TeaModel {
                /// <summary>
                /// <para>号码归属地--城市</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("NumberCity")]
                [Validation(Required=false)]
                public string NumberCity { get; set; }

                /// <summary>
                /// <para>号码归属地--省</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("NumberProvince")]
                [Validation(Required=false)]
                public string NumberProvince { get; set; }

                /// <summary>
                /// <para>真实号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>131****1234</para>
                /// </summary>
                [NameInMap("RealNumber")]
                [Validation(Required=false)]
                public string RealNumber { get; set; }

                /// <summary>
                /// <para>状态 1:有效；0:无效；-1:注销</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public long? State { get; set; }

                /// <summary>
                /// <para>虚拟号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>0571***1234</para>
                /// </summary>
                [NameInMap("VirtualNumber")]
                [Validation(Required=false)]
                public string VirtualNumber { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>65</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>231</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>01A58FA5-422C-58E0-AA71-B307A665416F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
