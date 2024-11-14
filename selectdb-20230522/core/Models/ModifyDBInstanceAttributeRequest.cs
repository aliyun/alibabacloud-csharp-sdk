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
        /// <para>The instance parameter to be modified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MaintainTime</b>: Modify the maintenance window of the instance in the hh:mm-hh:mm format.</description></item>
        /// <item><description><b>DBInstanceDescription</b>: Modify the description of the instance.</description></item>
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
        /// <para>The region ID of the instance.</para>
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
        /// <para>The new value of the instance parameter to be modified. Examples:</para>
        /// <list type="bullet">
        /// <item><description>If InstanceAttributeType is set to MaintainTime, you can set Value to 00:00-06:00.</description></item>
        /// <item><description>If InstanceAttributeType is set to DBInstanceDescription, you can set Value to testdb.</description></item>
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
