// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class UpdateSubnetResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response content.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public UpdateSubnetResponseBodyContent Content { get; set; }
        public class UpdateSubnetResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The subnet instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>subnet-yuvn29bn</para>
            /// </summary>
            [NameInMap("SubnetId")]
            [Validation(Required=false)]
            public string SubnetId { get; set; }

        }

        /// <summary>
        /// <para>The message that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3D9D6E7B-365B-5200-BFA6-9B79E269058C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
