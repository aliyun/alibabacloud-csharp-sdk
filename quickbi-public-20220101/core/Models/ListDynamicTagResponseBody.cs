// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListDynamicTagResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>D787E1A**********DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListDynamicTagResponseBodyResult> Result { get; set; }
        public class ListDynamicTagResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>site_id</para>
            /// </summary>
            [NameInMap("ColumnName")]
            [Validation(Required=false)]
            public string ColumnName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cfg****14352318681088</para>
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public string ConfigId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eip</para>
            /// </summary>
            [NameInMap("ConfigName")]
            [Validation(Required=false)]
            public string ConfigName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a201c85c-******</para>
            /// </summary>
            [NameInMap("DsId")]
            [Validation(Required=false)]
            public string DsId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2fe4fbd8-<b><b>-</b></b>-b3e1-e92c7af083ea</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RelatedAttribute")]
            [Validation(Required=false)]
            public int? RelatedAttribute { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testTable02\&quot;\&quot;</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
