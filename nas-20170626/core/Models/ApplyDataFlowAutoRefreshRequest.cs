// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ApplyDataFlowAutoRefreshRequest : TeaModel {
        /// <summary>
        /// <para>The auto-refresh interval. CPFS checks the directory for data updates at this interval. If data updates exist, an auto-refresh task is started. Unit: minutes.</para>
        /// <para>Valid values: 10 to 525600. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AutoRefreshInterval")]
        [Validation(Required=false)]
        public long? AutoRefreshInterval { get; set; }

        /// <summary>
        /// <para>The auto-refresh policy. This policy determines how data updates from the source are imported to CPFS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>None: Data updates from the source are not automatically imported to CPFS. You can use a data flow task to import data updates from the source.</description></item>
        /// <item><description>ImportChanged: Data updates from the source are automatically imported to CPFS.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AutoRefreshPolicy")]
        [Validation(Required=false)]
        public string AutoRefreshPolicy { get; set; }

        /// <summary>
        /// <para>The collection of auto-refresh configurations.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AutoRefreshs")]
        [Validation(Required=false)]
        public List<ApplyDataFlowAutoRefreshRequestAutoRefreshs> AutoRefreshs { get; set; }
        public class ApplyDataFlowAutoRefreshRequestAutoRefreshs : TeaModel {
            /// <summary>
            /// <para>The auto-refresh directory. CPFS automatically checks whether data in this directory on the source has been updated and imports the updated data.</para>
            /// <para>Limits:</para>
            /// <list type="bullet">
            /// <item><description>The path must be 2 to 1,024 characters in length.</description></item>
            /// <item><description>The path must be encoded in UTF-8.</description></item>
            /// <item><description>The path must start and end with a forward slash (/).</description></item>
            /// </list>
            /// <remarks>
            /// <para>The directory must already exist in CPFS and must be in a fileset that has data flow enabled.</para>
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
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests.</para>
        /// <para>The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId may differ for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the data flow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>df-194433a5be31****</para>
        /// </summary>
        [NameInMap("DataFlowId")]
        [Validation(Required=false)]
        public string DataFlowId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run for this request.</para>
        /// <para>A dry run checks parameter validity and resource availability without actually creating an instance or incurring charges.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Sends a dry run request without creating an instance. The check items include required parameters, request format, business limits, and NAS inventory. If the check fails, the corresponding error is returned. If the check succeeds, HTTP status code 200 is returned, but FileSystemId is empty.</description></item>
        /// <item><description>false (default): Sends a normal request. After the check succeeds, the instance is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the file system.</para>
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
