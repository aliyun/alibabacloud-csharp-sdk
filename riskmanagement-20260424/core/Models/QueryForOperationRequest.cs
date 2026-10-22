// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class QueryForOperationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1791937232000</para>
        /// </summary>
        [NameInMap("ApplyTimeEnd")]
        [Validation(Required=false)]
        public long? ApplyTimeEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1791937132000</para>
        /// </summary>
        [NameInMap("ApplyTimeStart")]
        [Validation(Required=false)]
        public long? ApplyTimeStart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EIP</para>
        /// </summary>
        [NameInMap("AssetType")]
        [Validation(Required=false)]
        public string AssetType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1791937232000</para>
        /// </summary>
        [NameInMap("AuditTimeEnd")]
        [Validation(Required=false)]
        public long? AuditTimeEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1791937132000</para>
        /// </summary>
        [NameInMap("AuditTimeStart")]
        [Validation(Required=false)]
        public long? AuditTimeStart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1647796581073291</para>
        /// </summary>
        [NameInMap("CustomerUid")]
        [Validation(Required=false)]
        public string CustomerUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12.3*.22.11</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>approved</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
