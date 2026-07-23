// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListManagedDataKeyVersionsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the managed data key (DK) to query. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-data-key</para>
        /// </summary>
        [NameInMap("DataKeyName")]
        [Validation(Required=false)]
        public string DataKeyName { get; set; }

        /// <summary>
        /// <para>The page number. The value must be an integer greater than 0. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
