// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListRunsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>MyApp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4.1.4.1-v1.0</para>
        /// </summary>
        [NameInMap("AppRevision")]
        [Validation(Required=false)]
        public string AppRevision { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>S001</para>
        /// </summary>
        [NameInMap("EntityName")]
        [Validation(Required=false)]
        public string EntityName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sample</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("GetTotal")]
        [Validation(Required=false)]
        public bool? GetTotal { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsReversed")]
        [Validation(Required=false)]
        public bool? IsReversed { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>env=test</para>
        /// </summary>
        [NameInMap("LabelSelector")]
        [Validation(Required=false)]
        public string LabelSelector { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MTIzNDU2P1dvcmtzcGFjZT93cy1mMDE4OTgxNGU1ZTkK</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>createtime</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>run-13BeYuxc0fxO24uA75UppTiMRoQ</para>
        /// </summary>
        [NameInMap("Search")]
        [Validation(Required=false)]
        public string Search { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sub-13BeXWnGvrOl3MC124tazcJVKaV</para>
        /// </summary>
        [NameInMap("SubmissionId")]
        [Validation(Required=false)]
        public string SubmissionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-workspace</para>
        /// </summary>
        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
