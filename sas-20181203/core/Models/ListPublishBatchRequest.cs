// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListPublishBatchRequest : TeaModel {
        /// <summary>
        /// <para>The name of the release batch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>批次1</para>
        /// </summary>
        [NameInMap("BatchName")]
        [Validation(Required=false)]
        public string BatchName { get; set; }

        /// <summary>
        /// <para>The page number of the current page when paging is used.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page when paging is used.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The target version to upgrade to.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.9</para>
        /// </summary>
        [NameInMap("UpgradeVersion")]
        [Validation(Required=false)]
        public string UpgradeVersion { get; set; }

    }

}
