// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class ListCrossAccountsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123***7890</para>
        /// </summary>
        [NameInMap("CrossAccountOwnerId")]
        [Validation(Required=false)]
        public long? CrossAccountOwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MANUAL</para>
        /// </summary>
        [NameInMap("ManagementMode")]
        [Validation(Required=false)]
        public string ManagementMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cae**********699</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123***7890</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ACCOUNT</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
