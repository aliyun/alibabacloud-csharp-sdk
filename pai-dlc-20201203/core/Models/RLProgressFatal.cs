// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLProgressFatal : TeaModel {
        /// <summary>
        /// <para>The agent_collect_time of the anchor line, represented as a nanosecond string that exceeds the JavaScript safe integer limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487713456789</para>
        /// </summary>
        [NameInMap("CollectNs")]
        [Validation(Required=false)]
        public string CollectNs { get; set; }

        /// <summary>
        /// <para>The error message, truncated to 500 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CUDA out of memory. Tried to allocate 2.00 GiB</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The raw log line, truncated to 2000 characters. It is passed as AnchorMessage when calling GetRLLogContext.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[rank0]: torch.OutOfMemoryError: CUDA out of memory. Tried to allocate 2.00 GiB</para>
        /// </summary>
        [NameInMap("RawMessage")]
        [Validation(Required=false)]
        public string RawMessage { get; set; }

        /// <summary>
        /// <para>The nanosecond offset within the same second, used for sorting logs within the same second.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("SubsecNs")]
        [Validation(Required=false)]
        public long? SubsecNs { get; set; }

        /// <summary>
        /// <para>The log time in UNIX seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487</para>
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

    }

}
