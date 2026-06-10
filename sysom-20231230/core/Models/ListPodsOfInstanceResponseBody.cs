// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListPodsOfInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>B149FD9C-ED5C-5765-B3AD-05AA4A4D64D7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data returned</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListPodsOfInstanceResponseBodyData> Data { get; set; }
        public class ListPodsOfInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Namespace where the pod resides</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>Pod Name</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-pod</para>
            /// </summary>
            [NameInMap("pod")]
            [Validation(Required=false)]
            public string Pod { get; set; }

        }

        /// <summary>
        /// <para>Error message; empty indicates that data reading is complete</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance not exists</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The maximum number of records returned by this request</para>
        /// 
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
