// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListFpShotImportJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The jobs of importing text files to a text fingerprint library.</para>
        /// </summary>
        [NameInMap("FpShotImportJobList")]
        [Validation(Required=false)]
        public List<ListFpShotImportJobResponseBodyFpShotImportJobList> FpShotImportJobList { get; set; }
        public class ListFpShotImportJobResponseBodyFpShotImportJobList : TeaModel {
            /// <summary>
            /// <para>The error code returned when the job fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The time when the job was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-30T00:33:18Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the job was completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-30T00:34:02Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The ID of the text fingerprint library.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2288c6ca184c0e47098a5b665e2a12****</para>
            /// </summary>
            [NameInMap("FpDBId")]
            [Validation(Required=false)]
            public string FpDBId { get; set; }

            /// <summary>
            /// <para>The import configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("FpImportConfig")]
            [Validation(Required=false)]
            public string FpImportConfig { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25bacf2824614bcf9273dc0744db****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The input file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Bucket\&quot;:\&quot;mts-example****\&quot;,\&quot;Location\&quot;:\&quot;oss-cn-shanghai\&quot;,\&quot;Object\&quot;:\&quot;test-0828/video/test.mp4\&quot;}</para>
            /// </summary>
            [NameInMap("Input")]
            [Validation(Required=false)]
            public string Input { get; set; }

            /// <summary>
            /// <para>The error message returned when the job fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The ID of the ApsaraVideo Media Processing (MPS) queue to which the job is submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ebb51ee30f0b49aba959823fa991****</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <para>The processing information of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://testbucket.oss-cn-shanghai.aliyuncs.com/932ajjw***32ssoj_importResult.txt">http://testbucket.oss-cn-shanghai.aliyuncs.com/932ajjw***32ssoj_importResult.txt</a></para>
            /// </summary>
            [NameInMap("ProcessMessage")]
            [Validation(Required=false)]
            public string ProcessMessage { get; set; }

            /// <summary>
            /// <para>The status of the job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Processing: The job is in progress.</description></item>
            /// <item><description>Fail: The job fails.</description></item>
            /// <item><description>Success: The job is successful.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The user-defined data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>001</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>The job IDs that do not exist. This parameter is not returned if all specified job IDs exist.</para>
        /// </summary>
        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public List<string> NonExistIds { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A13-BEF6-D7393642CA58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
