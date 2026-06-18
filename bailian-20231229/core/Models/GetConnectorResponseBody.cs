// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class GetConnectorResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetConnectorResponseBodyData Data { get; set; }
        public class GetConnectorResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the connector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>conn_file_e0c9db4030b2465a9478028f7d76cd92_1234</para>
            /// </summary>
            [NameInMap("ConnectorId")]
            [Validation(Required=false)]
            public string ConnectorId { get; set; }

            /// <summary>
            /// <para>The name of the connector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("ConnectorName")]
            [Validation(Required=false)]
            public string ConnectorName { get; set; }

            /// <summary>
            /// <para>The type of the connector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FILE</para>
            /// </summary>
            [NameInMap("ConnectorType")]
            [Validation(Required=false)]
            public string ConnectorType { get; set; }

            /// <summary>
            /// <para>The description of the connector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Requests throttling triggered.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7BA8ADD9-53D6-53F0-918F-A1E776AD230E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status code of the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. The valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The call was successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The call failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
