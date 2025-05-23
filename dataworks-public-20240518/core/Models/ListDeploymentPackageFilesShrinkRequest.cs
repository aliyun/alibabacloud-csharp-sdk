// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDeploymentPackageFilesShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>100001</para>
        /// </summary>
        [NameInMap("BusinessId")]
        [Validation(Required=false)]
        public long? BusinessId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ChangeType")]
        [Validation(Required=false)]
        public int? ChangeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-01-01</para>
        /// </summary>
        [NameInMap("CommitFrom")]
        [Validation(Required=false)]
        public string CommitFrom { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-01-31</para>
        /// </summary>
        [NameInMap("CommitTo")]
        [Validation(Required=false)]
        public string CommitTo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2003****</para>
        /// </summary>
        [NameInMap("CommitUserId")]
        [Validation(Required=false)]
        public string CommitUserId { get; set; }

        [NameInMap("FileIds")]
        [Validation(Required=false)]
        public string FileIdsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Filename</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public int? FileType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8065</para>
        /// </summary>
        [NameInMap("SolutionId")]
        [Validation(Required=false)]
        public long? SolutionId { get; set; }

    }

}
