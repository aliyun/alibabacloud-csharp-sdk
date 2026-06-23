// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class ModifyDBConfigRequest : TeaModel {
        /// <summary>
        /// <para>The dictionary configuration items.</para>
        /// <remarks>
        /// <para>The value of the Config parameter overwrites the existing configuration. To delete a dictionary configuration, remove it from the request.</para>
        /// </remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/2360627.html">DescribeDBConfig</a> operation to query the dictionary configuration of the target instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para><dictionaries><dictionary><name>test_dictionary</name><source><clickhouse><host>10.0.0.0</host><port>3003</port><user>TestUser</user><password>testPassword</password><db>default</db><table>dictTestTable01</table><where>active=1</where><invalidate_query>SELECT max(value) FROM dictTestTable01</invalidate_query></clickhouse></source><lifetime><min>200</min><max>600</max></lifetime><layout><flat></flat></layout><structure><id><name>id</name><type>UInt64</type></id><attribute><name>value</name><type>String</type><null_value></null_value></attribute></structure></dictionary></dictionaries></para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-bp1r59y779o04****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region. Call the <a href="https://help.aliyun.com/document_detail/170875.html">DescribeRegions</a> operation to query the IDs of available regions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
