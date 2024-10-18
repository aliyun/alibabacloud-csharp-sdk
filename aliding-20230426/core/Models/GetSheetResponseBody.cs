// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetSheetResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("columnCount")]
        [Validation(Required=false)]
        public long? ColumnCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>stxxxx</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("lastNonEmptyColumn")]
        [Validation(Required=false)]
        public long? LastNonEmptyColumn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("lastNonEmptyRow")]
        [Validation(Required=false)]
        public long? LastNonEmptyRow { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Sheet1</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("rowCount")]
        [Validation(Required=false)]
        public long? RowCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>visible</para>
        /// </summary>
        [NameInMap("visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
