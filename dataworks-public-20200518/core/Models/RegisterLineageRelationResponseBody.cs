// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class RegisterLineageRelationResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1010210001</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The entity of lineage not exist, xxx</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The lineage.</para>
        /// </summary>
        [NameInMap("LineageRelation")]
        [Validation(Required=false)]
        public RegisterLineageRelationResponseBodyLineageRelation LineageRelation { get; set; }
        public class RegisterLineageRelationResponseBodyLineageRelation : TeaModel {
            /// <summary>
            /// <para>The unique identifier of the destination entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom-report.month_stat_user</para>
            /// </summary>
            [NameInMap("DestEntityQualifiedName")]
            [Validation(Required=false)]
            public string DestEntityQualifiedName { get; set; }

            /// <summary>
            /// <para>The ID of the lineage between entities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dfsldfdlsfdsaaaabbbb</para>
            /// </summary>
            [NameInMap("RelationshipGuid")]
            [Validation(Required=false)]
            public string RelationshipGuid { get; set; }

            /// <summary>
            /// <para>The unique identifier of the source entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>maxcompute-table.project.table</para>
            /// </summary>
            [NameInMap("SrcEntityQualifiedName")]
            [Validation(Required=false)]
            public string SrcEntityQualifiedName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE50E05E-028C-182B-9xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
