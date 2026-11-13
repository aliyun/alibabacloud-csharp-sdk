// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeModelOperatorApiKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The plaintext API key. This field is returned only when Status is Running.</para>
        /// 
        /// <b>Example:</b>
        /// <para>QEDGOTAJOG</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

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
        /// <para>The endpoint of the model operator service. This field is returned only when Status is Running.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxxx">https://xxxx</a></para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

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
        /// <para>The status of the API key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Creating: The API key is being created.</description></item>
        /// <item><description>Running: The API key is running.</description></item>
        /// <item><description>Locked: The API key is locked and cannot be used to call the model operator service.</description></item>
        /// <item><description>Deleting: The API key is being deleted. You can still query it by calling this operation, but it is no longer displayed in the results of ListModelOperatorApiKeys.</description></item>
        /// </list>
        /// <para>The plaintext API key and endpoint are returned only when Status is Running. After the deletion is complete, this operation returns a resource not found error. The status indicates the processing result of the control plane. A short propagation delay may occur before the status takes effect on the data plane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
