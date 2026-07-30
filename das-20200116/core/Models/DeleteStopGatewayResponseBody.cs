// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DeleteStopGatewayResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The status code indicating the result of the deletion:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Success. The metadata was deleted.</para>
        /// </description></item>
        /// <item><description><para><b>-1</b>: A system error occurred.</para>
        /// </description></item>
        /// <item><description><para><b>-2</b>: The specified database gateway does not exist.</para>
        /// </description></item>
        /// <item><description><para><b>-3</b>: The database gateway is still active (not stopped) and its metadata cannot be deleted.</para>
        /// </description></item>
        /// <item><description><para><b>-4</b>: Failed to delete the metadata.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para>When the request is successful, this parameter returns <b>Successful</b>. When the request fails, this parameter returns exception information such as error codes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC6C0929-29E1-59FD-8DFE-70D9D41E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The operation is successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The operation failed.</para>
        /// </description></item>
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
