// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class UpdateFlowJSONAssetResponseBody : TeaModel {
        /// <summary>
        /// <para>The result returns OK as normal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateFlowJSONAssetResponseBodyData Data { get; set; }
        public class UpdateFlowJSONAssetResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Flow ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>84848847****</para>
            /// </summary>
            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

        }

        /// <summary>
        /// <para>Error description information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8939-A9486641****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
