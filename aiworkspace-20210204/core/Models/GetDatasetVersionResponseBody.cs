// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetDatasetVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>数据集的数据量</para>
        /// </summary>
        [NameInMap("DataCount")]
        [Validation(Required=false)]
        public long? DataCount { get; set; }

        /// <summary>
        /// <para>数据集版本的数据大小。</para>
        /// </summary>
        [NameInMap("DataSize")]
        [Validation(Required=false)]
        public long? DataSize { get; set; }

        /// <summary>
        /// <para>数据源类型。支持以下取值：</para>
        /// <list type="bullet">
        /// <item><description>OSS：阿里云对象存储（OSS）。</description></item>
        /// <item><description>NAS：阿里云文件存储（NAS）。</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>代表资源一级ID的资源属性字段</para>
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// <para>数据集版本的描述信息。</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>创建时间。</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("ImportInfo")]
        [Validation(Required=false)]
        public string ImportInfo { get; set; }

        /// <summary>
        /// <para>代表资源标签的资源属性字段</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        [NameInMap("MountAccess")]
        [Validation(Required=false)]
        public string MountAccess { get; set; }

        /// <summary>
        /// <para>扩展字段，JsonString类型。
        /// 当DLC使用数据集时，可通过配置mountPath字段指定数据集默认挂载路径。</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>数据集的属性。支持以下取值：</para>
        /// <list type="bullet">
        /// <item><description>FILE：文件。</description></item>
        /// <item><description>DIRECTORY：文件夹。</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Property")]
        [Validation(Required=false)]
        public string Property { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>数据来源ID。</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>数据来源类型，默认为USER。支持以下取值：</para>
        /// <list type="bullet">
        /// <item><description>PAI-PUBLIC-DATASET：PAI公共数据集。</description></item>
        /// <item><description>ITAG：iTAG模块标注结果生成的数据集。</description></item>
        /// <item><description>USER：用户注册的数据集。</description></item>
        /// </list>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>Uri配置样例如下：</para>
        /// <list type="bullet">
        /// <item><description>数据源类型为OSS：<c>oss://bucket.endpoint/object</c></description></item>
        /// <item><description>数据源类型为NAS：
        /// 通用型NAS格式为：<c>nas://&lt;nasfisid&gt;.region/subpath/to/dir/</c>；
        /// CPFS1.0：<c>nas://&lt;cpfs-fsid&gt;.region/subpath/to/dir/</c>；
        /// CPFS2.0：<c>nas://&lt;cpfs-fsid&gt;.region/&lt;protocolserviceid&gt;/</c>。
        /// CPFS1.0和CPFS2.0根据fsid的格式来区分：CPFS1.0 格式为cpfs-&lt;8位ascii字符&gt;；CPFS2.0 格式为cpfs-&lt;16为ascii字符&gt;。</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

        /// <summary>
        /// <para>代表资源名称的资源属性字段</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
