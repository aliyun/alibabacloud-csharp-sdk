// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class ModifyDBInstanceAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb-cn-7213cjv****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The attribute to modify. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>MaintainTime</b>: modifies the O&amp;M time. The format is hh:mm-hh:mm.</para>
        /// </description></item>
        /// <item><description><para><b>DBInstanceDescription</b>: modifies the instance description.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DBInstanceDescription</para>
        /// </summary>
        [NameInMap("InstanceAttributeType")]
        [Validation(Required=false)]
        public string InstanceAttributeType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The new value of the attribute. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If InstanceAttributeType is set to MaintainTime, set this parameter to a time range such as 00:00-06:00.</para>
        /// </description></item>
        /// <item><description><para>If InstanceAttributeType is set to DBInstanceDescription, set this parameter to a description such as testdb.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdb01</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
