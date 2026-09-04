// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLProgressSlowDetail : TeaModel {
        /// <summary>
        /// <para>The elapsed time of the request, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42.5</para>
        /// </summary>
        [NameInMap("Elapsed")]
        [Validation(Required=false)]
        public double? Elapsed { get; set; }

        /// <summary>
        /// <para>worker IP</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.12</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The IPC channel identifier, which corresponds to the ipc field in the log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipc://worker-0</para>
        /// </summary>
        [NameInMap("Ipc")]
        [Validation(Required=false)]
        public string Ipc { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is paused. This is the raw value of the is_pause field in the log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsPause")]
        [Validation(Required=false)]
        public string IsPause { get; set; }

        /// <summary>
        /// <para>The log message, truncated to 700 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CUDA out of memory. Tried to allocate 2.00 GiB</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The output queue length. This is the raw value of the out_queue field in the log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("OutQueue")]
        [Validation(Required=false)]
        public string OutQueue { get; set; }

        /// <summary>
        /// <para>The name of the pod.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc193cpaitk8eny-master-0</para>
        /// </summary>
        [NameInMap("Pod")]
        [Validation(Required=false)]
        public string Pod { get; set; }

        /// <summary>
        /// <para>The training rank.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Rank")]
        [Validation(Required=false)]
        public int? Rank { get; set; }

        /// <summary>
        /// <para>The inference request ID, which corresponds to the rid field in the log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>req-8f3a2c1d</para>
        /// </summary>
        [NameInMap("Rid")]
        [Validation(Required=false)]
        public string Rid { get; set; }

        /// <summary>
        /// <para>Indicates whether the state is present. This is the raw value of the state_present field in the log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("StatePresent")]
        [Validation(Required=false)]
        public string StatePresent { get; set; }

        /// <summary>
        /// <para>The log time, in UNIX seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487</para>
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        /// <summary>
        /// <para>The tokenizer process ID, which corresponds to the pid field in the log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12360</para>
        /// </summary>
        [NameInMap("TokenizerPid")]
        [Validation(Required=false)]
        public string TokenizerPid { get; set; }

        /// <summary>
        /// <para>The worker process ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("WorkerPid")]
        [Validation(Required=false)]
        public int? WorkerPid { get; set; }

    }

}
