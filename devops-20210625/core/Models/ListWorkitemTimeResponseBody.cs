// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListWorkitemTimeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Openapi.RequestError</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>error</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ASSDS-ASSASX-XSAXSA-XSAXSAXS</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("workitemTime")]
        [Validation(Required=false)]
        public List<ListWorkitemTimeResponseBodyWorkitemTime> WorkitemTime { get; set; }
        public class ListWorkitemTimeResponseBodyWorkitemTime : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("actualTime")]
            [Validation(Required=false)]
            public float? ActualTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>开发代码等</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1653235200000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1653235200000</para>
            /// </summary>
            [NameInMap("gmtEnd")]
            [Validation(Required=false)]
            public long? GmtEnd { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1653235200000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1653235200000</para>
            /// </summary>
            [NameInMap("gmtStart")]
            [Validation(Required=false)]
            public long? GmtStart { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a4ac3a81e90217db32b7......</para>
            /// </summary>
            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1967043931......</para>
            /// </summary>
            [NameInMap("recordUser")]
            [Validation(Required=false)]
            public string RecordUser { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>研发</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5daa9a15c7fd55523996......</para>
            /// </summary>
            [NameInMap("workitemIdentifier")]
            [Validation(Required=false)]
            public string WorkitemIdentifier { get; set; }

        }

    }

}
