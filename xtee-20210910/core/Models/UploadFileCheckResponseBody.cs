// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class UploadFileCheckResponseBody : TeaModel {
        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned object</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public UploadFileCheckResponseBodyResultObject ResultObject { get; set; }
        public class UploadFileCheckResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Number of effective rows</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("effectiveNumber")]
            [Validation(Required=false)]
            public int? EffectiveNumber { get; set; }

            /// <summary>
            /// <para>Valid sample data</para>
            /// </summary>
            [NameInMap("resultList")]
            [Validation(Required=false)]
            public List<string> ResultList { get; set; }

            /// <summary>
            /// <para>Total number of rows</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("totalNumber")]
            [Validation(Required=false)]
            public int? TotalNumber { get; set; }

        }

    }

}
