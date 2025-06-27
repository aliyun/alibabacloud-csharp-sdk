// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetSchemaRequest : TeaModel {
        /// <summary>
        /// <para>The schema ID. You can call the ListSchemas operation to query the ID. For more information, see <a href="https://help.aliyun.com/document_detail/2880092.html">Concepts related to metadata entities</a>.</para>
        /// <para>The common format of this parameter is <c>${Entity type}:${Instance ID or escaped URL}:${Catalog identifier}:${Database name}:${Schema name}</c>. If a level does not exist, specify an empty string as a placeholder.</para>
        /// <remarks>
        /// <para> For MaxCompute tables, specify an empty string at the Instance ID level and a MaxCompute project name at the Database name level. Make sure that the three-layer model is enabled for the MaxCompute project.</para>
        /// </remarks>
        /// <para>You can configure this parameter in one of the following formats based on your data source type:</para>
        /// <para><c>maxcompute-schema:::project_name:schema_name</c> (Three-layer model is enabled for the MaxCompute project.)</para>
        /// <para><c>holo-schema:instance_id::database_name:schema_name</c></para>
        /// <remarks>
        /// <para>\
        /// <c>instance_id</c>: the ID of a Hologres instance\
        /// <c>database_name</c>: the name of a database\
        /// <c>project_name</c>: the name of a MaxCompute project\
        /// <c>schema_name</c>: the name of a schema</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-schema:123456XXX::test_project:default
        /// holo-schema:h-abc123xxx::test_db:test_schema</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}
