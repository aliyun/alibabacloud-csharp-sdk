// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class RollbackEdgeContainerAppVersionRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-88068867578379****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test rollback app</para>
        /// </summary>
        [NameInMap("Remarks")]
        [Validation(Required=false)]
        public string Remarks { get; set; }

        /// <summary>
        /// <para>The ID of version that you want to roll back.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ver-87962637161651****</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
