// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryIProductionJobResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ImageCartoonize</para>
        /// </summary>
        [NameInMap("FunctionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://example-****.oss-cn-hangzhou.aliyuncs.com/example.mp4</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>88c6ca184c0e432bbf5b665e2a15****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{mode:&quot;gif&quot;}</para>
        /// </summary>
        [NameInMap("JobParams")]
        [Validation(Required=false)]
        public string JobParams { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://example-****.oss-cn-hangzhou.aliyuncs.com/iproduction/{source}-{timestamp}-{sequenceId}.srt</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>39f8e0bc005e4f309379701645f4****</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D127C68E-F1A1-4CE5-A874-8FF724881A12</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;Code&quot;:&quot;Success&quot;,&quot;Data&quot;:&quot;{\&quot;result\&quot;:[{\&quot;file\&quot;:\&quot;iproduction/test-result.jpg\&quot;},{\&quot;file\&quot;:\&quot;iproduction/test-origin.jpg\&quot;}]}&quot;,&quot;Message&quot;:&quot;Successful.&quot;}</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
