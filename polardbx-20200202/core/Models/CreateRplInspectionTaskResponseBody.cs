// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class CreateRplInspectionTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The task details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateRplInspectionTaskResponseBodyData Data { get; set; }
        public class CreateRplInspectionTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the Slink task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>etx-szr2rr6i*****</para>
            /// </summary>
            [NameInMap("SlinkTaskId")]
            [Validation(Required=false)]
            public string SlinkTaskId { get; set; }

        }

        /// <summary>
        /// <para>The error message of the task. This parameter is returned only when the task status is <b>stop</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B2F3840-5C98-475C-B269-2D5C3A31797C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
