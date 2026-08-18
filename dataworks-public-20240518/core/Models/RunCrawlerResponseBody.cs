// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class RunCrawlerResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the metadata crawler.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The request ID. Used for locating logs and troubleshooting issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9252F32F-D855-549E-8898-61CF5A733050</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the run request was accepted. A value of true indicates that the request was accepted, but does not indicate that the collection task is complete.</para>
        /// </summary>
        [NameInMap("RunAccepted")]
        [Validation(Required=false)]
        public bool? RunAccepted { get; set; }

        /// <summary>
        /// <para>The initial run status after submission. The value is WAITING when the run request is successfully accepted. To query the final status, call ListCrawlerRuns.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WAITING</para>
        /// </summary>
        [NameInMap("RunStatus")]
        [Validation(Required=false)]
        public string RunStatus { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The associated DataWorks task instance ID. This field may be empty. To query the final run record, call ListCrawlerRuns.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("TaskInstanceId")]
        [Validation(Required=false)]
        public long? TaskInstanceId { get; set; }

    }

}
