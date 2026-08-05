// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class GetEdgeTranscodeJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The edge transcoding job.</para>
        /// </summary>
        [NameInMap("Job")]
        [Validation(Required=false)]
        public GetEdgeTranscodeJobResponseBodyJob Job { get; set; }
        public class GetEdgeTranscodeJobResponseBodyJob : TeaModel {
            /// <summary>
            /// <para>The time when the job was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-24T16:44:55Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The time when the job was last started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-25T02:48:58Z</para>
            /// </summary>
            [NameInMap("LastStartAt")]
            [Validation(Required=false)]
            public string LastStartAt { get; set; }

            /// <summary>
            /// <para>The time when the job was last stopped.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-25T05:48:58Z</para>
            /// </summary>
            [NameInMap("LastStopAt")]
            [Validation(Required=false)]
            public string LastStopAt { get; set; }

            /// <summary>
            /// <para>The job name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my_job</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The status of the transcoding job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: The job is not started.</para>
            /// </description></item>
            /// <item><description><para>1: The job is running.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The input stream URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtmp://mydomain/app/stream1</para>
            /// </summary>
            [NameInMap("StreamInput")]
            [Validation(Required=false)]
            public string StreamInput { get; set; }

            /// <summary>
            /// <para>The output stream URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtmp://testdomain/app/stream2</para>
            /// </summary>
            [NameInMap("StreamOutput")]
            [Validation(Required=false)]
            public string StreamOutput { get; set; }

            /// <summary>
            /// <para>The ID of the edge transcoding template used by the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9b1571b513cb44f7a1ba6ae561ff****</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The name of the edge transcoding template used by the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my_template</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The type of edge transcoding. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>common: standard transcoding and Narrowband HD 1.0.</para>
            /// </description></item>
            /// <item><description><para>nbhd-2: Narrowband HD 2.0.</para>
            /// </description></item>
            /// <item><description><para>ultra-hd: ultra-high definition.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>common</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
