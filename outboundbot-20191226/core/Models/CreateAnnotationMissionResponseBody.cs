// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateAnnotationMissionResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateAnnotationMissionResponseBodyData Data { get; set; }
        public class CreateAnnotationMissionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The additional information. If the request was successful, &quot;success&quot; is returned. If the request failed, a specific error code is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Execution failed: element lookup or operation timed out, outTaskId:trademark_regnew_public_cn-uax33hol2uu,flowId:null,nodeUUID:541b6c71-8cce-4ab0-af84-713ca9741821</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Indicates whether the operation was successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The additional information. If the request was successful, &quot;success&quot; is returned. If the request failed, a specific error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Execution failed: element lookup or operation timed out, outTaskId:trademark_regnew_public_cn-uax33hol2uu,flowId:null,nodeUUID:541b6c71-8cce-4ab0-af84-713ca9741821</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. true: The call was successful. false: The call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
