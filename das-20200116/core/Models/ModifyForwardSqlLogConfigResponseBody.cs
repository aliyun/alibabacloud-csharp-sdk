// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class ModifyForwardSqlLogConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>ForwardSqlLogResult</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyForwardSqlLogConfigResponseBodyData Data { get; set; }
        public class ModifyForwardSqlLogConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the Simple Log Service Logstore for real-time log delivery.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cdn222</para>
            /// </summary>
            [NameInMap("Logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

            /// <summary>
            /// <para>The project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>facedetect7</para>
            /// </summary>
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// <para>The VPC endpoint of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-intranet.log.aliyuncs.com</para>
            /// </summary>
            [NameInMap("VpcEndpoint")]
            [Validation(Required=false)]
            public string VpcEndpoint { get; set; }

        }

        /// <summary>
        /// <para>The message returned for the request.</para>
        /// <remarks>
        /// <para>If the request is successful, <b>Successful</b> is returned. If the request fails, an error message such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
