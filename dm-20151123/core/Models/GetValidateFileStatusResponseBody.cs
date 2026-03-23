// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class GetValidateFileStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of email addresses with the validation result \<c>CatchAll\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CatchAllNum")]
        [Validation(Required=false)]
        public string CatchAllNum { get; set; }

        /// <summary>
        /// <para>The time when the task was completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("CompleteTime")]
        [Validation(Required=false)]
        public string CompleteTime { get; set; }

        /// <summary>
        /// <para>The number of email addresses with the validation result \<c>DoNotMail\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DoNotMailNum")]
        [Validation(Required=false)]
        public string DoNotMailNum { get; set; }

        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The name of the file that was uploaded when the task was submitted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>file.txt</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The number of email addresses with the validation result \<c>Invalid\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("InvalidNum")]
        [Validation(Required=false)]
        public string InvalidNum { get; set; }

        /// <summary>
        /// <para>The progress of the task execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100%</para>
        /// </summary>
        [NameInMap("Percentage")]
        [Validation(Required=false)]
        public string Percentage { get; set; }

        /// <summary>
        /// <para>The number of email addresses that have been validated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ProcessedNum")]
        [Validation(Required=false)]
        public string ProcessedNum { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yyyy-yyyy-yyyy-yyyy</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>completed</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The total number of email addresses to validate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public string TotalNum { get; set; }

        /// <summary>
        /// <para>The number of email addresses with the validation result \<c>Unknown\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UnknownNum")]
        [Validation(Required=false)]
        public string UnknownNum { get; set; }

        /// <summary>
        /// <para>The time when the file was submitted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("UploadTime")]
        [Validation(Required=false)]
        public string UploadTime { get; set; }

        /// <summary>
        /// <para>The number of email addresses with the validation result \<c>Valid\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("ValidNum")]
        [Validation(Required=false)]
        public string ValidNum { get; set; }

    }

}
