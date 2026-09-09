// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class AbolishCrossProjectPipelineRunResponseBody : TeaModel {
        /// <summary>
        /// <para>The business response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;RequestId&quot;:&quot;735894D1-D5E5-50B8-8A6D-041C90A98B23&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AbolishCrossProjectPipelineRunResponseBodyData Data { get; set; }
        public class AbolishCrossProjectPipelineRunResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>735894D1-D5E5-50B8-8A6D-041C90A98B23</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>735894D1-D5E5-50B8-8A6D-041C90A98B23</para>
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
