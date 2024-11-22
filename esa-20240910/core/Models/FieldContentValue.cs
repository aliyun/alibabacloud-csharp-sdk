// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class FieldContentValue : TeaModel {
        /// <summary>
        /// <para>The sequence number of the fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public long? SortOrder { get; set; }

        /// <summary>
        /// <para>The fields.</para>
        /// </summary>
        [NameInMap("FieldList")]
        [Validation(Required=false)]
        public List<FieldContentValueFieldList> FieldList { get; set; }
        public class FieldContentValueFieldList : TeaModel {
            /// <summary>
            /// <para>The field name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ClientIp</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <para>The description of the field in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IP address of the client.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The description of the field in Chinese.</para>
            /// </summary>
            [NameInMap("DescriptionCn")]
            [Validation(Required=false)]
            public string DescriptionCn { get; set; }

            /// <summary>
            /// <para>The category of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Client</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The data type of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>String</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// <para>The sequence number of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SortOrder")]
            [Validation(Required=false)]
            public long? SortOrder { get; set; }

            /// <summary>
            /// <para>Indicates whether the field is available by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

        }

    }

}
