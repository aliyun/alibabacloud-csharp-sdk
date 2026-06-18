// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetAllDepartmentResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code. A return value of 200 indicates that the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Department information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetAllDepartmentResponseBodyData> Data { get; set; }
        public class GetAllDepartmentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Department ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("DepartmentId")]
            [Validation(Required=false)]
            public long? DepartmentId { get; set; }

            /// <summary>
            /// <para>Department name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>部门A</para>
            /// </summary>
            [NameInMap("DepartmentName")]
            [Validation(Required=false)]
            public string DepartmentName { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
        /// <para>98B032F5-6473-4EAC-8BA8-C28993513A1F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API invocation succeeded. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Succeeded.  </description></item>
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
