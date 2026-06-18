// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListAiccsRobotResponseBody : TeaModel {
        /// <summary>
        /// <para>Request status code. A return value of OK indicates that the request Succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Robot scripts.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAiccsRobotResponseBodyData> Data { get; set; }
        public class ListAiccsRobotResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Associated industry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>房地产</para>
            /// </summary>
            [NameInMap("AtProfession")]
            [Validation(Required=false)]
            public string AtProfession { get; set; }

            /// <summary>
            /// <para>Associated business.</para>
            /// 
            /// <b>Example:</b>
            /// <para>新房销售</para>
            /// </summary>
            [NameInMap("AtSence")]
            [Validation(Required=false)]
            public string AtSence { get; set; }

            /// <summary>
            /// <para>Robot ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Robot name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试机器人</para>
            /// </summary>
            [NameInMap("RobotName")]
            [Validation(Required=false)]
            public string RobotName { get; set; }

            /// <summary>
            /// <para>Robot type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CUSTOM</para>
            /// </summary>
            [NameInMap("RobotType")]
            [Validation(Required=false)]
            public string RobotType { get; set; }

        }

        /// <summary>
        /// <para>Description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9CB3933-9FE3-4870-BA8E-2BEE91B69D23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API invocation Succeeded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Succeeded.</description></item>
        /// <item><description><b>false</b>: failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
