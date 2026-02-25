// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListParameterSetRelationResponseBody : TeaModel {
        [NameInMap("parameterSets")]
        [Validation(Required=false)]
        public List<ListParameterSetRelationResponseBodyParameterSets> ParameterSets { get; set; }
        public class ListParameterSetRelationResponseBodyParameterSets : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-05-14T10:05:19Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123111</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alb_enable_ipv6_4.2</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pts-kw1b11jlssrabb638ptums</para>
            /// </summary>
            [NameInMap("parameterSetId")]
            [Validation(Required=false)]
            public string ParameterSetId { get; set; }

            [NameInMap("parameters")]
            [Validation(Required=false)]
            public Dictionary<string, string> Parameters { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2F24E990-E8D3-5C18-ABEA-C7A3F1831C57</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
