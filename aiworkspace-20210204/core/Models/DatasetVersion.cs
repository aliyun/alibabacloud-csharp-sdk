// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class DatasetVersion : TeaModel {
        /// <summary>
        /// <para>DataCount</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("DataCount")]
        [Validation(Required=false)]
        public long? DataCount { get; set; }

        /// <summary>
        /// <para>DataSize</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("DataSize")]
        [Validation(Required=false)]
        public long? DataSize { get; set; }

        /// <summary>
        /// <para>DataSourceType</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>Description</para>
        /// 
        /// <b>Example:</b>
        /// <para>base model v1</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>create time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35.232Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>modify time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35.232Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>ImportInfo</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;region&quot;: &quot;cn-wulanchabu&quot;,
        ///     &quot;fileSystemId&quot;: &quot;bmcpfs-xxxxxxxxxxx&quot;,
        ///     &quot;path&quot;: &quot;/mnt&quot;,
        ///     &quot;mountTarget&quot;: &quot;cpfs-xxxxxxxxxxxx-vpc-gacs9f.cn-wulanchabu.cpfs.aliyuncs.com&quot;,
        ///     &quot;isVpcMount&quot;: true
        /// }</para>
        /// </summary>
        [NameInMap("ImportInfo")]
        [Validation(Required=false)]
        public string ImportInfo { get; set; }

        /// <summary>
        /// <para>Labels</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>MountAccess</para>
        /// 
        /// <b>Example:</b>
        /// <para>RO</para>
        /// </summary>
        [NameInMap("MountAccess")]
        [Validation(Required=false)]
        public string MountAccess { get; set; }

        /// <summary>
        /// <para>Options</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;mountPath&quot;: &quot;/mnt/data/&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>property</para>
        /// 
        /// <b>Example:</b>
        /// <para>FILE</para>
        /// </summary>
        [NameInMap("Property")]
        [Validation(Required=false)]
        public string Property { get; set; }

        /// <summary>
        /// <para>SourceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-65mrsr5fub4u74lej3</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>SourceType</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>Uri</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS://xxx</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

        /// <summary>
        /// <para>version name</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
