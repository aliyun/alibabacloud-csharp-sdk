// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class SparkAttemptInfo : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>s202207151211hz0cb4200*****-0001</para>
        /// </summary>
        [NameInMap("AttemptId")]
        [Validation(Required=false)]
        public string AttemptId { get; set; }

        [NameInMap("Detail")]
        [Validation(Required=false)]
        public Detail Detail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WARN: Disk is full</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
