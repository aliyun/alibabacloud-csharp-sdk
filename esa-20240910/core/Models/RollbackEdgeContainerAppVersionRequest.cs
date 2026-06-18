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
        /// <para>The deployment percentage for the target version after the rollback. Valid values: <b>1 to 100</b>. Default value: <b>0</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("Percentage")]
        [Validation(Required=false)]
        public int? Percentage { get; set; }

        /// <summary>
        /// <para>Additional information about the rollback.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test rollback app</para>
        /// </summary>
        [NameInMap("Remarks")]
        [Validation(Required=false)]
        public string Remarks { get; set; }

        /// <summary>
        /// <para>Specifies whether to use percentage rollback.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UsedPercent")]
        [Validation(Required=false)]
        public bool? UsedPercent { get; set; }

        /// <summary>
        /// <para>The ID of the version to roll back to.</para>
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
