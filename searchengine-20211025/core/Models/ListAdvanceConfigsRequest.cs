// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListAdvanceConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The data source name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ha-cn-pl32rf0****_test_api</para>
        /// </summary>
        [NameInMap("dataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// <para>The index name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_api</para>
        /// </summary>
        [NameInMap("indexName")]
        [Validation(Required=false)]
        public string IndexName { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the new version of the page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("newMode")]
        [Validation(Required=false)]
        public bool? NewMode { get; set; }

        /// <summary>
        /// <para>The page number. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. The default value is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The type of the advanced configuration. Valid values:
        /// \- online
        /// \- offline (default)</para>
        /// 
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
