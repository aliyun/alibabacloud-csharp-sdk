// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetSchemaRequest : TeaModel {
        /// <summary>
        /// <para>The schema ID. You can call the ListSchemas operation to query schema IDs. For more information, see <a href="https://help.aliyun.com/document_detail/2880092.html">Concepts related to metadata entities</a>.</para>
        /// <para>Configure this parameter in the <c>${Entity type}:${Instance ID or escaped URL}:${Catalog identifier}:${Database name}:${Schema name}</c> format. If a level does not exist, leave the level empty.</para>
        /// <remarks>
        /// <para> If you want to query the information about a MaxCompute schema, specify an empty string at the Instance ID level as a placeholder and a MaxCompute project name at the Database name level. Make sure that the schema feature is enabled for the MaxCompute project.</para>
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
