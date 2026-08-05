// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateRtcAsrTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The result description. The value success indicates a successful operation. An error message is returned if a fault occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The gateway request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7FF5417D-06E9-5A2C-9A70-581F6149E6C1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status code. A value of 2000 indicates success. Other values indicate exceptions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("RetCode")]
        [Validation(Required=false)]
        public long? RetCode { get; set; }

        /// <summary>
        /// <para>The generated task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asr-a6ac15e0-9118-4b4c-9e64-306163a0****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
