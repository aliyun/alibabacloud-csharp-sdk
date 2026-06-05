// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DelHiveEdgeWorkersResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FailedInstanceCount")]
        [Validation(Required=false)]
        public int? FailedInstanceCount { get; set; }

        [NameInMap("FailedInstances")]
        [Validation(Required=false)]
        public List<DelHiveEdgeWorkersResponseBodyFailedInstances> FailedInstances { get; set; }
        public class DelHiveEdgeWorkersResponseBodyFailedInstances : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ew-1226d588c69449209ee963161c067b04</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Error 1062 (23000): Duplicate entry \&quot;hive-4fbf3928d40e43948b98acdb4fb5aaed-ew-1226d588c69449209ee9631\&quot; for key \&quot;PRIMARY\&quot;</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx-xxx-xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SuccessInstanceCount")]
        [Validation(Required=false)]
        public int? SuccessInstanceCount { get; set; }

        [NameInMap("SuccessInstances")]
        [Validation(Required=false)]
        public List<DelHiveEdgeWorkersResponseBodySuccessInstances> SuccessInstances { get; set; }
        public class DelHiveEdgeWorkersResponseBodySuccessInstances : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ew-1226d588c69449209ee963161c067b04</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

    }

}
