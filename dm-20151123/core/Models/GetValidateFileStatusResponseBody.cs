// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class GetValidateFileStatusResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CatchAllNum")]
        [Validation(Required=false)]
        public string CatchAllNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2000-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("CompleteTime")]
        [Validation(Required=false)]
        public string CompleteTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DoNotMailNum")]
        [Validation(Required=false)]
        public string DoNotMailNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>file.txt</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("InvalidNum")]
        [Validation(Required=false)]
        public string InvalidNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100%</para>
        /// </summary>
        [NameInMap("Percentage")]
        [Validation(Required=false)]
        public string Percentage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ProcessedNum")]
        [Validation(Required=false)]
        public string ProcessedNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>yyyy-yyyy-yyyy-yyyy</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>completed</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public string TotalNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UnknownNum")]
        [Validation(Required=false)]
        public string UnknownNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2000-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("UploadTime")]
        [Validation(Required=false)]
        public string UploadTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("ValidNum")]
        [Validation(Required=false)]
        public string ValidNum { get; set; }

    }

}
