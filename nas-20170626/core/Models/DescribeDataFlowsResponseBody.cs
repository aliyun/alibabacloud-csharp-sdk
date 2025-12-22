// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeDataFlowsResponseBody : TeaModel {
        /// <summary>
        /// <para>The dataflow details.</para>
        /// </summary>
        [NameInMap("DataFlowInfo")]
        [Validation(Required=false)]
        public DescribeDataFlowsResponseBodyDataFlowInfo DataFlowInfo { get; set; }
        public class DescribeDataFlowsResponseBodyDataFlowInfo : TeaModel {
            [NameInMap("DataFlow")]
            [Validation(Required=false)]
            public List<DescribeDataFlowsResponseBodyDataFlowInfoDataFlow> DataFlow { get; set; }
            public class DescribeDataFlowsResponseBodyDataFlowInfoDataFlow : TeaModel {
                /// <summary>
                /// <para>The details about automatic update policies.</para>
                /// <remarks>
                /// <para> Only CPFS supports this parameter.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("AutoRefresh")]
                [Validation(Required=false)]
                public DescribeDataFlowsResponseBodyDataFlowInfoDataFlowAutoRefresh AutoRefresh { get; set; }
                public class DescribeDataFlowsResponseBodyDataFlowInfoDataFlowAutoRefresh : TeaModel {
                    [NameInMap("AutoRefresh")]
                    [Validation(Required=false)]
                    public List<DescribeDataFlowsResponseBodyDataFlowInfoDataFlowAutoRefreshAutoRefresh> AutoRefresh { get; set; }
                    public class DescribeDataFlowsResponseBodyDataFlowInfoDataFlowAutoRefreshAutoRefresh : TeaModel {
                        /// <summary>
                        /// <para>The automatic update directory. CPFS automatically checks whether the source data only in the directory is updated and imports the updated data.</para>
                        /// <para>Limits:</para>
                        /// <list type="bullet">
                        /// <item><description>The directory must be 2 to 1,024 characters in length.</description></item>
                        /// <item><description>The directory must be encoded in UTF-8.</description></item>
                        /// <item><description>The directory must start and end with a forward slash (/).</description></item>
                        /// </list>
                        /// <remarks>
                        /// <para> The directory must be an existing directory in the CPFS file system and must be in a fileset where the dataflow is enabled.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/prefix1/prefix2/</para>
                        /// </summary>
                        [NameInMap("RefreshPath")]
                        [Validation(Required=false)]
                        public string RefreshPath { get; set; }

                    }

                }

                /// <summary>
                /// <para>The automatic update interval. CPFS checks whether data is updated in the directory at the interval specified by this parameter. If data is updated, CPFS starts an automatic update task. Unit: minutes.</para>
                /// <para>Valid values: 5 to 526600. Default value: 10.</para>
                /// <remarks>
                /// <para> Only CPFS supports this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("AutoRefreshInterval")]
                [Validation(Required=false)]
                public long? AutoRefreshInterval { get; set; }

                /// <summary>
                /// <para>The automatic update policy. The updated data in the source storage is imported into the CPFS file system based on the policy. The following information is displayed:</para>
                /// <list type="bullet">
                /// <item><description>None: Updated data in the source storage is not automatically imported into the CPFS file system. You can run a dataflow task to import the updated data from the source storage.</description></item>
                /// <item><description>ImportChanged: Updated data in the source storage is automatically imported into the CPFS file system.</description></item>
                /// </list>
                /// <remarks>
                /// <para> Only CPFS is supported.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("AutoRefreshPolicy")]
                [Validation(Required=false)]
                public string AutoRefreshPolicy { get; set; }

                /// <summary>
                /// <para>The time when the fileset was created.</para>
                /// <para>The time follows the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format.</para>
                /// <remarks>
                /// <para> Only CPFS supports this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2021-09-30T10:08:08Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the dataflow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>df-194433a5be31****</para>
                /// </summary>
                [NameInMap("DataFlowId")]
                [Validation(Required=false)]
                public string DataFlowId { get; set; }

                /// <summary>
                /// <para>The description of the dataflow.</para>
                /// <para>Limits:</para>
                /// <list type="bullet">
                /// <item><description>The name must be 2 to 128 characters in length and</description></item>
                /// <item><description>start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</description></item>
                /// <item><description>The name can contain digits, letters, colons (:), underscores (_), and hyphens (-).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The error message. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>None (default): The dataflow status is normal.</description></item>
                /// <item><description>SourceStorageUnreachable: The access path of the source storage is not found.</description></item>
                /// <item><description>ThroughputTooLow: The dataflow throughput is low.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SourceStorageUnreachable</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The ID of the file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cpfs-099394bd928c****</para>
                /// </summary>
                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                /// <summary>
                /// <para>The directory of the fileset in the CPFS file system.</para>
                /// <para>Limits:</para>
                /// <list type="bullet">
                /// <item><description>The directory must be 2 to 1024 characters in length.</description></item>
                /// <item><description>The directory must be encoded in UTF-8.</description></item>
                /// <item><description>The directory must start and end with a forward slash (/).</description></item>
                /// <item><description>The directory must be a fileset directory in the CPFS file system.</description></item>
                /// </list>
                /// <remarks>
                /// <para> Only CPFS is supported.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>/a/b/c/</para>
                /// </summary>
                [NameInMap("FileSystemPath")]
                [Validation(Required=false)]
                public string FileSystemPath { get; set; }

                /// <summary>
                /// <para>The description of the automatic update.</para>
                /// <remarks>
                /// <para> Only CPFS supports this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>FsetTest</para>
                /// </summary>
                [NameInMap("FsetDescription")]
                [Validation(Required=false)]
                public string FsetDescription { get; set; }

                /// <summary>
                /// <para>The fileset ID.</para>
                /// <remarks>
                /// <para> Only CPFS supports this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>fset-1902718ea0ae****</para>
                /// </summary>
                [NameInMap("FsetId")]
                [Validation(Required=false)]
                public string FsetId { get; set; }

                /// <summary>
                /// <para>The type of security mechanism for the source storage. This parameter must be specified if the source storage is accessed with a security mechanism. Valid value:</para>
                /// <list type="bullet">
                /// <item><description>Null (default): The OSS bucket can be accessed without a security mechanism.</description></item>
                /// <item><description>SSL: The source storage must be accessed with an SSL certificate.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SSL</para>
                /// </summary>
                [NameInMap("SourceSecurityType")]
                [Validation(Required=false)]
                public string SourceSecurityType { get; set; }

                /// <summary>
                /// <para>The access path of the source storage. Format: <c>&lt;storage type&gt;://[&lt;account id&gt;:]&lt;path&gt;</c>.</para>
                /// <para>Among them:</para>
                /// <list type="bullet">
                /// <item><description><para>storage type: Only OSS is supported.</para>
                /// </description></item>
                /// <item><description><para>account id: The UID of the account of the source storage.</para>
                /// </description></item>
                /// <item><description><para>path: The name of the OSS bucket.</para>
                /// <list type="bullet">
                /// <item><description>The name can contain only lowercase letters, digits, and hyphens (-). The name must start and end with a lowercase letter or digit.</description></item>
                /// <item><description>The name must be 8 to 128 characters in length.</description></item>
                /// <item><description>Must be encoded in UTF-8.</description></item>
                /// <item><description>The name cannot start with http:// or https://.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>The OSS bucket must be an existing bucket in the region.</para>
                /// </description></item>
                /// <item><description><para>Only CPFS for Lingjun V2.6.0 and later support the account id parameter.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>oss://bucket1</para>
                /// </summary>
                [NameInMap("SourceStorage")]
                [Validation(Required=false)]
                public string SourceStorage { get; set; }

                /// <summary>
                /// <para>The access path in the bucket of the source storage.</para>
                /// <remarks>
                /// <para> Only CPFS for Lingjun supports this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>/prefix/</para>
                /// </summary>
                [NameInMap("SourceStoragePath")]
                [Validation(Required=false)]
                public string SourceStoragePath { get; set; }

                /// <summary>
                /// <para>The dataflow status. The following information is displayed:</para>
                /// <list type="bullet">
                /// <item><description>Starting: The dataflow is being created or enabled.</description></item>
                /// <item><description>Running: The dataflow has been created and is running properly.</description></item>
                /// <item><description>Updating: The dataflow is being modified. For example, the dataflow throughput is increased and the automatic update interval is modified.</description></item>
                /// <item><description>Deleting: The dataflow is being deleted.</description></item>
                /// <item><description>Stopping: The dataflow is being disabled.</description></item>
                /// <item><description>Stopped: The dataflow has been disabled.</description></item>
                /// <item><description>Misconfigured: The dataflow configuration is abnormal. For example, the source storage is inaccessible, and the automatic update cannot be completed due to low dataflow throughput.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The maximum dataflow throughput. Unit: MB/s. Valid value:</para>
                /// <list type="bullet">
                /// <item><description>600</description></item>
                /// <item><description>1200</description></item>
                /// <item><description>1500</description></item>
                /// </list>
                /// <remarks>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>The dataflow throughput must be less than the I/O throughput of the file system.</para>
                /// </description></item>
                /// <item><description><para>Only CPFS supports this parameter.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>600</para>
                /// </summary>
                [NameInMap("Throughput")]
                [Validation(Required=false)]
                public long? Throughput { get; set; }

                /// <summary>
                /// <para>The time when the fileset was last updated.</para>
                /// <para>The time follows the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format.</para>
                /// <remarks>
                /// <para> Only CPFS supports this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2021-09-30T10:08:08Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cmNlU****mVzJjE1MTI2NjY4NzY5MTAzOTEmMiZORnI4NDhVeEtrUT0=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D69A58F-345C-4FDE-88E4-BF518948****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
