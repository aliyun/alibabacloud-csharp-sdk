// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class Schema : TeaModel {
        /// <summary>
        /// <para>注释。</para>
        /// 
        /// <b>Example:</b>
        /// <para>test comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>创建时间（毫秒级时间戳）。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1736852168000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>ID，可参考<a href="https://help.aliyun.com/document_detail/2880092.html">元数据实体相关概念说明</a>。</para>
        /// <para>格式为<c>${EntityType}:${实例ID或转义后的URL}:${数据目录名称}:${数据库名称}:${模式名称}</c>，对于不存在的层级置空。</para>
        /// <remarks>
        /// <para>对于MaxCompute类型，此处的实例ID即为主账号ID，数据库名称即为MaxCompute项目名称。</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-schema:123456XXX::test_project:default
        /// holo-schema:h-abc123xxx::test_db:test_schema</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>更新时间（毫秒级时间戳）。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1736852168000</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// <para>名称。</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_db</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>父层级元数据实体ID，父层级实体类型取值参考ListCrawlerTypes接口。</para>
        /// <para>格式为<c>${EntityType}:${实例ID或转义后的URL}:${数据目录名称}:${数据库名称}</c>，对于不存在的层级置空。</para>
        /// <remarks>
        /// <para>对于MaxCompute类型，此处的实例ID即为主账号ID，数据库名称即为MaxCompute项目名称。</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-project:123456XXX::test_project
        /// holo-database:h-abc123xxx::test_db</para>
        /// </summary>
        [NameInMap("ParentMetaEntityId")]
        [Validation(Required=false)]
        public string ParentMetaEntityId { get; set; }

        /// <summary>
        /// <para>类型。</para>
        /// 
        /// <b>Example:</b>
        /// <para>MANAGED</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
