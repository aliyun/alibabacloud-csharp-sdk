// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudCreateAgentGroupResponseBody : TeaModel {
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
        public CloudCreateAgentGroupResponseBodyData Data { get; set; }
        public class CloudCreateAgentGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>描述信息</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment3</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>创建时间，格式: yyyy-MM-dd HH:mm:ss</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-20 10:00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>企业编号</para>
            /// 
            /// <b>Example:</b>
            /// <para>7000002</para>
            /// </summary>
            [NameInMap("EnterpriseId")]
            [Validation(Required=false)]
            public long? EnterpriseId { get; set; }

            /// <summary>
            /// <para>外呼组编号</para>
            /// 
            /// <b>Example:</b>
            /// <para>WH12</para>
            /// </summary>
            [NameInMap("Gno")]
            [Validation(Required=false)]
            public string Gno { get; set; }

            /// <summary>
            /// <para>外呼组名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>gpname1</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>外呼组类型 1：外呼总组 2：外呼组</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public long? Type { get; set; }

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
        /// <para>F655A8D5-B967-440B-8683-DAD6FF8DE990</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
