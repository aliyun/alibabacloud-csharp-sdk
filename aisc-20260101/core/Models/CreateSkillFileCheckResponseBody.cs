// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AISC20260101.Models
{
    public class CreateSkillFileCheckResponseBody : TeaModel {
        /// <summary>
        /// <para>The task creation result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateSkillFileCheckResponseBodyData Data { get; set; }
        public class CreateSkillFileCheckResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of files that failed to be uploaded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public int? FailCount { get; set; }

            /// <summary>
            /// <para>The ID of the root task returned after the task is submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c6e7fa8a77df6e182ac3fcf1478ab83a</para>
            /// </summary>
            [NameInMap("RootTaskId")]
            [Validation(Required=false)]
            public string RootTaskId { get; set; }

            /// <summary>
            /// <para>The number of files that are uploaded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

            /// <summary>
            /// <para>The upload results.</para>
            /// </summary>
            [NameInMap("UploadResults")]
            [Validation(Required=false)]
            public List<CreateSkillFileCheckResponseBodyDataUploadResults> UploadResults { get; set; }
            public class CreateSkillFileCheckResponseBodyDataUploadResults : TeaModel {
                /// <summary>
                /// <para>The error message returned when the file fails to be uploaded.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Network error.</para>
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// <para>The SHA256 value of the uploaded file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>514f44ebed1d0c1df5e16a116080b64b</para>
                /// </summary>
                [NameInMap("FileHash")]
                [Validation(Required=false)]
                public string FileHash { get; set; }

                /// <summary>
                /// <para>The name of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-file</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The unique ID of the uploaded file. You can use this ID to query the task result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1824jcadg01bsl10b</para>
                /// </summary>
                [NameInMap("IdentifyId")]
                [Validation(Required=false)]
                public string IdentifyId { get; set; }

                /// <summary>
                /// <para>Indicates whether the operation is successful. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Successful.</description></item>
                /// <item><description>false: Failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9FDE3D6F-26BD-5937-B0E5-8F47962B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
