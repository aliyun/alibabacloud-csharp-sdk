// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListDynamicTagResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A**********DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The label list.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListDynamicTagResponseBodyResult> Result { get; set; }
        public class ListDynamicTagResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The column name of the associated data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>site_id</para>
            /// </summary>
            [NameInMap("ColumnName")]
            [Validation(Required=false)]
            public string ColumnName { get; set; }

            /// <summary>
            /// <para>The ID of the individual configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cfg****14352318681088</para>
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public string ConfigId { get; set; }

            /// <summary>
            /// <para>The name of the label configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eip</para>
            /// </summary>
            [NameInMap("ConfigName")]
            [Validation(Required=false)]
            public string ConfigName { get; set; }

            /// <summary>
            /// <para>The ID of the associated data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a201c85c-******</para>
            /// </summary>
            [NameInMap("DsId")]
            [Validation(Required=false)]
            public string DsId { get; set; }

            /// <summary>
            /// <para>The organization ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2fe4fbd8-<b><b>-</b></b>-b3e1-e92c7af083ea</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            /// <summary>
            /// <para>The associated user attribute. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: account ID</description></item>
            /// <item><description>1: account name</description></item>
            /// <item><description>2: nickname within the organization</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RelatedAttribute")]
            [Validation(Required=false)]
            public int? RelatedAttribute { get; set; }

            /// <summary>
            /// <para>The table name of the associated data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testTable02\&quot;\&quot;</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
