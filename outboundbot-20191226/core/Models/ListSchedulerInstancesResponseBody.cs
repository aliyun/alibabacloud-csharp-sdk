// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListSchedulerInstancesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SchedulerInstances")]
        [Validation(Required=false)]
        public List<ListSchedulerInstancesResponseBodySchedulerInstances> SchedulerInstances { get; set; }
        public class ListSchedulerInstancesResponseBodySchedulerInstances : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("BaseStrategy")]
            [Validation(Required=false)]
            public string BaseStrategy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CLOUD_CODE_PUBLISHER</para>
            /// </summary>
            [NameInMap("Business")]
            [Validation(Required=false)]
            public string Business { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MaxConcurrency")]
            [Validation(Required=false)]
            public int? MaxConcurrency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>234852938</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
