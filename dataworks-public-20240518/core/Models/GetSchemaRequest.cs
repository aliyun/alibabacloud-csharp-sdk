// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetSchemaRequest : TeaModel {
        /// <summary>
        /// <para>The ID. You can refer to the ListSchemas operation and <a href="https://help.aliyun.com/document_detail/2880092.html">Concepts related to metadata entities</a>.</para>
        /// <para>The format is <c>${EntityType}:${Instance ID or escaped URL}:${Catalog ID}:${Database name}:${Schema name}&lt;/code&gt;</c>. Use empty strings as placeholders for missing levels.</para>
        /// <remarks>
        /// <para>For the MaxCompute type, use an empty string as the placeholder for the instance ID level. The database name is the MaxCompute project name, and the project must have the three-level model enabled.</para>
        /// </remarks>
        /// <para>Examples:</para>
        /// <para><c>maxcompute-schema:::project_name:schema_name</c> (The three-level model is enabled for the MaxCompute project.)</para>
        /// <para><c>holo-schema:instance_id::database_name:schema_name</c></para>
        /// <remarks>
        /// <para><br><c>instance_id</c>: The Hologres instance ID<br>
        /// . <c>database_name</c>: The database name<br>
        /// . <c>database_name</c>: The MaxCompute project name<br>
        /// . <c>schema_name</c>: The schema name.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-schema:::project_name:schema_name</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}
