// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class CreateSignalResponseBody : TeaModel {
        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc********</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019F6385-7481-57A7-BEC9-***********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The signal code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SIGUSR1</para>
        /// </summary>
        [NameInMap("Signal")]
        [Validation(Required=false)]
        public string Signal { get; set; }

        /// <summary>
        /// <para>The signal ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oper************</para>
        /// </summary>
        [NameInMap("SignalId")]
        [Validation(Required=false)]
        public string SignalId { get; set; }

        /// <summary>
        /// <para>The signal status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
