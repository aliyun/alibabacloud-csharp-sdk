// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetUserUploadFileJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BDEFE9F2-B3B4-42D0-83AE-ECF9FC067DCD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The details of the file upload task.</para>
        /// </summary>
        [NameInMap("UploadFileJobDetail")]
        [Validation(Required=false)]
        public GetUserUploadFileJobResponseBodyUploadFileJobDetail UploadFileJobDetail { get; set; }
        public class GetUserUploadFileJobResponseBodyUploadFileJobDetail : TeaModel {
            /// <summary>
            /// <para>The key of the file that is returned after the file is uploaded. You can use this key when you upload the file as an attachment in a ticket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>upload_3c7edea3-e4c3-4403-857d-737043036f69_test.sql</para>
            /// </summary>
            [NameInMap("AttachmentKey")]
            [Validation(Required=false)]
            public string AttachmentKey { get; set; }

            /// <summary>
            /// <para>The name of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.sql</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The size of the file. Unit: byte.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2968269</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// <para>The purpose of the uploaded file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>datacorrect</b>: The file is uploaded to change data.</description></item>
            /// <item><description><b>order_info_attachment</b>: The file is uploaded as an attachment in a ticket.</description></item>
            /// <item><description><b>big-file</b>: The file is uploaded to import multiple data records at a time.</description></item>
            /// <item><description><b>sqlreview</b>: The file is uploaded for SQL review.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>datacorrect</para>
            /// </summary>
            [NameInMap("FileSource")]
            [Validation(Required=false)]
            public string FileSource { get; set; }

            /// <summary>
            /// <para>The key of the file upload task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>65254a4c1614235217749100e</para>
            /// </summary>
            [NameInMap("JobKey")]
            [Validation(Required=false)]
            public string JobKey { get; set; }

            /// <summary>
            /// <para>The status of the file upload task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INIT</b>: The file upload task was initialized.</description></item>
            /// <item><description><b>PENDING</b>: The file upload task waited to be run.</description></item>
            /// <item><description><b>BE_SCHEDULED</b>: The file upload task waited to be scheduled.</description></item>
            /// <item><description><b>FAIL</b>: The file upload task failed.</description></item>
            /// <item><description><b>SUCCESS</b>: The file upload task was successful.</description></item>
            /// <item><description><b>RUNNING</b>: The file upload task was being run.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

            /// <summary>
            /// <para>The information about the status of the file upload task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("JobStatusDesc")]
            [Validation(Required=false)]
            public string JobStatusDesc { get; set; }

            /// <summary>
            /// <para>The information about the Object Storage Service (OSS) bucket from which the file is uploaded.</para>
            /// <remarks>
            /// <para>This parameter is returned if the value of <b>UploadType</b> is <b>OSS</b>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("UploadOSSParam")]
            [Validation(Required=false)]
            public GetUserUploadFileJobResponseBodyUploadFileJobDetailUploadOSSParam UploadOSSParam { get; set; }
            public class GetUserUploadFileJobResponseBodyUploadFileJobDetailUploadOSSParam : TeaModel {
                /// <summary>
                /// <para>The name of the OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_bucket</para>
                /// </summary>
                [NameInMap("BucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>The endpoint of the OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://oss-cn-hangzhou.aliyuncs.com">http://oss-cn-hangzhou.aliyuncs.com</a></para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The name of the OSS object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.sql</para>
                /// </summary>
                [NameInMap("ObjectName")]
                [Validation(Required=false)]
                public string ObjectName { get; set; }

            }

            /// <summary>
            /// <para>The method used to upload the file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>URL</b></description></item>
            /// <item><description><b>OSS</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>URL</para>
            /// </summary>
            [NameInMap("UploadType")]
            [Validation(Required=false)]
            public string UploadType { get; set; }

            /// <summary>
            /// <para>The URL of the file.</para>
            /// <remarks>
            /// <para>This parameter is returned if the value of <b>UploadType</b> is <b>URL</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxxx/test.sql">http://xxxx/test.sql</a></para>
            /// </summary>
            [NameInMap("UploadURL")]
            [Validation(Required=false)]
            public string UploadURL { get; set; }

            /// <summary>
            /// <para>The size of the uploaded file. Unit: byte.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2968269</para>
            /// </summary>
            [NameInMap("UploadedSize")]
            [Validation(Required=false)]
            public long? UploadedSize { get; set; }

        }

    }

}
