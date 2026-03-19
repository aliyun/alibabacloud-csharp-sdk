// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class CreateFullBackupSetDownloadRequest : TeaModel {
        /// <summary>
        /// <para>The format of the downloaded full backup set. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Native</b></para>
        /// </description></item>
        /// <item><description><para><b>SQL</b></para>
        /// </description></item>
        /// <item><description><para><b>CSV</b></para>
        /// </description></item>
        /// <item><description><para><b>JSON</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The default value is CSV.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SQL</para>
        /// </summary>
        [NameInMap("BackupSetDataFormat")]
        [Validation(Required=false)]
        public string BackupSetDataFormat { get; set; }

        /// <summary>
        /// <para>The ID of the full backup set.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbs1hvXXXXX</para>
        /// </summary>
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        /// <summary>
        /// <para>A client token used to ensure the idempotence of the request. This prevents the same request from being sent multiple times.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

    }

}
