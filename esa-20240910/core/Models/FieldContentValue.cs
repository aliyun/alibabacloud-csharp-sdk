// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class FieldContentValue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public long? SortOrder { get; set; }

        [NameInMap("FieldList")]
        [Validation(Required=false)]
        public List<FieldContentValueFieldList> FieldList { get; set; }
        public class FieldContentValueFieldList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ClientIp</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>IP address of the client.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DescriptionCn")]
            [Validation(Required=false)]
            public string DescriptionCn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Client</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>String</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SortOrder")]
            [Validation(Required=false)]
            public long? SortOrder { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

        }

    }

}
