// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class ModifyDBInstanceAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The configuration that you want to modify.</para>
        /// <list type="bullet">
        /// <item><description>MaintainTime: the O\&amp;M time</description></item>
        /// <item><description>DBInstanceDescription: the cluster name</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DBInstanceDescription</para>
        /// </summary>
        [NameInMap("AttributeType")]
        [Validation(Required=false)]
        public string AttributeType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AttributeValue")]
        [Validation(Required=false)]
        public string AttributeValue { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-xxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The code of the cloud service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clickhouse</para>
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
