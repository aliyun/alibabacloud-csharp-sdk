// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class GetAvailableParserTypesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DataCenter.Throttling</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAvailableParserTypesResponseBodyData Data { get; set; }
        public class GetAvailableParserTypesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>pdf</para>
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            [NameInMap("ParserList")]
            [Validation(Required=false)]
            public List<GetAvailableParserTypesResponseBodyDataParserList> ParserList { get; set; }
            public class GetAvailableParserTypesResponseBodyDataParserList : TeaModel {
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DOCMIND</para>
                /// </summary>
                [NameInMap("Parser")]
                [Validation(Required=false)]
                public string Parser { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>User not authorized to operate on the specified resource</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>17204B98-7734-4F9A-8464-2446XXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
