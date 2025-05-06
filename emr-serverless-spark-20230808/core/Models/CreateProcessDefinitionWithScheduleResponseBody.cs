// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class CreateProcessDefinitionWithScheduleResponseBody : TeaModel {
        /// <summary>
        /// <para>The code that is returned by the backend server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1400009</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateProcessDefinitionWithScheduleResponseBodyData Data { get; set; }
        public class CreateProcessDefinitionWithScheduleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The workflow ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>160************</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public long? Code { get; set; }

            /// <summary>
            /// <para>The serial number of the workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12342</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("failed")]
        [Validation(Required=false)]
        public string Failed { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The description of the returned code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>No permission for resource action</para>
        /// </summary>
        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
