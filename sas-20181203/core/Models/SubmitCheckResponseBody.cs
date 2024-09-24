// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SubmitCheckResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned if the call is successful.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SubmitCheckResponseBodyData Data { get; set; }
        public class SubmitCheckResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The operation code of the configuration assessment task.</para>
            /// <list type="bullet">
            /// <item><description><b>Throttling</b>: frequency limit</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Throttling</para>
            /// </summary>
            [NameInMap("OperateCode")]
            [Validation(Required=false)]
            public string OperateCode { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE8369A6-A843-5E1B-A613-78E6920D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the configuration assessment task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5fe3f65d-4012-455d-8232-2a98a858****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
