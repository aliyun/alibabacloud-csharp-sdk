// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeDocumentStructureResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>noPermission</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{ 	&quot;content&quot;: &quot;2017年河北区实验小学&quot;, 	&quot;height&quot;: 3509, 	&quot;orgHeight&quot;: 3509, 	&quot;orgWidth&quot;: 2512, 	&quot;prism_version&quot;: &quot;1.0.9&quot;, 	&quot;prism_wnum&quot;: 126, 	&quot;prism_wordsInfo&quot;: [{ 		&quot;angle&quot;: -89, 		&quot;direction&quot;: 0, 		&quot;height&quot;: 541, 		&quot;pos&quot;: [{ 			&quot;x&quot;: 982, 			&quot;y&quot;: 223 		}, { 			&quot;x&quot;: 1522, 			&quot;y&quot;: 223 		}, { 			&quot;x&quot;: 1522, 			&quot;y&quot;: 266 		}, { 			&quot;x&quot;: 982, 			&quot;y&quot;: 266 		}], 		&quot;prob&quot;: 99, 		&quot;width&quot;: 43, 		&quot;word&quot;: &quot;2017年河北区实验小学&quot;, 		&quot;x&quot;: 1230, 		&quot;y&quot;: -26 	}], 	&quot;width&quot;: 2512 }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>You are not authorized to perform this operation.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>43A29C77-405E-4CC0-BC55-EE694AD00655</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
