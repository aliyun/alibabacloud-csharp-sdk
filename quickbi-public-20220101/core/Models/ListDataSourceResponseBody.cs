// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListDataSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7FC9A6A6-****-5CED-B*****E891E4075</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Array of data source information.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListDataSourceResponseBodyResult> Result { get; set; }
        public class ListDataSourceResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Quick BI user ID of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>281*****-485******-8</para>
            /// </summary>
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <para>Owner\&quot;s nickname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("CreatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// <para>Data source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7FC9A6A6-****-5CED-B*****E891E4075</para>
            /// </summary>
            [NameInMap("DatasourceId")]
            [Validation(Required=false)]
            public string DatasourceId { get; set; }

            /// <summary>
            /// <para>Data source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>odps</para>
            /// </summary>
            [NameInMap("DsType")]
            [Validation(Required=false)]
            public string DsType { get; set; }

            /// <summary>
            /// <para>Creation time of the data source, in yyyy-MM-dd HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-16 13:17:39</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>Modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-08-15 10:06:31</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Primary data source type for multi-engine data sources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dataphin</para>
            /// </summary>
            [NameInMap("ParentDsType")]
            [Validation(Required=false)]
            public string ParentDsType { get; set; }

            /// <summary>
            /// <para>Display name of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0327</para>
            /// </summary>
            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

        }

        /// <summary>
        /// <para>Whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
