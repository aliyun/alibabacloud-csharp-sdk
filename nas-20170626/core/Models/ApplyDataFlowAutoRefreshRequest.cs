// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ApplyDataFlowAutoRefreshRequest : TeaModel {
        /// <summary>
        /// <para>The auto-refresh interval. At each interval, CPFS checks whether data in the directory is updated. If data updates exist, CPFS starts an auto-refresh task. Unit: minutes.</para>
        /// <para>Valid values: 10 to 525600. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AutoRefreshInterval")]
        [Validation(Required=false)]
        public long? AutoRefreshInterval { get; set; }

        /// <summary>
        /// <para>The auto-refresh policy. This policy specifies how data updates in the source are imported into CPFS after the source data is updated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>None: Data updates in the source are not automatically imported into CPFS. You can use a data flow task to import data updates from the source.</description></item>
        /// <item><description>ImportChanged: Data updates in the source are automatically imported into CPFS.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AutoRefreshPolicy")]
        [Validation(Required=false)]
        public string AutoRefreshPolicy { get; set; }

        /// <summary>
        /// <para>The auto-refresh configurations.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AutoRefreshs")]
        [Validation(Required=false)]
        public List<ApplyDataFlowAutoRefreshRequestAutoRefreshs> AutoRefreshs { get; set; }
        public class ApplyDataFlowAutoRefreshRequestAutoRefreshs : TeaModel {
            /// <summary>
            /// <para>The auto-refresh directory. CPFS automatically checks only whether source data in this directory is updated and automatically imports the updated data.</para>
            /// <para>Limits:</para>
            /// <list type="bullet">
            /// <item><description>The value must be 2 to 1024 characters in length.</description></item>
            /// <item><description>The value must be encoded in UTF-8.</description></item>
            /// <item><description>The value must start and end with a forward slash (/).</description></item>
            /// </list>
            /// <remarks>
            /// <para>The directory must be an existing directory on CPFS and must be located in a Fileset for which data flow is enabled.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/prefix1/prefix2/</para>
            /// </summary>
            [NameInMap("RefreshPath")]
            [Validation(Required=false)]
            public string RefreshPath { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can generate a value from your client to ensure that the value is unique among different requests.</para>
        /// <para>The ClientToken parameter supports only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The data flow ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>df-194433a5be31****</para>
        /// </summary>
        [NameInMap("DataFlowId")]
        [Validation(Required=false)]
        public string DataFlowId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on this creation request.</para>
        /// <para>A dry run checks parameter validity and inventory. It does not actually create an instance or incur fees.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Sends a check request and does not create an instance. Check items include whether required parameters are specified, the request format, service limits, and NAS inventory. If the check fails, the system returns the corresponding error. If the check succeeds, the system returns HTTP status code 200, but FileSystemId is empty.</description></item>
        /// <item><description>false (default): Sends a normal request. After the check succeeds, the system creates the instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The file system ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpfs-099394bd928c****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

    }

}
