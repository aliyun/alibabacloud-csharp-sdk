// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class AppendInstancesToPrometheusGlobalViewResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code. 200 means success, other status codes are exceptions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The information about the array object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AppendInstancesToPrometheusGlobalViewResponseBodyData Data { get; set; }
        public class AppendInstancesToPrometheusGlobalViewResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Info-level information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{regionId: the region where the aggregation instance resides. globalViewClusterId: the ID of the aggregation instance. failedInstances: the ID of the object that failed to be added.}</para>
            /// </summary>
            [NameInMap("Info")]
            [Validation(Required=false)]
            public string Info { get; set; }

            /// <summary>
            /// <para>The additional information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            /// <summary>
            /// <para>Indicates whether the call was successful. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: The call was successful.</description></item>
            /// <item><description><c>false</c>: The call failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>Additional message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. You can use the ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27E653FA-5958-45BE-8AA9-14D884DC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
