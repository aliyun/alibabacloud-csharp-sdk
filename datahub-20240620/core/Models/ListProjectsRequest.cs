// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Datahub20240620.Models
{
    public class ListProjectsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dh</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9892074a2a89600ae4b0d5a34fb99a3f</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Pure")]
        [Validation(Required=false)]
        public bool? Pure { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Skip")]
        [Validation(Required=false)]
        public int? Skip { get; set; }

    }

}
