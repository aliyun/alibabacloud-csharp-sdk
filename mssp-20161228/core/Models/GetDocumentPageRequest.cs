// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class GetDocumentPageRequest : TeaModel {
        /// <summary>
        /// <para>Current page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Delivered by.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("DeliveredBy")]
        [Validation(Required=false)]
        public string DeliveredBy { get; set; }

        /// <summary>
        /// <para>Document name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>季度报告</para>
        /// </summary>
        [NameInMap("DocumentName")]
        [Validation(Required=false)]
        public string DocumentName { get; set; }

        /// <summary>
        /// <para>Document type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DocumentType")]
        [Validation(Required=false)]
        public string DocumentType { get; set; }

        /// <summary>
        /// <para>Page size.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Report type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

    }

}
