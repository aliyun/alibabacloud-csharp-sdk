// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageRepoListRequest : TeaModel {
        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The name of the field that is used for the query. Valid values:
        /// 
        /// *   **repoName**: the name of the image repository
        /// *   **repoNamespace**: the namespace to which the image repository belongs
        /// 
        /// >  This parameter takes effect only when the **OperateType** parameter is set to **other**.
        /// </summary>
        [NameInMap("FieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// The value of the field that is used for the query.
        /// 
        /// >  This parameter takes effect only when the **OperateType** parameter is set to **other**.
        /// </summary>
        [NameInMap("FieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

        /// <summary>
        /// The type of the operation. Valid values:
        /// 
        /// *   **count**: counts statistics
        /// *   **other**: others
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.
        /// 
        /// >  We recommend that you do not leave this parameter empty.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The name of the image repository.
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// The namespace to which the image repository belongs.
        /// </summary>
        [NameInMap("RepoNamespace")]
        [Validation(Required=false)]
        public string RepoNamespace { get; set; }

        /// <summary>
        /// The condition by which the feature is applied. Valid values:
        /// 
        /// *   **image_repo**: the ID of the image repository
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// The type of the feature. Valid values:
        /// 
        /// *   **image_repo**: image repository protection
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
