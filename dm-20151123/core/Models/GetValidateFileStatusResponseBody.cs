// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class GetValidateFileStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of catch-all addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CatchAllNum")]
        [Validation(Required=false)]
        public string CatchAllNum { get; set; }

        /// <summary>
        /// <para>The task completion time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("CompleteTime")]
        [Validation(Required=false)]
        public string CompleteTime { get; set; }

        /// <summary>
        /// <para>The number of do-not-mail addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DoNotMailNum")]
        [Validation(Required=false)]
        public string DoNotMailNum { get; set; }

        /// <summary>
        /// <para>The file ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx-xxxx</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The file name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>file.txt</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The number of invalid addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("InvalidNum")]
        [Validation(Required=false)]
        public string InvalidNum { get; set; }

        /// <summary>
        /// <para>The task completion percentage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100%</para>
        /// </summary>
        [NameInMap("Percentage")]
        [Validation(Required=false)]
        public string Percentage { get; set; }

        /// <summary>
        /// <para>The number of processed addresses.</para>
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
        /// <para>The total number of addresses in the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public string TotalNum { get; set; }

        /// <summary>
        /// <para>The number of unknown addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UnknownNum")]
        [Validation(Required=false)]
        public string UnknownNum { get; set; }

        /// <summary>
        /// <para>The upload time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("UploadTime")]
        [Validation(Required=false)]
        public string UploadTime { get; set; }

        /// <summary>
        /// <para>The number of valid addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("ValidNum")]
        [Validation(Required=false)]
        public string ValidNum { get; set; }

    }

}
