// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateDataFlowRequest : TeaModel {
        /// <summary>
        /// <para>The auto-refresh interval. CPFS General-purpose checks the directory for data updates at this interval. If data updates exist, an auto-refresh task is started. Unit: minutes.</para>
        /// <para>Valid values: 10 to 525600. Default value: 10.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when the file system type is CPFS General-purpose.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AutoRefreshInterval")]
        [Validation(Required=false)]
        public long? AutoRefreshInterval { get; set; }

        /// <summary>
        /// <para>The auto-refresh policy. Specifies the policy for importing data updates from the source storage to CPFS General-purpose after the source data is updated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>None (default): Data updates in the source storage are not automatically imported to CPFS General-purpose. You can import data updates from the source storage by using a data flow task.</description></item>
        /// <item><description>ImportChanged: Data updates in the source storage are automatically imported to CPFS General-purpose.<remarks>
        /// <para>This parameter takes effect only when the file system type is CPFS General-purpose.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AutoRefreshPolicy")]
        [Validation(Required=false)]
        public string AutoRefreshPolicy { get; set; }

        /// <summary>
        /// <para>The auto-refresh configuration collection.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when the file system type is CPFS General-purpose.</para>
        /// </remarks>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("AutoRefreshs")]
        [Validation(Required=false)]
        public List<CreateDataFlowRequestAutoRefreshs> AutoRefreshs { get; set; }
        public class CreateDataFlowRequestAutoRefreshs : TeaModel {
            /// <summary>
            /// <para>The auto-refresh directory. CPFS General-purpose registers data modification events from the source storage and checks whether the source data in this directory has been updated, then automatically imports the updated data.</para>
            /// <para>The default value is empty, which means that data updates in the source storage are not automatically imported to CPFS General-purpose. You must manually create a task to import updates.</para>
            /// <para>Limits:</para>
            /// <list type="bullet">
            /// <item><description>The path must be 2 to 1024 characters in length.</description></item>
            /// <item><description>UTF-8 encoding is used.</description></item>
            /// <item><description>The path must start and end with a forward slash (/).</description></item>
            /// <item><description>The directory must be an existing directory in the CPFS General-purpose file system and must be located within the Fileset directory of the data flow.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>/prefix1/prefix2/</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("RefreshPath")]
            [Validation(Required=false)]
            public string RefreshPath { get; set; }

        }

        /// <summary>
        /// <para>Ensures the idempotence of the request. Generate a parameter value from your client to ensure that the value is unique across different requests.</para>
        /// <para>ClientToken supports only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
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
        /// <para>The description of the data flow.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The description must be 2 to 128 characters in length.</description></item>
        /// <item><description>The description must start with a letter.</description></item>
        /// <item><description>The description cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>The description can contain digits, colons (:), underscores (_), and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Bucket01 DataFlow</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run for this create request.</para>
        /// <para>A dry run checks parameter validity and resource availability without actually creating the instance or incurring charges.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Sends a dry run request without creating the instance. The check items include required parameters, request format, business limits, and NAS inventory. If the check fails, the corresponding error is returned. If the check succeeds, HTTP status code 200 is returned, but FileSystemId is empty.</description></item>
        /// <item><description>false (default): Sends a normal request and creates the instance after the check is passed.</description></item>
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
        /// <list type="bullet">
        /// <item><description><para>CPFS General-purpose: must start with <c>cpfs-</c>, such as cpfs-125487\<em>\</em>\<em>\</em>.</para>
        /// </description></item>
        /// <item><description><para>CPFS for Lingjun: must start with <c>bmcpfs-</c>, such as bmcpfs-0015\<em>\</em>\<em>\</em>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpfs-099394bd928c****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The directory in the CPFS for Lingjun file system. Limits:</para>
        /// <list type="bullet">
        /// <item><description><para>The path must start and end with a forward slash (/).</para>
        /// </description></item>
        /// <item><description><para>The directory must be an existing directory in the CPFS for Lingjun file system.</para>
        /// </description></item>
        /// <item><description><para>The path must be 1 to 1023 characters in length.</para>
        /// </description></item>
        /// <item><description><para>UTF-8 encoding is used.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when the file system type is CPFS for Lingjun.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/path/</para>
        /// </summary>
        [NameInMap("FileSystemPath")]
        [Validation(Required=false)]
        public string FileSystemPath { get; set; }

        /// <summary>
        /// <para>The Fileset ID.</para>
        /// <remarks>
        /// <para>This parameter is required when the file system type is CPFS General-purpose.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>fset-1902718ea0ae****</para>
        /// </summary>
        [NameInMap("FsetId")]
        [Validation(Required=false)]
        public string FsetId { get; set; }

        /// <summary>
        /// <para>The security protection type of the source storage. If the source storage must be accessed through security protection, specify the security protection type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>None (default): The source storage does not require security protection for access.</description></item>
        /// <item><description>SSL: Access is protected by an SSL certificate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SSL</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("SourceSecurityType")]
        [Validation(Required=false)]
        public string SourceSecurityType { get; set; }

        /// <summary>
        /// <para>The access address of the source storage. Format: <c>&lt;storage type&gt;://[&lt;account id&gt;:]&lt;path&gt;</c>.</para>
        /// <para>Where:</para>
        /// <list type="bullet">
        /// <item><description><para>storage type: only oss is supported.</para>
        /// </description></item>
        /// <item><description><para>account id: optional. The UID of the account that owns the source storage. This parameter is required when you use cross-account OSS.</para>
        /// </description></item>
        /// <item><description><para>path: the name of the OSS bucket. Limits:</para>
        /// <list type="bullet">
        /// <item><description><para>Only lowercase letters, digits, and hyphens (-) are supported. The name must start and end with a lowercase letter or digit.</para>
        /// </description></item>
        /// <item><description><para>The maximum length is 128 characters.</para>
        /// </description></item>
        /// <item><description><para>UTF-8 encoding is used.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The OSS bucket must be an existing bucket in the region.</description></item>
        /// <item><description>The account id parameter is supported only by CPFS for Lingjun 2.6.0 and later.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://178321033379****:bucket-01</para>
        /// </summary>
        [NameInMap("SourceStorage")]
        [Validation(Required=false)]
        public string SourceStorage { get; set; }

        /// <summary>
        /// <para>The access path within the source storage bucket. Limits:</para>
        /// <list type="bullet">
        /// <item><description><para>The path must start and end with a forward slash (/).</para>
        /// </description></item>
        /// <item><description><para>The path is case-sensitive.</para>
        /// </description></item>
        /// <item><description><para>The path must be 1 to 1023 characters in length.</para>
        /// </description></item>
        /// <item><description><para>UTF-8 encoding is used.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when the file system type is CPFS for Lingjun.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/prefix/</para>
        /// </summary>
        [NameInMap("SourceStoragePath")]
        [Validation(Required=false)]
        public string SourceStoragePath { get; set; }

        /// <summary>
        /// <para>The maximum transfer bandwidth of the data flow. Unit: MB/s. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>600</description></item>
        /// <item><description>1200</description></item>
        /// <item><description>1500</description></item>
        /// </list>
        /// <remarks>
        /// <para>The transfer bandwidth of the data flow must be less than the I/O bandwidth of the file system.
        /// This parameter is required when the file system type is CPFS General-purpose.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("Throughput")]
        [Validation(Required=false)]
        public long? Throughput { get; set; }

    }

}
