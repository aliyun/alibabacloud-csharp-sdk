// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class ListValidateFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of files.</para>
        /// </summary>
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<ListValidateFileResponseBodyFiles> Files { get; set; }
        public class ListValidateFileResponseBodyFiles : TeaModel {
            /// <summary>
            /// <para>The number of addresses with the validation result \&quot;CatchAll\&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
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
            /// <para>The number of addresses with the validation result \&quot;DoNotMail\&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DoNotMailNum")]
            [Validation(Required=false)]
            public string DoNotMailNum { get; set; }

            /// <summary>
            /// <para>The file ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.csv</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The number of addresses with the validation result \&quot;Invalid\&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("InvalidNum")]
            [Validation(Required=false)]
            public string InvalidNum { get; set; }

            /// <summary>
            /// <para>Indicates whether the result can be downloaded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDownloadable")]
            [Validation(Required=false)]
            public bool? IsDownloadable { get; set; }

            /// <summary>
            /// <para>The task execution progress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100%</para>
            /// </summary>
            [NameInMap("Percentage")]
            [Validation(Required=false)]
            public string Percentage { get; set; }

            /// <summary>
            /// <para>The number of addresses that have been validated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ProcessedNum")]
            [Validation(Required=false)]
            public string ProcessedNum { get; set; }

            /// <summary>
            /// <para>The status of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>completed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The number of addresses to validate in the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public string TotalNum { get; set; }

            /// <summary>
            /// <para>The number of addresses with the validation result \&quot;Unknown\&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
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
            /// <para>The number of addresses with the validation result \&quot;Valid\&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ValidNum")]
            [Validation(Required=false)]
            public string ValidNum { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether a next page of data exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasNext")]
        [Validation(Required=false)]
        public bool? HasNext { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}
