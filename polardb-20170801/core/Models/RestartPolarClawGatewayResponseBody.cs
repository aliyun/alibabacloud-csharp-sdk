// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class RestartPolarClawGatewayResponseBody : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-xxx</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The approximate downtime of this restart, in milliseconds. This value is returned synchronously.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3235</para>
        /// </summary>
        [NameInMap("DowntimeMs")]
        [Validation(Required=false)]
        public long? DowntimeMs { get; set; }

        /// <summary>
        /// <para>The gateway version after the restart. This value is returned synchronously.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026.5.7</para>
        /// </summary>
        [NameInMap("GatewayVersion")]
        [Validation(Required=false)]
        public string GatewayVersion { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The actual restart mode used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>in-process</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Ok")]
        [Validation(Required=false)]
        public bool? Ok { get; set; }

        /// <summary>
        /// <para>The operation name. This value is returned when Async is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RestartPolarClawGateway</para>
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>F45FFACC-xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the gateway has been confirmed available after the restart. This value is returned synchronously.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Restarted")]
        [Validation(Required=false)]
        public bool? Restarted { get; set; }

        /// <summary>
        /// <para>The initial state of the asynchronous task. This value is returned when Async is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pending</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The asynchronous task ID. This value is returned when Async is set to true. You can poll the task status by calling DescribePolarClawTask.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ee00f56-f467-4d41-858c-ca4ede2c770e</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
