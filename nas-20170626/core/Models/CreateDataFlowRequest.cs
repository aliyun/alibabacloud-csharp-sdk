// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateDataFlowRequest : TeaModel {
        /// <summary>
        /// <para>The automatic update interval. CPFS checks whether data is updated in the directory at the interval specified by this parameter. If data is updated, CPFS starts an automatic update task. Unit: minutes.</para>
        /// <para>Valid values: 10 to 525600. Default value: 10.</para>
        /// <remarks>
        /// <para> This parameter takes effect only for CPFS file systems.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AutoRefreshInterval")]
        [Validation(Required=false)]
        public long? AutoRefreshInterval { get; set; }

        /// <summary>
        /// <para>The automatic update policy. The updated data in the source storage is imported into the CPFS file system based on the policy.</para>
        /// <list type="bullet">
        /// <item><description>None (default): Updated data in the source storage is not automatically imported into the CPFS file system. You can run a data flow task to import the updated data from the source storage.</description></item>
        /// <item><description>ImportChanged: Updated data in the source storage is automatically imported into the CPFS file system.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect only for CPFS file systems.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AutoRefreshPolicy")]
        [Validation(Required=false)]
        public string AutoRefreshPolicy { get; set; }

        /// <summary>
        /// <para>The automatic update configurations.</para>
        /// <remarks>
        /// <para> This parameter takes effect only for CPFS file systems.</para>
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
            /// <para>The automatic update directory. CPFS registers the data update event in the source storage, and automatically checks whether the source data in the directory is updated and imports the updated data.</para>
            /// <para>This parameter is empty by default. Updated data in the source storage is not automatically imported into the CPFS file system. You must import the updated data by running a manual task.</para>
            /// <para>Limits:</para>
            /// <list type="bullet">
            /// <item><description>The directory must be 2 to 1,024 characters in length.</description></item>
            /// <item><description>The directory must be encoded in UTF-8.</description></item>
            /// <item><description>The directory must start and end with a forward slash (/).</description></item>
            /// <item><description>The directory must be an existing directory in the CPFS file system and must be in a fileset where the data flow is enabled.</description></item>
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
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.</para>
        /// <para>The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How do I ensure the idempotence?</a></para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the request ID as the client token. The value of RequestId may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the dataflow.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The description must be 2 to 128 characters in length.</description></item>
        /// <item><description>The description must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>The description can contain letters, digits, colons (:), underscores (_), and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Bucket01 DataFlow</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run.</para>
        /// <para>During the dry run, the system checks whether the request parameters are valid and whether the requested resources are available. During the dry run, no file system is created and no fee is incurred.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs a dry run. The system checks the required parameters, request syntax, limits, and available NAS resources. If the request fails the dry run, an error message is returned. If the request passes the dry run, the HTTP status code 200 is returned. No value is returned for the FileSystemId parameter.</description></item>
        /// <item><description>false (default): performs a dry run and sends the request. If the request passes the dry run, a file system is created.</description></item>
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
        /// <list type="bullet">
        /// <item><description>The IDs of CPFS file systems must start with <c>cpfs-</c>. Example: cpfs-125487\<em>\</em>\<em>\</em>.</description></item>
        /// <item><description>The IDs of CPFS for LINGJUN file systems must start with <c>bmcpfs-</c>. Example: bmcpfs-0015\<em>\</em>\<em>\</em>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> CPFS file systems are available only on the China site (aliyun.com).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpfs-099394bd928c****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The directory in the CPFS for LINGJUN file system. Limits:</para>
        /// <list type="bullet">
        /// <item><description>The directory must start and end with a forward slash (/).</description></item>
        /// <item><description>The directory must be an existing directory in the CPFS for LINGJUN file system.</description></item>
        /// <item><description>The directory must be 1 to 1023 characters in length.</description></item>
        /// <item><description>The directory must be encoded in UTF-8.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required for CPFS for LINGJUN file systems.</para>
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
        /// <para> This parameter is required for CPFS file systems.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>fset-1902718ea0ae****</para>
        /// </summary>
        [NameInMap("FsetId")]
        [Validation(Required=false)]
        public string FsetId { get; set; }

        /// <summary>
        /// <para>The type of security mechanism for the source storage. This parameter must be specified if the source storage is accessed with a security mechanism. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>None (default): The source storage can be accessed without a security mechanism.</description></item>
        /// <item><description>SSL: The source storage must be accessed with an SSL certificate.</description></item>
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
        /// <para>The access path of the source storage. Format: <c>&lt;storage type&gt;://&lt;path&gt;</c>.</para>
        /// <para>Parameters:</para>
        /// <list type="bullet">
        /// <item><description><para>storage type: Only OSS is supported.</para>
        /// </description></item>
        /// <item><description><para>path: the name of the OSS bucket. Limits:</para>
        /// <list type="bullet">
        /// <item><description>The path can contain only lowercase letters, digits, and hyphens (-). The path must start and end with a lowercase letter or digit.</description></item>
        /// <item><description>The path can be up to 128 characters in length.</description></item>
        /// <item><description>The path must be encoded in UTF-8.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> The OSS bucket must be an existing bucket in the region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://bucket1</para>
        /// </summary>
        [NameInMap("SourceStorage")]
        [Validation(Required=false)]
        public string SourceStorage { get; set; }

        /// <summary>
        /// <para>The access path in the bucket of the source storage. Limits:</para>
        /// <list type="bullet">
        /// <item><description>The path must start and end with a forward slash (/).</description></item>
        /// <item><description>The path is case-sensitive.</description></item>
        /// <item><description>The path must be 1 to 1023 characters in length.</description></item>
        /// <item><description>The path must be encoded in UTF-8.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required for CPFS for LINGJUN file systems.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/prefix/</para>
        /// </summary>
        [NameInMap("SourceStoragePath")]
        [Validation(Required=false)]
        public string SourceStoragePath { get; set; }

        /// <summary>
        /// <para>The maximum data flow throughput. Unit: MB/s. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>600</description></item>
        /// <item><description>1200</description></item>
        /// <item><description>1500</description></item>
        /// </list>
        /// <remarks>
        /// <para> The data flow throughput must be less than the I/O throughput of the file system. This parameter is required for CPFS file systems.</para>
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
