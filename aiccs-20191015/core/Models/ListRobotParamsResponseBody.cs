// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListRobotParamsResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code. A value of 200 indicates that the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Parameter information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListRobotParamsResponseBodyData> Data { get; set; }
        public class ListRobotParamsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the parameter is required. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: Not required.</para>
            /// </description></item>
            /// <item><description><para>1: Required.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IsEmpty")]
            [Validation(Required=false)]
            public int? IsEmpty { get; set; }

            /// <summary>
            /// <para>Parameter ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ParamCode")]
            [Validation(Required=false)]
            public string ParamCode { get; set; }

            /// <summary>
            /// <para>Parameter name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>名称</para>
            /// </summary>
            [NameInMap("ParamName")]
            [Validation(Required=false)]
            public string ParamName { get; set; }

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
        /// <para>FF67D4D5-4E90-1DF5-BB8F-060BBFAD72DB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API invocation succeeded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Succeeded.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
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
