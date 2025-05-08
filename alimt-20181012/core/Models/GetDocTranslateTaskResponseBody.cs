// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class GetDocTranslateTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12952E92-FDF3-4D3C-88E3-242D72BA7150</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>translated</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0586df512c8b4bb382d7d9a6a01b5854</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Error</para>
        /// </summary>
        [NameInMap("TranslateErrorCode")]
        [Validation(Required=false)]
        public string TranslateErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Fail to get the page number of document.</para>
        /// </summary>
        [NameInMap("TranslateErrorMessage")]
        [Validation(Required=false)]
        public string TranslateErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://translateFileUrl">http://translateFileUrl</a></para>
        /// </summary>
        [NameInMap("TranslateFileUrl")]
        [Validation(Required=false)]
        public string TranslateFileUrl { get; set; }

    }

}
