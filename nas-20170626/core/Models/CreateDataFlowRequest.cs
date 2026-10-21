// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateDataFlowRequest : TeaModel {
        /// <summary>
        /// <para>The auto-refresh interval. General-purpose CPFS checks whether data updates exist in the directory at this interval. If data updates exist, an auto-refresh task is started. Unit: minutes.</para>
        /// <para>Valid values: 10 to 525600. Default value: 10.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when the file system type is General-purpose CPFS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AutoRefreshInterval")]
        [Validation(Required=false)]
        public long? AutoRefreshInterval { get; set; }

        /// <summary>
        /// <para>The auto-refresh policy. This policy determines how data updates from the source storage are imported to General-purpose CPFS.</para>
        /// <list type="bullet">
        /// <item><description>None: Data updates from the source storage are not automatically imported to General-purpose CPFS. You can use a data flow task to import the updates. This is the default value.</description></item>
        /// <item><description>ImportChanged: Data updates from the source storage are automatically imported to General-purpose CPFS.<remarks>
        /// <para>This parameter takes effect only when the file system type is General-purpose CPFS.</para>
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
        /// <para>The auto-refresh configurations.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when the file system type is General-purpose CPFS.</para>
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
            /// <para>The auto-refresh directory. General-purpose CPFS registers data modification events of the source storage, checks whether the source data in this directory is updated, and automatically imports the updated data.</para>
            /// <para>By default, this parameter is empty. Data updates in the source storage are not automatically imported to General-purpose CPFS. You must create a manual task to import the updates.</para>
            /// <para>Limits:</para>
            /// <list type="bullet">
            /// <item><description>The directory must be 2 to 1,024 characters in length.</description></item>
            /// <item><description>The directory must be encoded in UTF-8.</description></item>
            /// <item><description>The directory must start and end with a forward slash (/).</description></item>
            /// <item><description>The directory must already exist in General-purpose CPFS and must be located in the fileset directory of the data flow.</description></item>
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
        /// <para>The client token that is used to ensure the idempotence of the request. You can generate the token on your client to ensure that the token is unique across different requests.</para>
        /// <para>The client token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">Ensure idempotence</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the client token. The RequestId of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the data flow. </para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The description must be 2 to 128 characters in length.</description></item>
        /// <item><description>The description must start with a letter and cannot start with <c>http://</c> or <c>https://</c>.</description></item>
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
        /// <para>Specifies whether to perform a dry run on the creation request.</para>
        /// <para>A dry run helps you check parameter validity and resource availability without actually creating the instance or incurring fees.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: A dry run is performed and no instance is created. The system checks whether required parameters are specified, the request format, business limits, and NAS resource availability. If the request fails the dry run, an error is returned. If the request passes the dry run, the HTTP status code 200 is returned, but the FileSystemId parameter is empty.</description></item>
        /// <item><description>false: A regular request is sent. If the request passes the dry run, the instance is created. This is the default value.</description></item>
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
        /// <item><description><para>General-purpose CPFS: The ID must start with <c>cpfs-</c>, such as cpfs-125487\<em>\</em>\<em>\</em>.</para>
        /// </description></item>
        /// <item><description><para>CPFS for Lingjun: The ID must start with <c>bmcpfs-</c>, such as bmcpfs-0015\<em>\</em>\<em>\</em>.</para>
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
        /// <item><description><para>The directory must start and end with a forward slash (/).</para>
        /// </description></item>
        /// <item><description><para>The directory must already exist in the CPFS for Lingjun file system.</para>
        /// </description></item>
        /// <item><description><para>The directory must be 1 to 1,023 characters in length.</para>
        /// </description></item>
        /// <item><description><para>The directory must be encoded in UTF-8.</para>
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
        /// <para>The fileset ID.</para>
        /// <remarks>
        /// <para>This parameter is required when the file system type is General-purpose CPFS.</para>
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
        /// <item><description>None: The source storage does not require security protection for access. This is the default value.</description></item>
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
        /// <item><description><para>storage type: Only oss is supported.</para>
        /// </description></item>
        /// <item><description><para>account id: Optional. The UID of the account to which the source storage belongs. This parameter is required when you use a cross-account OSS bucket.</para>
        /// </description></item>
        /// <item><description><para>path: The name of the OSS bucket. Limits:</para>
        /// <list type="bullet">
        /// <item><description><para>The name can contain only lowercase letters, digits, and hyphens (-), and must start and end with a lowercase letter or a digit.</para>
        /// </description></item>
        /// <item><description><para>The name can be up to 128 characters in length.</para>
        /// </description></item>
        /// <item><description><para>The name must be encoded in UTF-8.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The OSS bucket must already exist in the region.</description></item>
        /// <item><description>The account id parameter is supported only in CPFS for Lingjun 2.6.0 and later.</description></item>
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
        /// <para>The access path in the source storage bucket. Limits:</para>
        /// <list type="bullet">
        /// <item><description><para>The path must start and end with a forward slash (/).</para>
        /// </description></item>
        /// <item><description><para>The path is case-sensitive.</para>
        /// </description></item>
        /// <item><description><para>The path must be 1 to 1,023 characters in length.</para>
        /// </description></item>
        /// <item><description><para>The path must be encoded in UTF-8.</para>
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
        /// <para>The maximum transmission bandwidth of the data flow. Unit: MB/s. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>600</description></item>
        /// <item><description>1200</description></item>
        /// <item><description>1500</description></item>
        /// </list>
        /// <remarks>
        /// <para>The transmission bandwidth of the data flow must be less than the I/O bandwidth of the file system.
        /// This parameter is required when the file system type is General-purpose CPFS.</para>
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
