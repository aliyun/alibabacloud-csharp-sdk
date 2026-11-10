// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class ModifyBackupSetDownloadRulesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup gateway used to download the backup set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23312323</para>
        /// </summary>
        [NameInMap("BackupGatewayId")]
        [Validation(Required=false)]
        public long? BackupGatewayId { get; set; }

        /// <summary>
        /// <para>The ID of the backup plan. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbstooi01xxxx</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>The server directory to which the backup set is downloaded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("BackupSetDownloadDir")]
        [Validation(Required=false)]
        public string BackupSetDownloadDir { get; set; }

        /// <summary>
        /// <para>The target type for downloading the backup set.</para>
        /// <remarks>
        /// <para>Default value: agent. A backup gateway is installed. This is the only supported value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>agent</para>
        /// </summary>
        [NameInMap("BackupSetDownloadTargetType")]
        [Validation(Required=false)]
        public string BackupSetDownloadTargetType { get; set; }

        /// <summary>
        /// <para>The target directory type for downloading the backup set. This parameter is required if automatic download is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>local</description></item>
        /// <item><description>nas</description></item>
        /// <item><description>ftp</description></item>
        /// <item><description>minio</description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: local.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>local</para>
        /// </summary>
        [NameInMap("BackupSetDownloadTargetTypeLocation")]
        [Validation(Required=false)]
        public string BackupSetDownloadTargetTypeLocation { get; set; }

        /// <summary>
        /// <para>The client token used to ensure the idempotence of the request and prevent duplicate request submissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The format of the full data downloaded from the backup set. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Native</description></item>
        /// <item><description>SQL</description></item>
        /// <item><description>CSV</description></item>
        /// <item><description>JSON</description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: CSV.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CSV</para>
        /// </summary>
        [NameInMap("FullDataFormat")]
        [Validation(Required=false)]
        public string FullDataFormat { get; set; }

        /// <summary>
        /// <para>The format of the incremental data downloaded from the backup set. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Native</description></item>
        /// <item><description>SQL</description></item>
        /// <item><description>CSV</description></item>
        /// <item><description>JSON</description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: Native.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Native</para>
        /// </summary>
        [NameInMap("IncrementDataFormat")]
        [Validation(Required=false)]
        public string IncrementDataFormat { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic download. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OpenAutoDownload")]
        [Validation(Required=false)]
        public bool? OpenAutoDownload { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

    }

}
