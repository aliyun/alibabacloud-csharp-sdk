// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class CreateFullBackupSetDownloadRequest : TeaModel {
        /// <summary>
        /// <para>The format in which the full backup set is downloaded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Native</b></description></item>
        /// <item><description><b>SQL</b></description></item>
        /// <item><description><b>CSV</b>(Default value)</description></item>
        /// <item><description><b>JSON</b></description></item>
        /// </list>
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
        /// <para>dbs1hv****</para>
        /// </summary>
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

    }

}
