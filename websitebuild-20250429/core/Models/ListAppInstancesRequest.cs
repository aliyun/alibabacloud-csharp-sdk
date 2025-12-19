// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ListAppInstancesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>WS20250731233102000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-12-18T14:30:00Z</para>
        /// </summary>
        [NameInMap("EndTimeBegin")]
        [Validation(Required=false)]
        public string EndTimeBegin { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-12-31T14:30:00Z</para>
        /// </summary>
        [NameInMap("EndTimeEnd")]
        [Validation(Required=false)]
        public string EndTimeEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAARbaCuN6hiD08qrLdwJ9Fh3BFw8paIJ7ylB6A7Qn9JjM</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>gmtCreated</para>
        /// </summary>
        [NameInMap("OrderColumn")]
        [Validation(Required=false)]
        public string OrderColumn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DOWNGRADE</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;RequestId\&quot;:\&quot;\&quot;}</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<string> StatusList { get; set; }

    }

}
