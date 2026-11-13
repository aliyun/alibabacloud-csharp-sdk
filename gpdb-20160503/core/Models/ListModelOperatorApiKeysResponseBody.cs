// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListModelOperatorApiKeysResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of API keys for which no deletion request has been initiated. After a deletion request is accepted, the key no longer appears in this list.</para>
        /// </summary>
        [NameInMap("ApiKeys")]
        [Validation(Required=false)]
        public List<ListModelOperatorApiKeysResponseBodyApiKeys> ApiKeys { get; set; }
        public class ListModelOperatorApiKeysResponseBodyApiKeys : TeaModel {
            /// <summary>
            /// <para>The API key ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ApiKeyId")]
            [Validation(Required=false)]
            public int? ApiKeyId { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-apikey</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The complete HTTP(S) endpoint for calling the model operator service. This field is returned only when Status is Running. This field is not returned for other statuses. The list operation does not return the plaintext API key. To obtain the plaintext API key, call DescribeModelOperatorApiKey.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxxx">https://xxxx</a></para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The status of the API key. The statuses returned in the list include:</para>
            /// <list type="bullet">
            /// <item><description>Creating: The API key is being created.</description></item>
            /// <item><description>Running: The API key is running.</description></item>
            /// <item><description>Locked: The API key is locked and cannot be used to call the model operator service. This status may also be displayed when the API key is being locked or unlocked.</description></item>
            /// </list>
            /// <para>API keys for which a deletion request has been accepted no longer appear in the list. You can call DescribeModelOperatorApiKey to query the Deleting status. After the cleanup is complete, a detail query returns a resource not found error. The status indicates the processing result on the control plane. A short propagation delay may occur before the status takes effect on the data plane.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
