// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateLogicDatabaseShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The alias of the logical database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_logic_db</para>
        /// </summary>
        [NameInMap("Alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        /// <summary>
        /// <para>The IDs of the physical databases that compose the logical database. You can specify one or more database IDs. You can call the <a href="https://www.alibabacloud.com/help/en/data-management-service/latest/listdatabases">ListDatabases</a> or <a href="https://www.alibabacloud.com/help/en/data-management-service/latest/searchdatabase">SearchDatabase</a> operation to query the IDs of the physical databases.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DatabaseIds")]
        [Validation(Required=false)]
        public string DatabaseIdsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. </para>
        /// <remarks>
        /// <para> To view the ID of the tenant, move the pointer over the profile picture in the upper-right corner of the DMS console. For more information, see the &quot;View information about the current tenant&quot; section of the <a href="https://www.alibabacloud.com/help/en/data-management-service/latest/manage-dms-tenants">Manage DMS tenants</a> topic.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
