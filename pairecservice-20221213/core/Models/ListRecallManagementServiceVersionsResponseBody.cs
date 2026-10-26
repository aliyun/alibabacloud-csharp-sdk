// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListRecallManagementServiceVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of recall management service versions.</para>
        /// </summary>
        [NameInMap("RecallManagementServiceVersions")]
        [Validation(Required=false)]
        public List<ListRecallManagementServiceVersionsResponseBodyRecallManagementServiceVersions> RecallManagementServiceVersions { get; set; }
        public class ListRecallManagementServiceVersionsResponseBodyRecallManagementServiceVersions : TeaModel {
            /// <summary>
            /// <para>The creation time. The time follows the ISO 8601 standard and includes a time zone offset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The update time. The time follows the ISO 8601 standard and includes a time zone offset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the version is effective.</para>
            /// </summary>
            [NameInMap("IsEffective")]
            [Validation(Required=false)]
            public bool? IsEffective { get; set; }

            /// <summary>
            /// <para>The name of the recall management service version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>version-1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the recall management service version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RecallManagementServiceVersionId")]
            [Validation(Required=false)]
            public string RecallManagementServiceVersionId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
