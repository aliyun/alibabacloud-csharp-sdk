// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetUploadTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The error message returned when the file upload task failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>invalid url</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ET5BF670-09D5-4D0B-BEBY-D96A2A52****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task status.</para>
        /// <list type="bullet">
        /// <item><description><b>INIT</b>: The task is being initialized.</description></item>
        /// <item><description><b>activacted</b>: The task is activated.</description></item>
        /// <item><description><b>running</b>: The task is running.</description></item>
        /// <item><description><b>success</b>: The task is successful.</description></item>
        /// <item><description><b>partial</b>: The task is partially successful.</description></item>
        /// <item><description><b>fail</b>: The task failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
