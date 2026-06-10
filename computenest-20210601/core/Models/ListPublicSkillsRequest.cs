// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListPublicSkillsRequest : TeaModel {
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListPublicSkillsRequestFilter> Filter { get; set; }
        public class ListPublicSkillsRequestFilter : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>SkillId</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedDownloadUrl")]
        [Validation(Required=false)]
        public bool? NeedDownloadUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAfu+XtuBE55iRLHEYYuojI4=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
