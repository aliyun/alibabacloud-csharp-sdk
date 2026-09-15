// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeContainerAppsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the container cluster. Note: This parameter is required. If this parameter is not specified, the service returns a 400 error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca0a686115432429ca26cf780f5e9fff5</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The page number for a paged query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The application value to query. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cas-adad-qeqwe</para>
        /// </summary>
        [NameInMap("FieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page for a paged query. Default value: 20. If you leave this parameter empty, 20 entries are returned.</para>
        /// <remarks>
        /// <para>Do not leave PageSize empty.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
