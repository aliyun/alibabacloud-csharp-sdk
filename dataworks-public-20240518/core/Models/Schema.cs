// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class Schema : TeaModel {
        /// <summary>
        /// <para>The comment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The creation time. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1736852168000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The schema ID. For more information, see <a href="https://help.aliyun.com/document_detail/2880092.html">Concepts related to metadata entities.</a>.</para>
        /// <para>The format is <c>${EntityType}:${Instance ID or escaped URL}:${Catalog name}:${Database name}</c>. Use empty strings as placeholders for levels that do not exist.</para>
        /// <remarks>
        /// <para> For the MaxCompute type, the instance ID level is represented by an empty string. The database name is the name of the MaxCompute project, which has enabled the schema feature.</para>
        /// </remarks>
        /// <para>Examples of common ID formats</para>
        /// <para><c>maxcompute-project:::project_name</c> (For MaxCompute projects schema enabled)</para>
        /// <para><c>holo-schema:instance_id::database_name:schema_name</c></para>
        /// <remarks>
        /// <para>\
        /// <c>instance_id</c>: The Hologres instance ID\
        /// . <c>database_name</c>: The database name\
        /// . <c>project_name</c>: The MaxCompute project name\
        /// . <c>schema_name</c>: The schema name.</para>
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
        /// <para>The modification time. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1736852168000</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_db</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The parent entity ID. For more information, see <a href="https://help.aliyun.com/document_detail/2880092.html">Concepts related to metadata entities</a>.</para>
        /// <para>The format: <c>${EntityType}:${Instance ID or escaped URL}:${Catalog name}:${Database name}</c>. Use empty strings as placeholders for levels that do not exist.</para>
        /// <remarks>
        /// <para> For the MaxCompute type, the instance ID level is represented by an empty string. The database name is the name of the MaxCompute project with schema enabled.</para>
        /// </remarks>
        /// <para>Examples of common ParentMetaEntityId formats</para>
        /// <para><c>maxcompute-project:::project_name</c> (For MaxCompute projects with schema enabled)</para>
        /// <para><c>holo-database:instance_id::database_name</c></para>
        /// <remarks>
        /// <para>\
        /// <c>instance_id</c>: The Hologres instance ID\
        /// . <c>database_name</c>: The database name\
        /// . <c>project_name</c>: The MaxCompute project name.</para>
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
        /// <para>The type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MANAGED</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
